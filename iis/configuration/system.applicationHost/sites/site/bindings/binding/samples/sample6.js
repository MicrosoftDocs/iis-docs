var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "Contoso"]);

if (siteElementPos == -1) throw "Element not found!";

var siteElement = sitesCollection.Item(siteElementPos);
var bindingsCollection = siteElement.ChildElements.Item("bindings").Collection;

var bindingElement = bindingsCollection.CreateNewElement("binding");
bindingElement.Properties.Item("protocol").Value = "http";
bindingElement.Properties.Item("bindingInformation").Value = "192.168.0.1:80:www.contoso.com";
bindingsCollection.AddElement(bindingElement);

var bindingElement1 = bindingsCollection.CreateNewElement("binding");
bindingElement1.Properties.Item("protocol").Value = "https";
bindingElement1.Properties.Item("bindingInformation").Value = "*:443:";
bindingsCollection.AddElement(bindingElement1);

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