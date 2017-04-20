using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Administration;

namespace MSWebAdmin_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerManager serverManager = new ServerManager();
            Configuration config = serverManager.GetApplicationHostConfiguration();
            ConfigurationSection section = config.GetSection("system.webServer/defaultDocument","Default Web Site");
            ConfigurationAttribute enabled = section.GetAttribute("enabled");
            enabled.Value = false;
            serverManager.CommitChanges();
        }
    }
}