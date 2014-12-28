/*PS3 MANAGER API
 * Copyright (c) 2014 _NzV_.
 *
 * This code is write by _NzV_ <donm7v@gmail.com>.
 * It may be used for any purpose as long as this notice remains intact on all
 * source code distributions.
 */
 
#include <lv2/lv2.h>
#include <lv2/libc.h>
#include <lv2/memory.h>
#include <lv2/patch.h>
#include <lv2/syscall.h>
#include <lv2/usb.h>
#include <lv2/storage.h>
#include <lv2/thread.h>
#include <lv2/synchronization.h>
#include <lv2/modules.h>
#include <lv2/io.h>
#include <lv2/time.h>
#include <lv2/security.h>
#include <lv2/error.h>
#include <lv2/symbols.h>
#include <lv1/stor.h>
#include <lv1/patch.h>

#include "ps3mapi_core.h"

//-----------------------------------------------
//CORE
//-----------------------------------------------

int ps3mapi_get_fw_type(char *fw)
{
	char tmp_fw[28];
	strcpy(tmp_fw, PS3MAPI_FW_TYPE);
	return copy_to_user(&tmp_fw, get_secure_user_ptr(fw), strlen(tmp_fw));
}

//-----------------------------------------------
//PROCESSES
//-----------------------------------------------

#define MAX_PROCESS 16

int ps3mapi_get_all_processes_pid(process_id_t *pid_list)
{
	uint32_t tmp_pid_list[MAX_PROCESS];
	uint64_t *proc_list = *(uint64_t **)MKA(TOC+process_rtoc_entry_1);	
	proc_list = *(uint64_t **)proc_list;
	proc_list = *(uint64_t **)proc_list;
	for (int i = 0; i < MAX_PROCESS; i++)
	{
		process_t process = (process_t)proc_list[1];	
		proc_list += 2;	
		if ((((uint64_t)process) & 0xFFFFFFFF00000000ULL) != MKA(0)) {tmp_pid_list[i] = 0; continue;}
		char *proc_name = get_process_name(process);
		if ( 8 < strlen(proc_name)) tmp_pid_list[i] = process->pid;	
		else tmp_pid_list[i] = 0 ;
	}
	return copy_to_user(&tmp_pid_list, get_secure_user_ptr(pid_list), sizeof(tmp_pid_list));
}

process_t ps3mapi_internal_get_process_by_pid(process_id_t pid)
{
	uint64_t *proc_list = *(uint64_t **)MKA(TOC+process_rtoc_entry_1);	
	proc_list = *(uint64_t **)proc_list;
	proc_list = *(uint64_t **)proc_list;	
	for (int i = 0; i < MAX_PROCESS; i++)
	{
		process_t p = (process_t)proc_list[1];	
		proc_list += 2;		
		if ((((uint64_t)p) & 0xFFFFFFFF00000000ULL) != MKA(0)) continue;
		if (p->pid == pid) return p;
	}
	return 0;
}

int ps3mapi_get_process_name_by_pid(process_id_t pid, char *name)
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	char proc_name[28];
	sprintf(proc_name, "%s", get_process_name(process));
	return copy_to_user(&proc_name, get_secure_user_ptr(name),  strlen(proc_name));
}

int ps3mapi_get_process_by_pid(process_id_t pid, process_t process)
{
	uint64_t *proc_list = *(uint64_t **)MKA(TOC+process_rtoc_entry_1);	
	proc_list = *(uint64_t **)proc_list;
	proc_list = *(uint64_t **)proc_list;	
	for (int i = 0; i < 0x10; i++)
	{
		process_t p = (process_t)proc_list[1];	
		proc_list += 2;		
		if ((((uint64_t)p) & 0xFFFFFFFF00000000ULL) != MKA(0)) continue;
		if (p->pid == pid) return copy_to_user(&p, get_secure_user_ptr(process), sizeof(process_t));
	}
	return 0;
}

int ps3mapi_process_kill_by_pid(process_id_t pid)
{
	 process_t process = ps3mapi_internal_get_process_by_pid(pid);
	 if (process == 0) return -1;
	 return process_kill(process);
}

int ps3mapi_get_current_process_critical(process_t process)
{
	suspend_intr();
	process_t p = get_current_process();
	resume_intr();
	if (p == 0) return -1;
	else return copy_to_user(&p, get_secure_user_ptr(process), sizeof(process_t));
}

int ps3mapi_get_current_process(process_t process)
{
	process_t p = get_current_process();
	if (process == 0) return -1;
	else return copy_to_user(&p, get_secure_user_ptr(process), sizeof(process_t));
}

//-----------------------------------------------
//MEMORY
//-----------------------------------------------

int ps3mapi_set_process_mem(process_id_t pid, uint64_t addr, char *buf, int size )
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	else return copy_to_process(process, (void *)get_secure_user_ptr(buf), (void *)addr, size);
}

int ps3mapi_get_process_mem(process_id_t pid, uint64_t addr, char *buff, int size )
{
	if (KB(64) < size) return -1;
	void *buf;
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -2;
	buf = alloc(size, 0x27);
	if (!buf) return -3;
	int ret = -4;
	ret = copy_from_process(process, (void *)addr, buf, size);
	ret = copy_to_user(buf, (void *)get_secure_user_ptr(buff), size);
	dealloc(buf, 0x27);
	return ret;
}

