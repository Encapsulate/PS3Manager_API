@echo off

set PS3DEV=./ps3dev
set PS3SDK=/c/PSDK3v2
set WIN_PS3SDK=C:/PSDK3v2
set PATH=%WIN_PS3SDK%/mingw/msys/1.0/bin;%WIN_PS3SDK%/mingw/bin;%PS3DEV%/ppu/bin;

rem %PATH%;

if exist mamba del mamba\*.lz.bin>nul
if exist mamba rmdir mamba

del *.bin>nul

make clean

make all

if not exist mamba mkdir mamba

if exist mamba_3_55.lz.bin     move  mamba_3_55.lz.bin     mamba\mamba_355C.lz.bin>nul
if exist mamba_4_21.lz.bin     move  mamba_4_21.lz.bin     mamba\mamba_421C.lz.bin>nul
if exist mamba_4_21DEX.lz.bin  move  mamba_4_21DEX.lz.bin  mamba\mamba_421D.lz.bin>nul
if exist mamba_4_30DEX.lz.bin  move  mamba_4_30DEX.lz.bin  mamba\mamba_430D.lz.bin>nul
if exist mamba_4_30.lz.bin     move  mamba_4_30.lz.bin     mamba\mamba_430C.lz.bin>nul
if exist mamba_4_31.lz.bin     move  mamba_4_31.lz.bin     mamba\mamba_431C.lz.bin>nul
if exist mamba_4_40.lz.bin     move  mamba_4_40.lz.bin     mamba\mamba_440C.lz.bin>nul
if exist mamba_4_41.lz.bin     move  mamba_4_41.lz.bin     mamba\mamba_441C.lz.bin>nul
if exist mamba_4_41DEX.lz.bin  move  mamba_4_41DEX.lz.bin  mamba\mamba_441D.lz.bin>nul
if exist mamba_4_46.lz.bin     move  mamba_4_46.lz.bin     mamba\mamba_446C.lz.bin>nul
if exist mamba_4_46DEX.lz.bin  move  mamba_4_46DEX.lz.bin  mamba\mamba_446D.lz.bin>nul
if exist mamba_4_50.lz.bin     move  mamba_4_50.lz.bin     mamba\mamba_450C.lz.bin>nul
if exist mamba_4_50DEX.lz.bin  move  mamba_4_50DEX.lz.bin  mamba\mamba_450D.lz.bin>nul
if exist mamba_4_53.lz.bin     move  mamba_4_53.lz.bin     mamba\mamba_453C.lz.bin>nul
if exist mamba_4_53DEX.lz.bin  move  mamba_4_53DEX.lz.bin  mamba\mamba_453D.lz.bin>nul
if exist mamba_4_55.lz.bin     move  mamba_4_55.lz.bin     mamba\mamba_455C.lz.bin>nul
if exist mamba_4_55DEX.lz.bin  move  mamba_4_55DEX.lz.bin  mamba\mamba_455D.lz.bin>nul
if exist mamba_4_60.lz.bin     move  mamba_4_60.lz.bin     mamba\mamba_460C.lz.bin>nul
if exist mamba_4_65.lz.bin     move  mamba_4_65.lz.bin     mamba\mamba_465C.lz.bin>nul
if exist mamba_4_65DEX.lz.bin  move  mamba_4_65DEX.lz.bin  mamba\mamba_465D.lz.bin>nul
if exist mamba_4_66.lz.bin     move  mamba_4_66.lz.bin     mamba\mamba_466C.lz.bin>nul
if exist mamba_4_66DEX.lz.bin  move  mamba_4_66DEX.lz.bin  mamba\mamba_466D.lz.bin>nul

del *.bin>nul

pause
