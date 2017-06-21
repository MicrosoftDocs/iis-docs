var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var requestLimitsElement = requestFilteringSection.ChildElements.Item("requestLimits");
var headerLimitsCollection = requestLimitsElement.ChildElements.Item("headerLimits").Collection;

var addElement = headerLimitsCollection.CreateNewElement("add");
addElement.Properties.Item("header").Value = "Content-type";
addElement.Properties.Item("sizeLimit").Value = 100;
headerLimitsCollection.AddElement(addElement);

adminManager.CommitChanges();