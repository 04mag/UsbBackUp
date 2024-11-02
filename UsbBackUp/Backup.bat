@echo off

set STARTFOLDER=%1
set BACKUPFOLDER=%2
set PREVDRIVESERIAL=%3

set DESTINATIONDRIVE=%BACKUPFOLDER:~0,1%

REM for /f "tokens=5 delims= " %%a in (‘vol c: ^| Find “Serial Number”’) do ( … ):     
REM for /f bruges til at læse output fra en kommando linje for linje.     
REM "tokens=5 delims= " angiver, at den femte “token” (ord) i hver linje skal vælges. delims= angiver, at mellemrum bruges som afgrænsere.   
REM %%a er en placeholder for den værdi, der findes.    
REM in ('vol c: ^| Find "Serial Number"') kører kommandoen vol c: og filtrerer outputtet for linjen, der indeholder “Serial Number”.

REM set VOLSERIAL=%%a:
REM Denne del af kommandoen sætter variablen VOLSERIAL til værdien af %%a, som er den femte token i den linje, der indeholder “Serial Number”.

for /f "tokens=5 delims= " %%a in ('vol %DESTINATIONDRIVE%: ^| Find "Serial Number"') do (
set VOLSERIAL=%%a
)

if %VOLSERIAL% == %PREVDRIVESERIAL% exit /b 1

ECHO %VOLSERIAL%

xcopy %STARTFOLDER% %BACKUPFOLDER% /E /I /Y