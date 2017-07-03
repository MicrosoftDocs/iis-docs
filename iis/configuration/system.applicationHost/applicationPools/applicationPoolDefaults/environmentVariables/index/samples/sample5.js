var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST");
var applicationPoolsCollection = applicationPoolsSection.Collection;
var addElementPos = FindElement(applicationPoolsCollection, "add", ["name", "Contoso"]);
if (addElementPos == -1) throw "Element not found!";

var addElement = applicationPoolsCollection.Item(addElementPos);
var environmentVariablesCollection = addElement.ChildElements.Item("environmentVariables").Collection;

var addElement1 = environmentVariablesCollection.CreateNewElement("add");
addElement1.Properties.Item("name").Value = "foo";
addElement1.Properties.Item("value").Value = "bar";
environmentVariablesCollection.AddElement(addElement1);

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