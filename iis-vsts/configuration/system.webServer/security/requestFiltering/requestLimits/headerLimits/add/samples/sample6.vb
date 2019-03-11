Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set requestLimitsElement = requestFilteringSection.ChildElements.Item("requestLimits")
Set headerLimitsCollection = requestLimitsElement.ChildElements.Item("headerLimits").Collection

Set addElement = headerLimitsCollection.CreateNewElement("add")
addElement.Properties.Item("header").Value = "Content-type"
addElement.Properties.Item("sizeLimit").Value = 100
headerLimitsCollection.AddElement(addElement)

adminManager.CommitChanges()