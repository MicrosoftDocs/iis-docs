var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");

var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "ftp.example.com"]);
if (siteElementPos == -1) throw "Element not found!";
var siteElement = sitesCollection.Item(siteElementPos);

var ftpServerElement = siteElement.ChildElements.Item("ftpServer");
var sessionsElement = ftpServerElement.ChildElements.Item("sessions").Collection;

WScript.Echo("Active Sessions: " + sessionsElement.Count);

for (var i = 0; i < sessionsElement.Count; i++) {
   var sessionElement = sessionsElement.Item(i);
   WScript.Echo("\tSession ID: " + sessionElement.GetPropertyByName("sessionId").Value);
   WScript.Echo("\t\tUser Name: " + sessionElement.GetPropertyByName("userName").Value);
   WScript.Echo("\t\tPrevious Command: " + sessionElement.GetPropertyByName("previousCommand").Value);
}

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