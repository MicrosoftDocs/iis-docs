Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")

Set denyQueryStringSequencesCollection = requestFilteringSection.ChildElements.Item("denyQueryStringSequences").Collection
Set addElement = denyQueryStringSequencesCollection.CreateNewElement("add")
addElement.Properties.Item("sequence").Value = "bad_querystring_sequence"
denyQueryStringSequencesCollection.AddElement(addElement)

adminManager.CommitChanges()