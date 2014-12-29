/*PS3 MANAGER API
 * Copyright (c) 2014 _NzV_.
 *
 * This code is write by _NzV_ <donm7v@gmail.com>.
 * It may be used for any purpose as long as this notice remains intact on all
 * source code distributions.
 */
 
#ifndef __PS3MAPI_H__
#define __PS3MAPI_H__

#include <lv2/process.h>
#include <lv2/modules.h>

#define SYSCALL8_OPCODE_PS3MAPI			 		0x7777

//-----------------------------------------------
//CORE
//-----------------------------------------------

#define PS3MAPI_CORE_VERSION			 		0x0102
#define PS3MAPI_CORE_MINVERSION			 		0x0102

#if defined(FIRMWARE_4_46)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0446
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0446
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_53)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0453
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0453
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_55)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0455
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0455
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_50)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0450
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0450
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_50DEX)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0450
		#define PS3MAPI_FW_TYPE			 			"DEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0450
		#define PS3MAPI_FW_TYPE			 			"DEX COBRA"
	#endif
#elif defined(FIRMWARE_4_60)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0460
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0460
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_65)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0465
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0465
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#elif defined(FIRMWARE_4_66)
	#ifdef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0466
		#define PS3MAPI_FW_TYPE			 			"CEX MAMBA"
	#endif
	#ifndef IS_MAMBA
		#define PS3MAPI_FW_VERSION			 		0x0466
		#define PS3MAPI_FW_TYPE			 			"CEX COBRA"
	#endif
#endif

#define PS3MAPI_OPCODE_GET_CORE_VERSION			0x0011
#define PS3MAPI_OPCODE_GET_CORE_MINVERSION		0x0012
#define PS3MAPI_OPCODE_GET_FW_TYPE				0x0013
#define PS3MAPI_OPCODE_GET_FW_VERSION			0x0014

int ps3mapi_get_fw_type(char *fw);

//-----------------------------------------------
//PROCESSES
//-----------------------------------------------

#define PS3MAPI_OPCODE_GET_ALL_PROC_PID			0x0021
#define PS3MAPI_OPCODE_GET_PROC_NAME_BY_PID		0x0022
#define PS3MAPI_OPCODE_GET_PROC_BY_PID			0x0023
#define PS3MAPI_OPCODE_GET_CURRENT_PROC			0x0024
#define PS3MAPI_OPCODE_GET_CURRENT_PROC_CRIT	0x0025
#define PS3MAPI_OPCODE_KILL_PROC_BY_PID			0x0026

typedef uint32_t process_id_t;

int ps3mapi_get_all_processes_pid(process_id_t *pid_list);
int ps3mapi_get_process_name_by_pid(process_id_t pid, char *name);
int ps3mapi_get_process_by_pid(process_id_t pid, process_t process);
int ps3mapi_process_kill_by_pid(process_id_t pid);
int ps3mapi_get_current_process_critical(process_t process);
int ps3mapi_get_current_process(process_t process);

//-----------------------------------------------
//MEMORY
//-----------------------------------------------

#define PS3MAPI_OPCODE_GET_PROC_MEM				0x0031
#define PS3MAPI_OPCODE_SET_PROC_MEM				0x0032

int ps3mapi_set_process_mem(process_id_t pid, uint64_t addr, char *buf, int size );
int ps3mapi_get_process_mem(process_id_t pid, uint64_t addr, char *buf, int size );

//-----------------------------------------------
//MODULES
//-----------------------------------------------

#define PS3MAPI_OPCODE_GET_ALL_PROC_MODULE_PID		0x0041
#define PS3MAPI_OPCODE_GET_PROC_MODULE_NAME			0x0042
#define PS3MAPI_OPCODE_GET_PROC_MODULE_FILENAME		0x0043
#define PS3MAPI_OPCODE_LOAD_PROC_MODULE				0x0044
#define PS3MAPI_OPCODE_UNLOAD_PROC_MODULE			0x0045

int ps3mapi_get_all_process_modules_prx_id(process_id_t pid, sys_prx_id_t *prx_id_list);
int ps3mapi_get_process_module_name_by_prx_id(process_id_t pid, sys_prx_id_t prx_id, char *name);
int ps3mapi_get_process_module_filename_by_prx_id(process_id_t pid, sys_prx_id_t prx_id, char *name);
int ps3mapi_load_process_modules(process_id_t pid, char *path, void *arg, uint32_t arg_size);
int ps3mapi_unload_process_modules(process_id_t pid, sys_prx_id_t prx_id);

//-----------------------------------------------
//CLEAN SYSCALL
//-----------------------------------------------

#define SYSCALL8_OPCODE_STEALTH_TEST			0x3993 //PSNPatch stealth extension compatibility
#define SYSCALL8_OPCODE_STEALTH_ACTIVATE    	0x3995 //PSNPatch stealth extension compatibility
#define SYSCALL8_STEALTH_OK						0x5555 //PSNPatch stealth extension compatibility
#define PS3MAPI_OPCODE_CLEAN_SYSCALL			0x0091
#define PS3MAPI_OPCODE_FULL_CLEAN_SYSCALL		0x0092
#define PS3MAPI_OPCODE_CHECK_SYSCALL			0x0093

int ps3mapi_check_syscall(void);
int ps3mapi_clean_syscall(void);
int ps3mapi_full_clean_syscall(void);

#endif /* __PS3MAPI_H__ */

