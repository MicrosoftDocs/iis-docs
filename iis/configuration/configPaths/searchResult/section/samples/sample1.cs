using System;
using System.Text;
using Microsoft.Web.Administration;

internal static class Sample
{
   private static void Main()
   {
      using (ServerManager serverManager = new ServerManager())
      {
         Configuration config = serverManager.GetWebConfiguration("Default Web Site");
         ConfigurationSection configPathsSection = config.GetSection("configPaths");
         ConfigurationElementCollection searchResultCollection = configPathsSection.GetCollection();

         foreach (ConfigurationElement searchResultElement in searchResultCollection)
         {
            string path = (string)searchResultElement["path"];
            string locationPath = (string)searchResultElement["locationPath"];

            foreach (ConfigurationElement sectionElement in searchResultElement.GetCollection())
            {
               if (string.Compare("system.webServer/defaultDocument",
                  (string)sectionElement["name"], false) == 0)
               {
                  Console.WriteLine("Path: " + path);
                  if (!String.IsNullOrEmpty(locationPath))
                  {
                     Console.WriteLine("\tLocation: " + locationPath);
                     Console.WriteLine("\t\tName: " + sectionElement["name"]);
                  }
                  else Console.WriteLine("\tName: " + sectionElement["name"]);
               }
            }
         } 
      }
   }
}