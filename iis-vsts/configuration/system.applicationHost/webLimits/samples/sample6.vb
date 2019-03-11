Set adminManager = WScript.CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set webLimitsSection = adminManager.GetAdminSection("system.applicationHost/webLimits", "MACHINE/WEBROOT/APPHOST")
webLimitsSection.Properties.Item("connectionTimeout").Value = "00:01:00"
webLimitsSection.Properties.Item("dynamicIdleThreshold").Value = 150
webLimitsSection.Properties.Item("headerWaitTimeout").Value = "00:00:30"
webLimitsSection.Properties.Item("minBytesPerSecond").Value = 500

adminManager.CommitChanges()