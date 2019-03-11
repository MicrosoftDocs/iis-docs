net stop ftpsvc
call "%VS100COMNTOOLS%\vsvars32.bat">nul
gacutil.exe /if "$(TargetPath)"
net start ftpsvc