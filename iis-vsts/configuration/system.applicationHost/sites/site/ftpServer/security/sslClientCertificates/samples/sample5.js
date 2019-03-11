var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var sitesCollection = sitesSection.Collection;
var siteElementPos = FindElement(sitesCollection, "site", ["name", "ftp.example.com"]);

if (siteElementPos == -1) throw "Element not found!";

var siteElement = sitesCollection.Item(siteElementPos);
var ftpServerElement = siteElement.ChildElements.Item("ftpServer");
var securityElement = ftpServerElement.ChildElements.Item("security");

var sslElement = securityElement.ChildElements.Item("ssl");
sslElement.Properties.Item("serverCertHash").Value = "57686f6120447564652c2049495320526f636b73";
sslElement.Properties.Item("controlChannelPolicy").Value = "SslRequire";
sslElement.Properties.Item("dataChannelPolicy").Value = "SslRequire";

var sslClientCertificatesElement = securityElement.ChildElements.Item("sslClientCertificates");
sslClientCertificatesElement.Properties.Item("clientCertificatePolicy").Value = "CertRequire";
sslClientCertificatesElement.Properties.Item("useActiveDirectoryMapping").Value = false;

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