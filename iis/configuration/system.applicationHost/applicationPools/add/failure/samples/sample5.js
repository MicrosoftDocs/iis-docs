var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST");

var applicationPoolsCollection = applicationPoolsSection.Collection;

var addElementPos = FindElement(applicationPoolsCollection, "add", ["name", "DefaultAppPool"]);
if (addElementPos == -1) throw "Element not found!";
var addElement = applicationPoolsCollection.Item(addElementPos);

var failureElement = addElement.ChildElements.Item("failure");
failureElement.Properties.Item("rapidFailProtection").Value = true;
failureElement.Properties.Item("rapidFailProtectionInterval").Value = "00:05:00";
failureElement.Properties.Item("rapidFailProtectionMaxCrashes").Value = 5;

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