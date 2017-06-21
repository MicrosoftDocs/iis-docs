var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST";
var requestFilteringSection = adminManager.GetAdminSection("system.ftpServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var denyUrlSequencesCollection = requestFilteringSection.ChildElements.Item("denyUrlSequences").Collection;

var addElement = denyUrlSequencesCollection.CreateNewElement("add");
addElement.Properties.Item("sequence").Value = "bin";
denyUrlSequencesCollection.AddElement(addElement);

adminManager.CommitChanges();