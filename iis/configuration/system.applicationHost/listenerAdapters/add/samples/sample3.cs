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
         ConfigurationSection listenerAdaptersSection = config.GetSection("system.applicationHost/listenerAdapters");
         ConfigurationElementCollection listenerAdaptersCollection = listenerAdaptersSection.GetCollection();

         ConfigurationElement addElement = listenerAdaptersCollection.CreateElement("add");
         addElement["name"] = @"gopher";
         addElement["protocolManagerDll"] = @"%SystemRoot%\system32\inetsrv\gophersvc.dll";
         addElement["protocolManagerDllInitFunction"] = @"GopherInit";
         listenerAdaptersCollection.Add(addElement);

         serverManager.CommitChanges();
      }
   }
}