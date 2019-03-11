Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform" -name "processPath" -value "c:\dev\javasites\bin\apache-tomcat-8.0.15\bin\startup.bat"
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform" -name "arguments" -value ""
Set-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform" -name "stdoutLogFile" -value "="""\\?c:\dev\javasites\log.txt"

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform/environmentVariables" -name "." -value @{name='JRE_HOME';value='="""%programfiles%\java\jdk1.8.0_25'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform/environmentVariables" -name "." -value @{name='CATALINA_OPTS';value='="""-Dport.http=%HTTP_PLATFORM_PORT% -Dsomeotherconfig=value'}

Add-WebConfigurationProperty -pspath 'MACHINE/WEBROOT/APPHOST/JavaSites'  -filter "system.webServer/httpPlatform/environmentVariables" -name "." -value @{name='CATALINA_HOME';value='c:\dev\javasites\bin\apache-tomcat-8.0.15'}