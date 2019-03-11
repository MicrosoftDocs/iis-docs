var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");

var sitesCollection = sitesSection.Collection;

var siteElementPos = FindElement(sitesCollection, "site", ["name", "MyFTPSite"]);
if (siteElementPos == -1) throw "Element not found!";
var siteElement = sitesCollection.Item(siteElementPos);

var ftpServerElement = siteElement.ChildElements.Item("ftpServer");
var securityElement = ftpServerElement.ChildElements.Item("security");
var customAuthorizationElement = securityElement.ChildElements.Item("customAuthorization");
var providerElement = customAuthorizationElement.ChildElements.Item("provider");
providerElement.Properties.Item("name").Value = "MyProvider";
providerElement.Properties.Item("enabled").Value = true;

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