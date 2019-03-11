appcmd.exe set config "JavaSites" -section:system.webServer/httpPlatform /processPath:"c:\dev\javasites\bin\apache-tomcat-8.0.15\bin\startup.bat" /arguments:"" /stdoutLogFile:"="""\\?c:\dev\javasites\log.txt"  

appcmd.exe set config "JavaSites" -section:system.webServer/httpPlatform /+"environmentVariables.[name='JRE_HOME',value='="""%programfiles%\java\jdk1.8.0_25']" 

appcmd.exe set config "JavaSites" -section:system.webServer/httpPlatform /+"environmentVariables.[name='CATALINA_OPTS',value='="""-Dport.http=%HTTP_PLATFORM_PORT% -Dsomeotherconfig=value']" 

appcmd.exe set config "JavaSites" -section:system.webServer/httpPlatform /+"environmentVariables.[name='CATALINA_HOME',value='c:\dev\javasites\bin\apache-tomcat-8.0.15']"