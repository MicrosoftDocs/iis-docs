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
         ConfigurationSection httpErrorsSection = config.GetSection("system.webServer/httpErrors");
         ConfigurationElementCollection httpErrorsCollection = httpErrorsSection.GetCollection();

         ConfigurationElement errorElement = httpErrorsCollection.CreateElement("error");
         errorElement["statusCode"] = 404;
         errorElement["subStatusCode"] = 5;
         errorElement["prefixLanguageFilePath"] = @"%SystemDrive%\inetpub\custerr";
         errorElement["path"] = @"404.5.htm";
         httpErrorsCollection.Add(errorElement);

         serverManager.CommitChanges();
      }
   }
}