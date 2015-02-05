@echo off
set "CURRENTDIR=%~dp0"
set PATH=%CURRENTDIR%../tools;%PATH%

REM Windows
junction %CURRENTDIR%../Windows/BulletWrap/BulletWrap.Shared %CURRENTDIR%Bullet
junction %CURRENTDIR%../Windows/BulletWrap/BulletWrap.Shared %CURRENTDIR%wrapper
