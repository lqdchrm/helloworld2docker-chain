@ECHO OFF
CALL ./scripts/env.bat
CALL ./scripts/release/clean.bat && CALL ./scripts/release/build.bat && CALL ./scripts/release/test.bat && CALL ./scripts/release/package.bat