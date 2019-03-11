var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager");
var configPathsSection = adminManager.GetAdminSection("configPaths", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var searchResultCollection = configPathsSection.Collection;

for (var i = 0; i < searchResultCollection.Count; i++)
{
   var searchResultElement = searchResultCollection.Item(i);
   var path = searchResultElement.GetPropertyByName("path").Value;
   var locationPath = searchResultElement.GetPropertyByName("locationPath").Value;

   sectionElementCollection = searchResultElement.Collection;
   for (var j = 0; j < sectionElementCollection.Count; j++)
   {
      var sectionElement = sectionElementCollection.Item(j);
      var name = sectionElement.GetPropertyByName("name").Value;
      if (name == "system.webServer/defaultDocument")
      {
         WScript.Echo("Path: " + path);
         if (locationPath!="")
         {
            WScript.Echo("\tLocation: " + locationPath);
            WScript.Echo("\t\tName: " + name);
         }
         else WScript.Echo("\tName: " + name);
      }
   }
}