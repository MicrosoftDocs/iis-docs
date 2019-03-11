var adminManager = new ActiveXObject("Microsoft.ApplicationHost.WritableAdminManager"); 
adminManager.CommitPath = "MACHINE/WEBROOT"; 
adminManager.SetMetadata("pathMapper", "AdministrationConfig");

var authorizationSection = adminManager.GetAdminSection("system.webServer/management/authorization", "MACHINE/WEBROOT"); 
var authorizationRulesCollection = authorizationSection.ChildElements.Item("authorizationRules").Collection;

var scopeElementPos = FindElement(authorizationRulesCollection, "scope", ["path", "/Default Web Site"]);
if (scopeElementPos == -1)
{
   var scopeElement = authorizationRulesCollection.CreateNewElement("scope");
   scopeElement.Properties.Item("path").Value = "/Default Web Site";
   authorizationRulesCollection.AddElement(scopeElement);
}
else
{
   var scopeElement = authorizationRulesCollection.Item(scopeElementPos);
}

var scopeCollection = scopeElement.Collection;
var addElement = scopeCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "ContosoUser";
scopeCollection.AddElement(addElement);

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