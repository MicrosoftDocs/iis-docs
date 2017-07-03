var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

var securityElement = ftpServerElement.ChildElements.Item("security");
var commandFilteringElement = securityElement.ChildElements.Item("commandFiltering");
var commandFilteringCollection = commandFilteringElement.Collection;
var addElement = commandFilteringCollection.CreateNewElement("add");
   addElement.Properties.Item("command").Value = "SYST";
   addElement.Properties.Item("allowed").Value = false;
   commandFilteringCollection.AddElement(addElement);
var sslElement = securityElement.ChildElements.Item("ssl");
   sslElement.Properties.Item("controlChannelPolicy").Value = "SslAllow";
   sslElement.Properties.Item("dataChannelPolicy").Value = "SslAllow";
   sslElement.Properties.Item("serverCertHash").Value = "57686f6120447564652c2049495320526f636b73";
var authenticationElement = securityElement.ChildElements.Item("authentication");
var anonymousAuthenticationElement = authenticationElement.ChildElements.Item("anonymousAuthentication");
   anonymousAuthenticationElement.Properties.Item("enabled").Value = false;
var basicAuthenticationElement = authenticationElement.ChildElements.Item("basicAuthentication");
   basicAuthenticationElement.Properties.Item("enabled").Value = false;
var clientCertAuthenticationElement = authenticationElement.ChildElements.Item("clientCertAuthentication");
   clientCertAuthenticationElement.Properties.Item("enabled").Value = false;
var sslClientCertificatesElement = securityElement.ChildElements.Item("sslClientCertificates");
    sslClientCertificatesElement.Properties.Item("clientCertificatePolicy").Value = "CertIgnore";
var customAuthenticationElement = authenticationElement.ChildElements.Item("customAuthentication");
var providersCollection = customAuthenticationElement.ChildElements.Item("providers").Collection;
var addElement1 = providersCollection.CreateNewElement("add");
   addElement1.Properties.Item("name").Value = "FtpCustomAuthenticationModule";
   addElement1.Properties.Item("enabled").Value = false;
   providersCollection.AddElement(addElement1);

adminManager.CommitChanges();