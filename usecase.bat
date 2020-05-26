@ECHO OFF
REM this script expects docker containers on your system, build with scripts/dockerize.bat
SET READ=docker run -i --rm atn-read
SET CALC=docker run -i --rm atn-calc
SET WRITE=docker run -i --rm atn-write
%READ% | %CALC% | %WRITE%