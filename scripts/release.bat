@ECHO OFF
SET CONFIGURATION=Release
SET FRAMEWORK=netcoreapp3.1
SET RUNTIME=win10-x64
CALL ./scripts/release/clean.bat && CALL ./scripts/release/build.bat && CALL ./scripts/release/test.bat && CALL ./scripts/release/package.bat
REM CALL ./scripts/release/build.bat && CALL ./scripts/release/test.bat && CALL ./scripts/release/package.bat
