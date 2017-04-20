using System;
using Microsoft.Web.Administration;
public class setASPNETCompilationDirectory
{
   static void Main()
   {
      ServerManager manager = new ServerManager();
      Configuration rootConfig = manager.GetWebConfiguration(new WebConfigurationMap(), null);
      ConfigurationSection section = rootConfig.GetSection("system.web/compilation");
      section.Attributes["tempDirectory"].Value = @"e:\inetpub\temp\temporary asp.net files\site1";
      section.SetMetadata("lockAttributes", "tempDirectory");
      manager.CommitChanges();
   }
}