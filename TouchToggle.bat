@echo off
"C:\Program Files (x86)\Windows Kits\10\Tools\x64\devcon.exe" status "*NTRG0001&Col02" | findstr Driver | (set /p active= & set active)

echo.%active | findstr /c:"Driver is running." 1 >nul
if errorlevel 1 (
	"C:\Program Files (x86)\Windows Kits\10\Tools\x64\devcon.exe" enable "*NTRG0001&Col02" 
) ELSE (
	"C:\Program Files (x86)\Windows Kits\10\Tools\x64\devcon.exe" disable "*NTRG0001&Col02"
)