using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetWebConfiguration("JavaSites");
            
            ConfigurationSection httpPlatformSection = config.GetSection("system.webServer/httpPlatform");
            httpPlatformSection["processPath"] = @"c:\dev\javasites\bin\apache-tomcat-8.0.15\bin\startup.bat";
            httpPlatformSection["arguments"] = @"";
            httpPlatformSection["stdoutLogFile"] = @"=""\\?c:\dev\javasites\log.txt";
            
            ConfigurationElementCollection environmentVariablesCollection = httpPlatformSection.GetCollection("environmentVariables");
            
            ConfigurationElement environmentVariableElement = environmentVariablesCollection.CreateElement("environmentVariable");
            environmentVariableElement["name"] = @"JRE_HOME";
            environmentVariableElement["value"] = @"=""%programfiles%\java\jdk1.8.0_25";
            environmentVariablesCollection.Add(environmentVariableElement);
            
            ConfigurationElement environmentVariableElement1 = environmentVariablesCollection.CreateElement("environmentVariable");
            environmentVariableElement1["name"] = @"CATALINA_OPTS";
            environmentVariableElement1["value"] = @"=""-Dport.http=%HTTP_PLATFORM_PORT% -Dsomeotherconfig=value";
            environmentVariablesCollection.Add(environmentVariableElement1);
            
            ConfigurationElement environmentVariableElement2 = environmentVariablesCollection.CreateElement("environmentVariable");
            environmentVariableElement2["name"] = @"CATALINA_HOME";
            environmentVariableElement2["value"] = @"c:\dev\javasites\bin\apache-tomcat-8.0.15";
            environmentVariablesCollection.Add(environmentVariableElement2);
            
            serverManager.CommitChanges();
        }
    }
}