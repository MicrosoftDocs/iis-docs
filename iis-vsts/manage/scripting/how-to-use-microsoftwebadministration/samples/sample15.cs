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
            Configuration config =
            mgr.GetWebConfiguration("Default Web Site");
            ConfigurationSection section = config.GetSection("system.webServer/defaultDocument");
            ConfigurationAttribute enabled = section.GetAttribute("enabled");
            enabled.Value = true;
            serverManager.CommitChanges();
        }
    }
}