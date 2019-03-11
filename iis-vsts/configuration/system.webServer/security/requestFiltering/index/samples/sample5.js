var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var denyUrlSequencesCollection = requestFilteringSection.ChildElements.Item("denyUrlSequences").Collection;

var addElement = denyUrlSequencesCollection.CreateNewElement("add");
addElement.Properties.Item("sequence").Value = "..";
denyUrlSequencesCollection.AddElement(addElement);

var addElement1 = denyUrlSequencesCollection.CreateNewElement("add");
addElement1.Properties.Item("sequence").Value = ":";
denyUrlSequencesCollection.AddElement(addElement1);

var addElement2 = denyUrlSequencesCollection.CreateNewElement("add");
addElement2.Properties.Item("sequence").Value = "\\";
denyUrlSequencesCollection.AddElement(addElement2);

adminManager.CommitChanges();