using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.Web.Farm;
namespace WebFarmSample
{
    class Program
    {
        static void CreateWebFarm()
        {
            //WebFarmManager is the class that manages several web farms.
            WebFarmManager webFarmManager = new WebFarmManager();

            //Create a new WebFarm
            WebFarm myWebFarm = webFarmManager.WebFarms.CreateNewWebFarm("MyWebFarm");

            //Provide user name and password for the webfarm. Note that these credentials are
            //used for sync up and load balancing the farm. All the servers in the farms should
            //recognize the credentials.
            myWebFarm.AdminUserName = "Administrator";
            myWebFarm.AdminPassword = "MyPwd";

            //Optionally you can also specify how many number of servers must be online
            //at any given point of time and also how many servers could be stopped at any
            //given point of time.

            //myWebFarm.MinimumServers = 1;
            //myWebFarm.MaximumStoppedServers = 2;

            //This will enable the agent service automatically on the servers
            myWebFarm.AutoEnableAgent = true;

            //Now add a new server to the web farm
            Server srv1 = myWebFarm.Servers.CreateNewServer("MyServer1");

            //Make MyServer1 as Primary server. During the provisioning of application or platform
            //Primary server is used as the primary server from which the application or platforms
            //are provisioned.
            myWebFarm.PrimaryServer = srv1;

            //Add more servers. MyServer2 and MyServer3 acts as secondary servers
            //These two servers gets provisioned before loadbalancing.
            Server srv2 = myWebFarm.Servers.CreateNewServer("MyServer2");
            Server srv3 = myWebFarm.Servers.CreateNewServer("MyServer3");

            //The changes will take effect only after committing the changes.
            //This is a MUST call.
            webFarmManager.CommitChanges();
        }

        static void DeleteWebFarm()
        {
            //WebFarmManager is the class that manages several web farms.
            WebFarmManager webFarmManager = new WebFarmManager();

            //This will delete a web farm and all the connections to
            //the servers in the farm.
            webFarmManager.WebFarms.RemoveWebFarm("MyWebFarm");

            //The changes will take effect only after committing the changes.
            //This is a MUST call.
            webFarmManager.CommitChanges();
        }

        static void Main(string[] args)
        {
            //Create a web farm
            CreateWebFarm();

            //Wait till the users input.
            Console.WriteLine("Watch webfarm being created using your IIS Manager (inetmgr.exe)...");

            string answer = "N";
            Console.WriteLine("Delete Web Farm[Y/N]:");
            while(string.Equals(answer, "N", StringComparison.OrdinalIgnoreCase))
            {
                answer = Console.Read().ToString();
                Thread.Sleep(1000);
            }

            DeleteWebFarm();
        }
    }
}