//-----------------------------------------------
//MODULES
//-----------------------------------------------

#define MAX_MODULES 64 //128

int ps3mapi_get_all_process_modules_prx_id(process_id_t pid, sys_prx_id_t *prx_id_list)
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	sys_prx_id_t tmp_prx_id_list[MAX_MODULES];
	sys_prx_id_t *list;
	uint32_t *unk;
	uint32_t n, unk2;
	list = alloc(MAX_MODULES*sizeof(sys_prx_module_info_t), 0x35);
	unk = alloc(MAX_MODULES*sizeof(uint32_t), 0x35);
	if (prx_get_module_list(process, list, unk, MAX_MODULES, &n, &unk2) == 0)
	{
		for (int i = 0; i < n; i++)
		{
			tmp_prx_id_list[i] = list[i];
		}
	}
	dealloc(list, 0x35);
	dealloc(unk, 0x35);
	return copy_to_user(&tmp_prx_id_list, get_secure_user_ptr(prx_id_list), sizeof(tmp_prx_id_list));

}

int ps3mapi_get_process_module_name_by_prx_id(process_id_t pid, sys_prx_id_t prx_id, char *name)
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	char *filename = alloc(256, 0x35);
	char tmp_name[256];
	sys_prx_segment_info_t *segments = alloc(sizeof(sys_prx_segment_info_t), 0x35);
	sys_prx_module_info_t modinfo;
	memset(&modinfo, 0, sizeof(sys_prx_module_info_t));
	modinfo.filename_size = 256;
	modinfo.segments_num = 1;
	if (prx_get_module_info(process, prx_id, &modinfo, filename, segments) == 0)
	{
		strcpy(tmp_name, filename);
		dealloc(filename, 0x35);
		dealloc(segments, 0x35);	
		return copy_to_user(&tmp_name, get_secure_user_ptr(name), strlen(tmp_name));		
	}
	else
	{
		
		dealloc(filename, 0x35);
		dealloc(segments, 0x35);
		return -2;
	}
}

int ps3mapi_load_process_modules(process_id_t pid, char *path, void *arg, uint32_t arg_size)
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	path = get_secure_user_ptr(path);
	arg = get_secure_user_ptr(arg);
	void *kbuf, *vbuf;
	sys_prx_id_t prx;
	int ret;	
	if (arg != NULL && arg_size > KB(64))return EINVAL;		
	prx = prx_load_module(process, 0, 0, path);
	if (prx < 0) return prx;
	if (arg && arg_size > 0)
	{	
		page_allocate_auto(process, KB(64), 0x2F, &kbuf);
		page_export_to_proc(process, kbuf, 0x40000, &vbuf);
		memcpy(kbuf, arg, arg_size);		
	}
	else vbuf = NULL;
	ret = prx_start_module_with_thread(prx, process, 0, (uint64_t)vbuf);
	if (vbuf)
	{
		page_unexport_from_proc(process, vbuf);
		page_free(process, kbuf, 0x2F);
	}	
	if (ret != 0)
	{
		prx_stop_module_with_thread(prx, process, 0, 0);
		prx_unload_module(prx, process);
	}
	return ret;
}

int ps3mapi_unload_process_modules(process_id_t pid, sys_prx_id_t prx_id)
{
	process_t process = ps3mapi_internal_get_process_by_pid(pid);
	if (process == 0) return -1;
	int ret = prx_stop_module_with_thread(prx_id, process, 0, 0);
	if (ret == 0) ret = prx_unload_module(prx_id, process);
	return ret;
}

//-----------------------------------------------
//SYSCALL
//-----------------------------------------------

int ps3mapi_check_syscall(void)
{
	uint64_t syscall_not_impl = *(uint64_t *)MKA(syscall_table_symbol);
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*6)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*7)) != syscall_not_impl) return -1;
	//if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*8)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*9)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*10)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*11)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*35)) != syscall_not_impl) return -1;
	if ((*(uint64_t *)MKA(syscall_table_symbol+ 8*36)) != syscall_not_impl) return -1;
	return 0;
}

int ps3mapi_clean_syscall(void)
{
	uint64_t syscall_not_impl = *(uint64_t *)MKA(syscall_table_symbol);
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 9) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*10) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*11) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*35) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*36) = syscall_not_impl;
	#ifdef IS_MAMBA
		*(uint64_t *)MKA(syscall_table_symbol+ 8*1022) = syscall_not_impl;
	#endif
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 6) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 7) = syscall_not_impl;
	return 0;
}

int ps3mapi_full_clean_syscall(void)
{
	uint64_t syscall_not_impl = *(uint64_t *)MKA(syscall_table_symbol);
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 8) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 9) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*10) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*11) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*35) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8*36) = syscall_not_impl;
	#ifdef IS_MAMBA
		*(uint64_t *)MKA(syscall_table_symbol+ 8*1022) = syscall_not_impl;
	#endif
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 6) = syscall_not_impl;
	*(uint64_t *)MKA(syscall_table_symbol+ 8* 7) = syscall_not_impl;
	return 0;
}
