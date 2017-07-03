var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");

var denyQueryStringSequencesCollection = requestFilteringSection.ChildElements.Item("denyQueryStringSequences").Collection;
var addElement = denyQueryStringSequencesCollection.CreateNewElement("add");
addElement.Properties.Item("sequence").Value = "bad_querystring_sequence";
denyQueryStringSequencesCollection.AddElement(addElement);

adminManager.CommitChanges();