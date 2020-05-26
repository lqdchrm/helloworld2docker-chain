@ECHO OFF
dotnet test -c %CONFIGURATION% -f %FRAMEWORK% -r %RUNTIME% ./src/AddTwoNumbers.sln