var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var aspSection = adminManager.GetAdminSection("system.webServer/asp", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var comPlusElement = aspSection.ChildElements.Item("comPlus");
comPlusElement.Properties.Item("trackThreadingModel").Value = true;
comPlusElement.Properties.Item("executeInMta").Value = true;

adminManager.CommitChanges();