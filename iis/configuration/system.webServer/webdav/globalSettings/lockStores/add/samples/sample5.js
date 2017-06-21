var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";

var globalSettingsSection = adminManager.GetAdminSection("system.webServer/webdav/globalSettings", "MACHINE/WEBROOT/APPHOST");

var propertyStoresCollection = globalSettingsSection.ChildElements.Item("propertyStores").Collection;

var addElement = propertyStoresCollection.CreateNewElement("add");
addElement.Properties.Item("name").Value = "webdav_simple_prop";
addElement.Properties.Item("image").Value = "%windir%\\system32\\inetsrv\\webdav_simple_prop.dll";
propertyStoresCollection.AddElement(addElement);

var lockStoresCollection = globalSettingsSection.ChildElements.Item("lockStores").Collection;

var addElement1 = lockStoresCollection.CreateNewElement("add");
addElement1.Properties.Item("name").Value = "webdav_simple_lock";
addElement1.Properties.Item("image").Value = "%windir%\\system32\\inetsrv\\webdav_simple_lock.dll";
lockStoresCollection.AddElement(addElement1);

adminManager.CommitChanges();