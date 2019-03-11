var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationInitializationSection = adminManager.GetAdminSection("system.webServer/applicationInitialization", "MACHINE/WEBROOT/APPHOST/Default Web Site");
applicationInitializationSection.Properties.Item("remapManagedRequestsTo").Value = "HelloJoe.htm";
applicationInitializationSection.Properties.Item("skipManagedModules").Value = true;
applicationInitializationSection.Properties.Item("doAppInitAfterRestart").Value = true;

var applicationInitializationCollection = applicationInitializationSection.Collection;

var addElement = applicationInitializationCollection.CreateNewElement("add");
addElement.Properties.Item("initializationPage").Value = "JoesSite.htm";
addElement.Properties.Item("hostName").Value = "JoesHost";
applicationInitializationCollection.AddElement(addElement);

adminManager.CommitChanges();