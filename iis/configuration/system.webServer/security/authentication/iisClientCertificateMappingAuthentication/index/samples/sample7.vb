Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set iisClientCertificateMappingAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/iisClientCertificateMappingAuthentication", "MACHINE/WEBROOT/APPHOST/Default Web Site")
iisClientCertificateMappingAuthenticationSection.Properties.Item("enabled").Value = True
iisClientCertificateMappingAuthenticationSection.Properties.Item("manyToOneCertificateMappingsEnabled").Value = True

Set manyToOneMappingsCollection = iisClientCertificateMappingAuthenticationSection.ChildElements.Item("manyToOneMappings").Collection
Set addElement = manyToOneMappingsCollection.CreateNewElement("add")
addElement.Properties.Item("name").Value = "Contoso Employees"
addElement.Properties.Item("enabled").Value = True
addElement.Properties.Item("permissionMode").Value = "Allow"
addElement.Properties.Item("userName").Value = "Username"
addElement.Properties.Item("password").Value = "Password"

Set rulesCollection = addElement.ChildElements.Item("rules").Collection
Set addElement1 = rulesCollection.CreateNewElement("add")
addElement1.Properties.Item("certificateField").Value = "Subject"
addElement1.Properties.Item("certificateSubField").Value = "O"
addElement1.Properties.Item("matchCriteria").Value = "Contoso"
addElement1.Properties.Item("compareCaseSensitive").Value = True
rulesCollection.AddElement(addElement1)
manyToOneMappingsCollection.AddElement(addElement)

Set accessSection = adminManager.GetAdminSection("system.webServer/security/access", "MACHINE/WEBROOT/APPHOST/Default Web Site")
accessSection.Properties.Item("sslFlags").Value = "Ssl, SslNegotiateCert"

adminManager.CommitChanges()