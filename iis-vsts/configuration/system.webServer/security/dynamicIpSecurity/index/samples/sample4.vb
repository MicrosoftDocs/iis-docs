Imports System
Imports System.Text
Imports Microsoft.Web.Administration
Module Sample

   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetApplicationHostConfiguration
      Dim dynamicIpSecuritySection As ConfigurationSection = config.GetSection("system.webServer/security/dynamicIpSecurity", "Default Web Site")
      dynamicIpSecuritySection("denyAction") = "Forbidden"
      dynamicIpSecuritySection("enableProxyMode") = true
      dynamicIpSecuritySection("enableLoggingOnlyMode") = true
      Dim denyByConcurrentRequestsElement As ConfigurationElement = dynamicIpSecuritySection.GetChildElement("denyByConcurrentRequests")
      denyByConcurrentRequestsElement("enabled") = true
      denyByConcurrentRequestsElement("maxConcurrentRequests") = 10
      Dim denyByRequestRateElement As ConfigurationElement = dynamicIpSecuritySection.GetChildElement("denyByRequestRate")
      denyByRequestRateElement("enabled") = true
      denyByRequestRateElement("maxRequests") = 10
      denyByRequestRateElement("requestIntervalInMilliseconds") = 10
      serverManager.CommitChanges
   End Sub
End Module