using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetApplicationHostConfiguration();
         ConfigurationSection ipSecuritySection = config.GetSection("system.webServer/security/ipSecurity", "Default Web Site");
         ConfigurationElementCollection ipSecurityCollection = ipSecuritySection.GetCollection();

         ConfigurationElement addElement = ipSecurityCollection.CreateElement("add");
         addElement["ipAddress"] = @"192.168.100.1";
         addElement["allowed"] = false;
         ipSecurityCollection.Add(addElement);

         ConfigurationElement addElement1 = ipSecurityCollection.CreateElement("add");
         addElement1["ipAddress"] = @"169.254.0.0";
         addElement1["subnetMask"] = @"255.255.0.0";
         addElement1["allowed"] = false;
         ipSecurityCollection.Add(addElement1);

         serverManager.CommitChanges();
      }
   }
}