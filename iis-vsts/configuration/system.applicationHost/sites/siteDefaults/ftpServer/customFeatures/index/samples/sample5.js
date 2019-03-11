var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var sitesSection = adminManager.GetAdminSection("system.applicationHost/sites", "MACHINE/WEBROOT/APPHOST");
var siteDefaultsElement = sitesSection.ChildElements.Item("siteDefaults");
var ftpServerElement = siteDefaultsElement.ChildElements.Item("ftpServer");

// Configure FTP sites to start automatically by default.
ftpServerElement.Properties.Item("serverAutoStart").Value = true;

// Configure the default control channel time-out for 300 seconds.
var connectionsElement = ftpServerElement.ChildElements.Item("connections");
   connectionsElement.Properties.Item("controlChannelTimeout").Value = 300;

// Configure the default FTP security options.
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

// Configure a custom default banner message and local detailed error messages.
var messagesElement = ftpServerElement.ChildElements.Item("messages");
   messagesElement.Properties.Item("bannerMessage").Value = "Welcome!";
   messagesElement.Properties.Item("allowLocalDetailedErrors").Value = true;

// Configure the FTP service to keep partially-uploaded files by default.
var fileHandlingElement = ftpServerElement.ChildElements.Item("fileHandling");
   fileHandlingElement.Properties.Item("keepPartialUploads").Value = false;

// Configure the default external IP address of a firewall.
var firewallSupportElement = ftpServerElement.ChildElements.Item("firewallSupport");
   firewallSupportElement.Properties.Item("externalIp4Address").Value = "169.254.10.10";

// Specify no user isolation by default.
var userIsolationElement = ftpServerElement.ChildElements.Item("userIsolation");
   userIsolationElement.Properties.Item("mode").Value = "None";

// Configure UNIX-style directory listings by default and display the available drive space.
var directoryBrowseElement = ftpServerElement.ChildElements.Item("directoryBrowse");
   directoryBrowseElement.Properties.Item("showFlags").Value = "StyleUnix, DisplayAvailableBytes";

// Enable logging by default with daily log file rollover.
var logFileElement = ftpServerElement.ChildElements.Item("logFile");
   logFileElement.Properties.Item("period").Value = "Daily";
   logFileElement.Properties.Item("enabled").Value = true;

adminManager.CommitChanges();