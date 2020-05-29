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
            Site mySite = serverManager.Sites.Add("Racing Cars Site", "d:\\inetpub\\wwwroot\\racing",  8080);
            mySite.ServerAutoStart = true;
            serverManager.CommitChanges();
         }
    }
}
