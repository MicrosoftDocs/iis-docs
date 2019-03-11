var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");

var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "Default Web Site"]);
if (siteElementPos == -1) throw "Element not found!";
var siteElement = sitesCollection.Item(siteElementPos);

var limitsElement = siteElement.ChildElements.Item("limits");
limitsElement.Properties.Item("maxBandwidth").Value = 65536;
limitsElement.Properties.Item("maxConnections").Value = 1024;
limitsElement.Properties.Item("connectionTimeout").Value = "00:01:00";

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