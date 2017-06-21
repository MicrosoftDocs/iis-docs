Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"
Set httpCompressionSection = adminManager.GetAdminSection("system.webServer/httpCompression", "MACHINE/WEBROOT/APPHOST")
Set httpCompressionCollection = httpCompressionSection.Collection

Set schemeElement = httpCompressionCollection.CreateNewElement("scheme")
schemeElement.Properties.Item("name").Value = "deflate"
schemeElement.Properties.Item("doStaticCompression").Value = True
schemeElement.Properties.Item("doDynamicCompression").Value = True
schemeElement.Properties.Item("dll").Value = "%Windir%\system32\inetsrv\gzip.dll"
httpCompressionCollection.AddElement(schemeElement)

adminManager.CommitChanges()