var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/JavaSites";

var httpPlatformSection = adminManager.GetAdminSection("system.webServer/httpPlatform", "MACHINE/WEBROOT/APPHOST/JavaSites");
httpPlatformSection.Properties.Item("processPath").Value = "c:\\dev\\javasites\\bin\\apache-tomcat-8.0.15\\bin\\startup.bat";
httpPlatformSection.Properties.Item("arguments").Value = "";
httpPlatformSection.Properties.Item("stdoutLogFile").Value = "=\"\\\\?c:\\dev\\javasites\\log.txt";

var environmentVariablesCollection = httpPlatformSection.ChildElements.Item("environmentVariables").Collection;

var environmentVariableElement = environmentVariablesCollection.CreateNewElement("environmentVariable");
environmentVariableElement.Properties.Item("name").Value = "JRE_HOME";
environmentVariableElement.Properties.Item("value").Value = "=\"%programfiles%\\java\\jdk1.8.0_25";
environmentVariablesCollection.AddElement(environmentVariableElement);

var environmentVariableElement1 = environmentVariablesCollection.CreateNewElement("environmentVariable");
environmentVariableElement1.Properties.Item("name").Value = "CATALINA_OPTS";
environmentVariableElement1.Properties.Item("value").Value = "=\"-Dport.http=%HTTP_PLATFORM_PORT% -Dsomeotherconfig=value";
environmentVariablesCollection.AddElement(environmentVariableElement1);

var environmentVariableElement2 = environmentVariablesCollection.CreateNewElement("environmentVariable");
environmentVariableElement2.Properties.Item("name").Value = "CATALINA_HOME";
environmentVariableElement2.Properties.Item("value").Value = "c:\\dev\\javasites\\bin\\apache-tomcat-8.0.15";
environmentVariablesCollection.AddElement(environmentVariableElement2);

adminManager.CommitChanges();