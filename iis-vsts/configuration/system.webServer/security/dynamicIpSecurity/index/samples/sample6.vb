Set adminManager = CreateObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST"

Set dynamicIpSecuritySection = adminManager.GetAdminSection ("system.webServer/security/dynamicIpSecurity", "MACHINE/WEBROOT/APPHOST/Default Web Site")
dynamicIpSecuritySection.Properties.Item("denyAction").Value = "Unauthorized"
dynamicIpSecuritySection.Properties.Item("enableProxyMode").Value = true
dynamicIpSecuritySection.Properties.Item("enableLoggingOnlyMode").Value = true
Set denyByConcurrentRequestsElement = dynamicIpSecuritySection.ChildElements.Item ("denyByConcurrentRequests")
denyByConcurrentRequestsElement.Properties.Item("enabled").Value = true
denyByConcurrentRequestsElement.Properties.Item("maxConcurrentRequests").Value = 10
Set denyByRequestRateElement = dynamicIpSecuritySection.ChildElements.Item("denyByRequestRate")
denyByRequestRateElement.Properties.Item("enabled").Value = true
denyByRequestRateElement.Properties.Item("maxRequests").Value = 25
denyByRequestRateElement.Properties.Item("requestIntervalInMilliseconds").Value = 210

adminManager.CommitChanges()