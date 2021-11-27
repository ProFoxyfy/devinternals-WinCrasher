@echo off
IF EXIST WinCrasher.exe (
    del WinCrasher.exe
)
vbc main.vb
ren main.exe WinCrasher.exe
echo Build Complete
pause