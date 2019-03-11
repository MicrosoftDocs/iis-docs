@echo off

for /f "usebackq delims=|" %%a in (`dir /b *.log`) do (
    iisual.exe -logfile "%%a" -outputpostfix UAL
)