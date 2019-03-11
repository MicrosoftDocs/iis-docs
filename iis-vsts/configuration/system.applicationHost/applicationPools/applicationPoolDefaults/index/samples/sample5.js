var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var applicationPoolsSection = adminManager.GetAdminSection("system.applicationHost/applicationPools", "MACHINE/WEBROOT/APPHOST");
var applicationPoolDefaultsElement = applicationPoolsSection.ChildElements.Item("applicationPoolDefaults");
applicationPoolDefaultsElement.Properties.Item("autoStart").Value = true;
applicationPoolDefaultsElement.Properties.Item("managedRuntimeVersion").Value = "v2.0";
applicationPoolDefaultsElement.Properties.Item("managedPipelineMode").Value = "Integrated";

adminManager.CommitChanges();