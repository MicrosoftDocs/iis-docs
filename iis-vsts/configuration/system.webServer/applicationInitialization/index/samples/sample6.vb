Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set applicationInitializationSection = adminManager.GetAdminSection("system.webServer/applicationInitialization", "MACHINE/WEBROOT/APPHOST/Default Web Site")
applicationInitializationSection.Properties.Item("remapManagedRequestsTo").Value = "HelloJoe.htm"
applicationInitializationSection.Properties.Item("skipManagedModules").Value = true
applicationInitializationSection.Properties.Item("doAppInitAfterRestart").Value = true

Set applicationInitializationCollection = applicationInitializationSection.Collection

Set addElement = applicationInitializationCollection.CreateNewElement("add")
addElement.Properties.Item("initializationPage").Value = "JoesSite.htm"
addElement.Properties.Item("hostName").Value = "JoesHost"
applicationInitializationCollection.AddElement(addElement)

adminManager.CommitChanges()