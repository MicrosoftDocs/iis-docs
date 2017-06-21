Imports System
Imports System.Text
Imports Microsoft.Web.Administration


Module Sample
   Sub Main()
      Dim serverManager As ServerManager = New ServerManager
      Dim config As Configuration = serverManager.GetWebConfiguration("Default Web Site")
      Dim requestFilteringSection As ConfigurationSection = config.GetSection("system.webServer/security/requestFiltering")
      Dim filteringRulesCollection As ConfigurationElementCollection = requestFilteringSection.GetCollection("filteringRules")

      Dim filteringRuleElement As ConfigurationElement = filteringRulesCollection.CreateElement("filteringRule")
      filteringRuleElement("name") = "Block Image Leeching"
      filteringRuleElement("scanUrl") = False
      filteringRuleElement("scanQueryString") = False
      filteringRuleElement("scanAllRaw") = False

      Dim scanHeadersCollection As ConfigurationElementCollection = filteringRuleElement.GetCollection("scanHeaders")
      Dim addElement As ConfigurationElement = scanHeadersCollection.CreateElement("add")
      addElement("requestHeader") = "User-agent"
      scanHeadersCollection.Add(addElement)

      Dim appliesToCollection As ConfigurationElementCollection = filteringRuleElement.GetCollection("appliesTo")
      Dim addElement1 As ConfigurationElement = appliesToCollection.CreateElement("add")
      addElement1("fileExtension") = ".gif"
      appliesToCollection.Add(addElement1)
      Dim addElement2 As ConfigurationElement = appliesToCollection.CreateElement("add")
      addElement2("fileExtension") = ".jpg"
      appliesToCollection.Add(addElement2)
      Dim addElement3 As ConfigurationElement = appliesToCollection.CreateElement("add")
      addElement3("fileExtension") = ".png"
      appliesToCollection.Add(addElement3)

      Dim denyStringsCollection As ConfigurationElementCollection = filteringRuleElement.GetCollection("denyStrings")
      Dim addElement4 As ConfigurationElement = denyStringsCollection.CreateElement("add")
      addElement4("string") = "leech-bot"
      denyStringsCollection.Add(addElement4)

      filteringRulesCollection.Add(filteringRuleElement)
      serverManager.CommitChanges()
   End Sub
End Module