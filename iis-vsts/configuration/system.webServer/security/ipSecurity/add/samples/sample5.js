var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var ipSecuritySection = adminManager.GetAdminSection("system.webServer/security/ipSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var ipSecurityCollection = ipSecuritySection.Collection;

var addElement = ipSecurityCollection.CreateNewElement("add");
addElement.Properties.Item("ipAddress").Value = "192.168.100.1";
addElement.Properties.Item("allowed").Value = false;
ipSecurityCollection.AddElement(addElement);

var addElement1 = ipSecurityCollection.CreateNewElement("add");
addElement1.Properties.Item("ipAddress").Value = "169.254.0.0";
addElement1.Properties.Item("subnetMask").Value = "255.255.0.0";
addElement1.Properties.Item("allowed").Value = false;
ipSecurityCollection.AddElement(addElement1);

adminManager.CommitChanges();