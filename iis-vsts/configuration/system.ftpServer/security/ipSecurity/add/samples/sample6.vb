Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set ipSecuritySection = adminManager.GetAdminSection("system.ftpServer/security/ipSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set ipSecurityCollection = ipSecuritySection.Collection

ipSecuritySection.Properties.Item("allowUnlisted").Value = True

Set addElement = ipSecurityCollection.CreateNewElement("add")
addElement.Properties.Item("ipAddress").Value = "127.0.0.1"
addElement.Properties.Item("allowed").Value = True
ipSecurityCollection.AddElement(addElement)

Set addElement1 = ipSecurityCollection.CreateNewElement("add")
addElement1.Properties.Item("ipAddress").Value = "169.254.0.0"
addElement1.Properties.Item("subnetMask").Value = "255.255.0.0"
ipSecurityCollection.AddElement(addElement1)

adminManager.CommitChanges()