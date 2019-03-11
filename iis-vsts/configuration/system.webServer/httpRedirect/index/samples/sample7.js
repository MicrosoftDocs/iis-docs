var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";

var httpRedirectSection = adminManager.GetAdminSection("system.webServer/httpRedirect", "MACHINE/WEBROOT/APPHOST/Default Web Site");
httpRedirectSection.Properties.Item("enabled").Value = true;
httpRedirectSection.Properties.Item("destination").Value = "http://www.contoso.com";
httpRedirectSection.Properties.Item("exactDestination").Value = false;
httpRedirectSection.Properties.Item("httpResponseStatus").Value = "Found";

adminManager.CommitChanges();