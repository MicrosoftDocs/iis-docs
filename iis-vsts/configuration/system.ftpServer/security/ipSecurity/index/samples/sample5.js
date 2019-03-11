var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var ipSecuritySection = adminManager.GetAdminSection("system.ftpServer/security/ipSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var ipSecurityCollection = ipSecuritySection.Collection;

ipSecuritySection.Properties.Item("allowUnlisted").Value = true;

var addElement = ipSecurityCollection.CreateNewElement("add");
addElement.Properties.Item("ipAddress").Value = "127.0.0.1";
addElement.Properties.Item("allowed").Value = true;
ipSecurityCollection.AddElement(addElement);

var addElement1 = ipSecurityCollection.CreateNewElement("add");
addElement1.Properties.Item("ipAddress").Value = "169.254.0.0";
addElement1.Properties.Item("subnetMask").Value = "255.255.0.0";
ipSecurityCollection.AddElement(addElement1);

adminManager.CommitChanges();