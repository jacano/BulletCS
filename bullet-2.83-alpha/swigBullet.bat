@echo off

set "CURRENTDIR=%~dp0"
set PATH=%CURRENTDIR%..\swig-master\;%PATH%

rmdir /s /q ..\BulletCS.Shared\SWIG
timeout 1
mkdir ..\BulletCS.Shared\SWIG

rmdir /s /q wrapper
timeout 1
mkdir wrapper

timeout 1

swig -c++ -csharp -includeall -ignoremissing -namespace BulletSharp -outdir ../BulletCS.Shared/SWIG -o wrapper/bullet_wrap.cpp BulletSwig.i

pause