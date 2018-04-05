@echo off

rem A batch file for ApplicationEntryPoint.exe
rem The return value is stored within a system environment variable named %ERRORLEVEL%.
.\bin\Debug\ApplicationEntryPoint
@if "%ERRORLEVEL%" == "0" goto success

:fail
  echo This application has failed!
  echo return value = %ERRORLEVEL%
  goto end
:success
  echo This application has succeeded!
  echo return value = %ERRORLEVEL%
  goto end
:end
echo All Done.
