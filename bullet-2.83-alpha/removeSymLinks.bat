@echo off
set "CURRENTDIR=%~dp0"
set PATH=%CURRENTDIR%tools;%PATH%

REM Windows
junction -d %CURRENTDIR%../Windows/BulletWrap/BulletWrap.Shared/Bullet
junction -d %CURRENTDIR%../Windows/BulletWrap/BulletWrap.Shared/wrapper


