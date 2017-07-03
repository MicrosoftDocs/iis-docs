var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var windowsAuthenticationSection = adminManager.GetAdminSection("system.webServer/security/authentication/windowsAuthentication", "MACHINE/WEBROOT/APPHOST/Contoso");
windowsAuthenticationSection.Properties.Item("enabled").Value = true;

var providersCollection = windowsAuthenticationSection.ChildElements.Item("providers").Collection;
var addElementPos = FindElement(providersCollection, "add", ["value", "Negotiate"]);
if (addElementPos == -1) throw "Element not found!";
providersCollection.DeleteElement(addElementPos);

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