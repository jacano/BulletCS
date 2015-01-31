@echo off

set "CURRENTDIR=%~dp0"
set PATH=%CURRENTDIR%..\swig-master\;%PATH%

swig -c++ -csharp -includeall -ignoremissing -namespace BulletSharp -outdir BulletSharp -o wrapper/bullet_wrap.cpp BulletSwig.i

pause