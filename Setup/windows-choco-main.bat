echo "Installing..."
@echo off

set CHOCO_DIR=%ALLUSERSPROFILE%\chocolatey\bin
IF EXIST %CHOCO_DIR% goto install
@powershell -NoProfile -ExecutionPolicy Bypass -Command "iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))" && SET PATH=%PATH%;%CHOCO_DIR%

:install
choco install winrar -y
choco install vlc -y
choco install jdk7 -y
choco install python3 -y
choco install googlechrome -y
choco install notepadplusplus.install -y
choco install paint.net -y
choco install putty -y
REM doesn't work great choco install choco install github -y

set /p installVS="Install VS2015? yes|no (default=no):"
echo %installVS%
if "%installVS%"=="yes" (
 call choco install visualstudio2015community -y
)
