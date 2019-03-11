var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "Contoso"]);

if (siteElementPos == -1) throw "Element not found!";

var siteElement = sitesCollection.Item(siteElementPos);
var siteCollection = siteElement.Collection;
var applicationElement = siteCollection.CreateNewElement("application");
applicationElement.Properties.Item("path").Value = "/ShoppingCart";
var applicationCollection = applicationElement.Collection;
var virtualDirectoryElement = applicationCollection.CreateNewElement("virtualDirectory");
virtualDirectoryElement.Properties.Item("path").Value = "/";
virtualDirectoryElement.Properties.Item("physicalPath").Value = "C:\\Inetpub\\Contoso\\ShoppingCart";
applicationCollection.AddElement(virtualDirectoryElement);
siteCollection.AddElement(applicationElement);

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