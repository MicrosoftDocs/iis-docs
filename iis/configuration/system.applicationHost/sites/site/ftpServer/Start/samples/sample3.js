// Create a Writable Admin Manager object.
var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

// Retrieve the sites collection.
var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites","MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;

// Locate a specific site.
var siteElementPos = FindElement(sitesCollection,"site",["name","MySite"]);
if (siteElementPos == -1) throw "Element not found!";

// Retrieve the site element.
var siteElement = sitesCollection.Item(siteElementPos);
// Create an object for the ftpServer element.
var ftpServerElement = siteElement.ChildElements.Item("ftpServer");
// Create an instance of the start method.
var Start = ftpServerElement.Methods.Item("Start").CreateInstance();
// Execute the method to start the FTP site.
Start.Execute();

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