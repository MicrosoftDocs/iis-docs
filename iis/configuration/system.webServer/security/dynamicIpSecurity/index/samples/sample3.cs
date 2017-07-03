using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample {

    private static void Main() {
        
        using(ServerManager serverManager = new ServerManager()) { 
            Configuration config = serverManager.GetApplicationHostConfiguration();
            
            ConfigurationSection dynamicIpSecuritySection = config.GetSection("system.webServer/security/dynamicIpSecurity", "Default Web Site");
            dynamicIpSecuritySection["denyAction"] = @"Forbidden";
            dynamicIpSecuritySection["enableProxyMode"] = true;
            dynamicIpSecuritySection["enableLoggingOnlyMode"] = true;
            
            ConfigurationElement denyByConcurrentRequestsElement = dynamicIpSecuritySection.GetChildElement("denyByConcurrentRequests");
            denyByConcurrentRequestsElement["enabled"] = true;
            denyByConcurrentRequestsElement["maxConcurrentRequests"] = 10;
            
            ConfigurationElement denyByRequestRateElement = dynamicIpSecuritySection.GetChildElement("denyByRequestRate");
            denyByRequestRateElement["enabled"] = true;
            denyByRequestRateElement["maxRequests"] = 10;
            denyByRequestRateElement["requestIntervalInMilliseconds"] = 10;
            
            serverManager.CommitChanges();
        }
    }
}