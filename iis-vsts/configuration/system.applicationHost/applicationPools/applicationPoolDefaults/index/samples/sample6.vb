Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST")
Set applicationPoolDefaultsElement = applicationPoolsSection.ChildElements.Item("applicationPoolDefaults")
applicationPoolDefaultsElement.Properties.Item("autoStart").Value = True
applicationPoolDefaultsElement.Properties.Item("managedRuntimeVersion").Value = "v2.0"
applicationPoolDefaultsElement.Properties.Item("managedPipelineMode").Value = "Integrated"

adminManager.CommitChanges()