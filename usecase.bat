@ECHO OFF
REM this script expects ready to use projects in dist folder
SET READ="./dist/win10-x64/ATN.READ/ATN.READ.exe"
SET CALC="./dist/win10-x64/ATN.CALC/ATN.CALC.exe"
SET WRITE="./dist/win10-x64/ATN.WRITE/ATN.WRITE.exe"
%READ% | %CALC% | %WRITE%