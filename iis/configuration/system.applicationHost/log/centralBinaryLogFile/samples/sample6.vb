Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set logSection = adminManager.GetAdminSection("system.applicationHost/log", "MACHINE/WEBROOT/APPHOST")
logSection.Properties.Item("centralLogFileMode").Value = "CentralBinary"
Set centralBinaryLogFileElement = logSection.ChildElements.Item("centralBinaryLogFile")
centralBinaryLogFileElement.Properties.Item("period").Value = "Daily"

adminManager.CommitChanges()