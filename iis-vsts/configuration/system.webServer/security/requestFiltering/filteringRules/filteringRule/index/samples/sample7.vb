Set adminManager = createObject("Microsoft.ApplicationHost.WritableAdminManager")
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site"
Set requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site")
Set filteringRulesCollection = requestFilteringSection.ChildElements.Item("filteringRules").Collection

Set filteringRuleElement = filteringRulesCollection.CreateNewElement("filteringRule")
filteringRuleElement.Properties.Item("name").Value = "Block Image Leeching"
filteringRuleElement.Properties.Item("scanUrl").Value = False
filteringRuleElement.Properties.Item("scanQueryString").Value = False
filteringRuleElement.Properties.Item("scanAllRaw").Value = False

Set scanHeadersCollection = filteringRuleElement.ChildElements.Item("scanHeaders").Collection
Set addElement = scanHeadersCollection.CreateNewElement("add")
addElement.Properties.Item("requestHeader").Value = "User-agent"
scanHeadersCollection.AddElement(addElement)

Set appliesToCollection = filteringRuleElement.ChildElements.Item("appliesTo").Collection
Set addElement1 = appliesToCollection.CreateNewElement("add")
addElement1.Properties.Item("fileExtension").Value = ".gif"
appliesToCollection.AddElement(addElement1)
Set addElement2 = appliesToCollection.CreateNewElement("add")
addElement2.Properties.Item("fileExtension").Value = ".jpg"
appliesToCollection.AddElement(addElement2)
Set addElement3 = appliesToCollection.CreateNewElement("add")
addElement3.Properties.Item("fileExtension").Value = ".png"
appliesToCollection.AddElement(addElement3)

Set denyStringsCollection = filteringRuleElement.ChildElements.Item("denyStrings").Collection
Set addElement4 = denyStringsCollection.CreateNewElement("add")
addElement4.Properties.Item("string").Value = "leech-bot"
denyStringsCollection.AddElement(addElement4)

filteringRulesCollection.AddElement(filteringRuleElement)
adminManager.CommitChanges()