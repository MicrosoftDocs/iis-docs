appcmd.exe set config "Default Web Site" -section:system.webServer/odbcLogging /dataSource:"InternetDb" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/odbcLogging /tableName:"InternetLog" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/odbcLogging /userName:"InternetAdmin" /commit:apphost
appcmd.exe set config "Default Web Site" -section:system.webServer/odbcLogging /password:"P@ssw0rd" /commit:apphost

appcmd.exe set sites "Default Web Site" -logFile.logFormat:"Custom" /commit:apphost
appcmd.exe set sites "Default Web Site" -logFile.customLogPluginClsid:"{FF16065B-DE82-11CF-BC0A-00AA006111E0}" /commit:apphost