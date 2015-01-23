#include <fcntl.h>
#include <ppu-lv2.h>
#include <sys/file.h>
#include <stdio.h>
#include <string.h>

#include <io/pad.h>

#define SUCCESS 0
#define FAILED -1

#define SC_SYS_POWER 					(379)
#define SYS_REBOOT				 		0x8201
#define SC_FS_MOUNT  					(837)


int CopyFile(char* path, char* path2)
{
	int ret = 0;
	s32 fd = -1;
	s32 fd2 = -1;
	u64 lenght = 0LL;

	u64 pos = 0ULL;
	u64 readed = 0, writed = 0;

	char *mem = NULL;

	sysFSStat stat;

	ret= sysLv2FsStat(path, &stat);
	if(ret) goto skip;

	if(!memcmp(path, "/dev_hdd0/", 10) && !memcmp(path2, "/dev_hdd0/", 10))
	{
		if(strcmp(path, path2)==0) return ret;

		sysLv2FsUnlink(path2);
		return sysLv2FsLink(path, path2);
	}

    lenght = stat.st_size;

	ret = sysLv2FsOpen(path, 0, &fd, S_IRWXU | S_IRWXG | S_IRWXO, NULL, 0);
	if(ret) goto skip;

	ret = sysLv2FsOpen(path2, SYS_O_WRONLY | SYS_O_CREAT | SYS_O_TRUNC, &fd2, 0777, NULL, 0);
	if(ret) {sysLv2FsClose(fd);goto skip;}

	mem = malloc(0x100000);
	if (mem == NULL) return FAILED;

	while(pos < lenght)
	{
		readed = lenght - pos; if(readed > 0x100000ULL) readed = 0x100000ULL;
		ret=sysLv2FsRead(fd, mem, readed, &writed);
		if(ret<0) goto skip;
		if(readed != writed) {ret = 0x8001000C; goto skip;}

		ret=sysLv2FsWrite(fd2, mem, readed, &writed);
		if(ret<0) goto skip;
		if(readed != writed) {ret = 0x8001000C; goto skip;}

		pos += readed;
	}

skip:

	if(mem) free(mem);
	if(fd >=0) sysLv2FsClose(fd);
	if(fd2>=0) sysLv2FsClose(fd2);
	if(ret>0) ret = SUCCESS;

	return ret;
}

bool is_cobra(void)
{
	sysFSStat stat;
	if(sysLv2FsStat("/dev_flash/sys/stage2.bin", &stat) == SUCCESS) return true;
	else if(sysLv2FsStat("/dev_flash/sys/stage2_disabled.bin", &stat) == SUCCESS) return true;
	else return false;
}

int main()
{
	if(is_cobra())
	{
		sysFSStat stat;
		//Enable dev_blind
		if(sysLv2FsStat("/dev_blind/vsh/module/webftp_server.sprx", &stat) != SUCCESS)
			{{lv2syscall8(SC_FS_MOUNT, (u64)(char*)"CELL_FS_IOS:BUILTIN_FLSH1", (u64)(char*)"CELL_FS_FAT", (u64)(char*)"/dev_blind", 0, 0, 0, 0, 0); }}
		//Install new stage2.bin
		if((sysLv2FsStat("/dev_blind/sys/stage2.bin", &stat) == SUCCESS))
		{
			sysLv2FsChmod("/dev_blind/sys/stage2.bin", 0777);
			if((sysLv2FsStat("/dev_blind/sys/stage2.bin.bak", &stat) != SUCCESS))
			{
				sysLv2FsRename("/dev_blind/sys/stage2.bin", "/dev_blind/sys/stage2.bin.bak");
				sysLv2FsChmod("/dev_blind/sys/stage2.bin.bak", 0777);
			}
			if((sysLv2FsStat("/dev_blind/sys/stage2.bin", &stat) == SUCCESS)) sysLv2FsUnlink("/dev_blind/sys/stage2.bin");
			CopyFile("/dev_hdd0/game/PS3MAPI00/USRDIR/stage2.bin", "/dev_blind/sys/stage2.bin");					
		}
		else if((sysLv2FsStat("/dev_blind/sys/stage2_disabled.bin", &stat) == SUCCESS))
		{
			sysLv2FsChmod("/dev_blind/sys/stage2_disabled.bin", 0777);
			if((sysLv2FsStat("/dev_blind/sys/stage2.bin.bak", &stat) != SUCCESS))
			{
				sysLv2FsRename("/dev_blind/sys/stage2_disabled.bin", "/dev_blind/sys/stage2.bin.bak");
				sysLv2FsChmod("/dev_blind/sys/stage2.bin.bak", 0777);
			}
			if((sysLv2FsStat("/dev_blind/sys/stage2_disabled.bin", &stat) == SUCCESS)) sysLv2FsUnlink("/dev_blind/sys/stage2_disabled.bin");
			if((sysLv2FsStat("/dev_blind/sys/stage2.bin", &stat) == SUCCESS)) sysLv2FsUnlink("/dev_blind/sys/stage2.bin");
			CopyFile("/dev_hdd0/game/PS3MAPI00/USRDIR/stage2.bin", "/dev_blind/sys/stage2.bin");					
		}
		else  { {lv2syscall3(392, 0x1004, 0xa, 0x1b6); } goto exit_error;}
		//Exit with succes
		{lv2syscall3(392, 0x1004, 0x4, 0x6); }
		// reboot
		sysLv2FsUnlink("/dev_hdd0/tmp/turnoff");
		{lv2syscall3(SC_SYS_POWER, SYS_REBOOT, 0, 0); return_to_user_prog(int);}
		return 0;
	}
	else { {lv2syscall3(392, 0x1004, 0x7, 0x36); } goto exit_error;}
	//Exit with error
exit_error:
	//Get back to xmb
	return FAILED;
}