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
            Site site = serverManager.Sites["Racing Cars Site"];
            site.Name = "Racing Site";
            site.Applications[0].VirtualDirectories[0].PhysicalPath = "d:\\racing";
            serverManager.ApplicationPools.Add("RacingApplicationPool");
            serverManager.Sites["Racing Site"].Applications[0].ApplicationPoolName = "RacingApplicationPool";
            ApplicationPool apppool = serverManager.ApplicationPools["RacingApplicationPool"];
            apppool.ManagedPipelineMode = ManagedPipelineMode.ISAPI;
            serverManager.CommitChanges();
			apppool.Recycle();
        }
    }
}