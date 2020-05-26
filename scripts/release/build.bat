@ECHO OFF
dotnet build -c %CONFIGURATION% -f %FRAMEWORK% -r %RUNTIME% ./src/AddTwoNumbers.sln
