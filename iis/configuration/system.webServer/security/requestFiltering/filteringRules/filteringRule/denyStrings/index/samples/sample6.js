adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/Default Web Site";
var requestFilteringSection = adminManager.GetAdminSection("system.webServer/security/requestFiltering", "MACHINE/WEBROOT/APPHOST/Default Web Site");
var filteringRulesCollection = requestFilteringSection.ChildElements.Item("filteringRules").Collection;

var filteringRuleElement = filteringRulesCollection.CreateNewElement("filteringRule");
filteringRuleElement.Properties.Item("name").Value = "Block Image Leeching";
filteringRuleElement.Properties.Item("scanUrl").Value = false;
filteringRuleElement.Properties.Item("scanQueryString").Value = false;
filteringRuleElement.Properties.Item("scanAllRaw").Value = false;

var scanHeadersCollection = filteringRuleElement.ChildElements.Item("scanHeaders").Collection;
var addElement = scanHeadersCollection.CreateNewElement("add");
addElement.Properties.Item("requestHeader").Value = "User-agent";
scanHeadersCollection.AddElement(addElement);

var appliesToCollection = filteringRuleElement.ChildElements.Item("appliesTo").Collection;
var addElement1 = appliesToCollection.CreateNewElement("add");
addElement1.Properties.Item("fileExtension").Value = ".gif";
appliesToCollection.AddElement(addElement1);
var addElement2 = appliesToCollection.CreateNewElement("add");
addElement2.Properties.Item("fileExtension").Value = ".jpg";
appliesToCollection.AddElement(addElement2);
var addElement3 = appliesToCollection.CreateNewElement("add");
addElement3.Properties.Item("fileExtension").Value = ".png";
appliesToCollection.AddElement(addElement3);

var denyStringsCollection = filteringRuleElement.ChildElements.Item("denyStrings").Collection;
var addElement4 = denyStringsCollection.CreateNewElement("add");
addElement4.Properties.Item("string").Value = "leech-bot";
denyStringsCollection.AddElement(addElement4);

filteringRulesCollection.AddElement(filteringRuleElement);
adminManager.CommitChanges();