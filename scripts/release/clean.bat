@ECHO OFF
rm -rf ./dist
dotnet clean -c %CONFIGURATION% -f %FRAMEWORK% ./src/AddTwoNumbers.sln