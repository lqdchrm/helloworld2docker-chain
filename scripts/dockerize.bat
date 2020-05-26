@ECHO OFF
REM build docker image
CALL ./scripts/release.bat
CALL ./scripts/docker/build.bat