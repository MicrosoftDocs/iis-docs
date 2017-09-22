
var adminManager = new ActiveXObject('Microsoft.ApplicationHost.WritableAdminManager');
adminManager.CommitPath = "MACHINE/WEBROOT/APPHOST/contentSite";

var corsSection = adminManager.GetAdminSection("system.webServer/cors", "MACHINE/WEBROOT/APPHOST/contentSite");
corsSection.Properties.Item("enabled").Value = true;
corsSection.Properties.Item("failUnlistedOrigins").Value = true;

var corsCollection = corsSection.Collection;

var addElement = corsCollection.CreateNewElement("add");
addElement.Properties.Item("origin").Value = "*";
corsCollection.AddElement(addElement);


var addElement1 = corsCollection.CreateNewElement("add");
addElement1.Properties.Item("origin").Value = "https://*.microsoft.com";
addElement1.Properties.Item("allowCredentials").Value = true;
addElement1.Properties.Item("maxAge").Value = 120;
var allowHeadersElement = addElement1.ChildElements.Item("allowHeaders");
allowHeadersElement.Properties.Item("allowAllRequestedHeaders").Value = true;

var allowHeadersCollection = allowHeadersElement.Collection;

var addElement2 = allowHeadersCollection.CreateNewElement("add");
addElement2.Properties.Item("header").Value = "header1";
allowHeadersCollection.AddElement(addElement2);


var addElement3 = allowHeadersCollection.CreateNewElement("add");
addElement3.Properties.Item("header").Value = "header2";
allowHeadersCollection.AddElement(addElement3);


var allowMethodsCollection = addElement1.ChildElements.Item("allowMethods").Collection;

var addElement4 = allowMethodsCollection.CreateNewElement("add");
addElement4.Properties.Item("method").Value = "DELETE";
allowMethodsCollection.AddElement(addElement4);


var exposeHeadersCollection = addElement1.ChildElements.Item("exposeHeaders").Collection;

var addElement5 = exposeHeadersCollection.CreateNewElement("add");
addElement5.Properties.Item("header").Value = "header1";
exposeHeadersCollection.AddElement(addElement5);


var addElement6 = exposeHeadersCollection.CreateNewElement("add");
addElement6.Properties.Item("header").Value = "header2";
exposeHeadersCollection.AddElement(addElement6);

corsCollection.AddElement(addElement1);


var addElement7 = corsCollection.CreateNewElement("add");
addElement7.Properties.Item("origin").Value = "http://*";
addElement7.Properties.Item("allowed").Value = false;
corsCollection.AddElement(addElement7);


adminManager.CommitChanges();
