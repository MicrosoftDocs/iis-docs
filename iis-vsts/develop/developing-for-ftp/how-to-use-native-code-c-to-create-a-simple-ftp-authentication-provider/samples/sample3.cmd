net stop ftpsvc
copy /y "$(TargetPath)" "%WINDIR%\System32\inetsrv"
regsvr32.exe /s "%WINDIR%\System32\inetsrv\$(TargetFileName)"
net start ftpsvc