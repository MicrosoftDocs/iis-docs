static void Main(string[] args) {         
          ServerManager serverManager = new ServerManager();     
  Configuration config = serverManager.GetApplicationHostConfiguration();         
ConfigurationSection section = 
      config.GetSection("system.webServer/security/isapiCgiRestriction");
    ConfigurationElementCollection collection = section.GetCollection(); 

      // Iterating through the elements in the collection foreach (ConfigurationElement element in collection) 
 { 
  Console.Write("Path: " + element.GetAttributeValue("path")); 
Console.WriteLine(" Allowed: " + element.GetAttributeValue("allowed")); 
        } 
       // Adding a new element to the collection        ConfigurationElement newElement = collection.CreateElement(); 
      newElement.SetAttributeValue("path", @"%SystemDir%\someDll.dll"); 
      newElement.SetAttributeValue("allowed", false); 
      collection.Add(newElement); 
      serverManager.CommitChanges();             
    }