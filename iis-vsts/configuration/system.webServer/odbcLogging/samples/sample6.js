var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var odbcLoggingSection = adminManager.GetAdminSection("system.webServer/odbcLogging", "MACHINE/WEBROOT/APPHOST/Default Web Site");
odbcLoggingSection.Properties.Item("dataSource").Value = "InternetDb";
odbcLoggingSection.Properties.Item("tableName").Value = "InternetLog";
odbcLoggingSection.Properties.Item("userName").Value = "InternetAdmin";
odbcLoggingSection.Properties.Item("password").Value = "P@ssw0rd";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "Default Web Site"]);
if (siteElementPos == -1) throw "Element not found!";
var siteElement = sitesCollection.Item(siteElementPos);

var logFileElement = siteElement.ChildElements.Item("logFile");
logFileElement.Properties.Item("customLogPluginClsid").Value = "{FF16065B-DE82-11CF-BC0A-00AA006111E0}";
logFileElement.Properties.Item("logFormat").Value = "Custom";

adminManager.CommitChanges();

function FindElement(collection, elementTagName, valuesToMatch) {
   for (var i = 0; i < collection.Count; i++) {
      var element = collection.Item(i);
      if (element.Name == elementTagName) {
         var matches = true;
         for (var iVal = 0; iVal < valuesToMatch.length; iVal += 2) {
            var property = element.GetPropertyByName(valuesToMatch[iVal]);
            var value = property.Value;
            if (value != null) {
               value = value.toString();
            }
            if (value != valuesToMatch[iVal + 1]) {
               matches = false;
               break;
            }
         }
         if (matches) {
            return i;
         }
      }
   }
   return -1;
}