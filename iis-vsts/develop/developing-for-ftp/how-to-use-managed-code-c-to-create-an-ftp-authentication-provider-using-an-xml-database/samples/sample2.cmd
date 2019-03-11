net stop ftpsvc
call "%VS90COMNTOOLS%\vsvars32.bat">null
gacutil.exe /if "$(TargetPath)"
net start ftpsvc