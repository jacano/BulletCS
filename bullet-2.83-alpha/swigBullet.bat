@echo off

set "CURRENTDIR=%~dp0"

rmdir /s /q ..\BulletCS.Shared\SWIG
timeout 1
mkdir ..\BulletCS.Shared\SWIG

rmdir /s /q wrapper
timeout 1
mkdir wrapper

timeout 1

set PATH=%CURRENTDIR%..\tools\swig-master\;%PATH%
swig -c++ -csharp -includeall -ignoremissing -namespace BulletSharp -outdir ../BulletCS.Shared/SWIG -o wrapper/bullet_wrap.cpp BulletSwig.i

timeout 1

set PATH=%CURRENTDIR%..\tools\;%PATH%
fnr.exe --cl --dir "%CURRENTDIR%\..\BulletCS.Shared\SWIG" --fileMask "BulletPINVOKE.cs" --find "DllImport(""Bullet""" --replace "DllImport(Native.dllName"

pause