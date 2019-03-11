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

         ConfigurationSection windowsAuthenticationSection = config.GetSection("system.webServer/security/authentication/windowsAuthentication", "Default Web Site");
         windowsAuthenticationSection["enabled"] = true;

         ConfigurationElement extendedProtectionElement = windowsAuthenticationSection.GetChildElement("extendedProtection");
         extendedProtectionElement["tokenChecking"] = @"Allow";
         extendedProtectionElement["flags"] = @"None";

         ConfigurationElementCollection extendedProtectionCollection = extendedProtectionElement.GetCollection();

         ConfigurationElement spnElement = extendedProtectionCollection.CreateElement("spn");
         spnElement["name"] = @"HTTP/www.contoso.com";
         extendedProtectionCollection.Add(spnElement);

         ConfigurationElement spnElement1 = extendedProtectionCollection.CreateElement("spn");
         spnElement1["name"] = @"HTTP/contoso.com";
         extendedProtectionCollection.Add(spnElement1);

         serverManager.CommitChanges();
      }
   }
}