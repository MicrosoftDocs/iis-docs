appcmd.exe set config -section:system.applicationHost/log /centralLogFileMode:"CentralBinary" /commit:apphost

appcmd.exe set config -section:system.applicationHost/log /centralBinaryLogFile.period:"Daily" /commit:apphost