@echo off
set PS3DEV=./ps3dev
set PS3SDK=/c/PSDK3v2
set WIN_PS3SDK=C:/PSDK3v2
set PATH=%WIN_PS3SDK%/mingw/msys/1.0/bin;%WIN_PS3SDK%/mingw/bin;%PS3DEV%/ppu/bin;
rem %PATH%;

if not exist mamba mkdir mamba
del mamba\*.bin>nul
del *.bin>nul
make clean

pause

make all

if exist mamba_4_46.lz.bin     move  mamba_4_46.lz.bin     MAMBA\mamba_446C.lz.bin>nul
if exist mamba_4_50DEX.lz.bin  move  mamba_4_50DEX.lz.bin  MAMBA\mamba_450D.lz.bin>nul
if exist mamba_4_53.lz.bin     move  mamba_4_53.lz.bin     MAMBA\mamba_453C.lz.bin>nul
if exist mamba_4_55.lz.bin     move  mamba_4_55.lz.bin     MAMBA\mamba_455C.lz.bin>nul
if exist mamba_4_65.lz.bin     move  mamba_4_65.lz.bin     MAMBA\mamba_465C.lz.bin>nul
if exist mamba_4_66.lz.bin     move  mamba_4_66.lz.bin     MAMBA\mamba_466C.lz.bin>nul

if exist mamba_446C.bin        del mamba_446C.bin>nul
if exist mamba_450D.bin        del mamba_450D.bin>nul
if exist mamba_453C.bin        del mamba_453C.bin>nul
if exist mamba_455C.bin        del mamba_455C.bin>nul
if exist mamba_465C.bin        del mamba_465C.bin>nul
if exist mamba_466C.bin        del mamba_466C.bin>nul

if exist mamba_4_46.bin        ren  mamba_4_46.bin        mamba_446C.bin
if exist mamba_4_50DEX.bin     ren  mamba_4_50DEX.bin     mamba_450D.bin
if exist mamba_4_53.bin        ren  mamba_4_53.bin        mamba_453C.bin
if exist mamba_4_55.bin        ren  mamba_4_55.bin        mamba_455C.bin
if exist mamba_4_65.bin        ren  mamba_4_65.bin        mamba_465C.bin
if exist mamba_4_66.bin        ren  mamba_4_66.bin        mamba_466C.bin

:copy *.lz.bin ..\datas\*

pause
