var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Contoso";

var directoryBrowseSection = adminManager.GetAdminSection("system.webServer/directoryBrowse",
   "MACHINE/WEBROOT/APPHOST/Contoso");
directoryBrowseSection.Properties.Item("enabled").Value = true;
directoryBrowseSection.Properties.Item("showFlags").Value = "Date, Time, Size, Extension";

adminManager.CommitChanges();