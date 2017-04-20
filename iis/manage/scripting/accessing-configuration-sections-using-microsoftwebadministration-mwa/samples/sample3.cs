static void Main(string[] args) {  
    ServerManager serverManager = new ServerManager();  
    Configuration config = serverManager.GetApplicationHostConfiguration();  
          ConfigurationSection section = config.GetSection("system.webServer/asp");  
          ConfigurationElement element = section.GetChildElement("session"); 
  Console.Write("allowSessionState attribute value: ");  
          Console.WriteLine(element.GetAttributeValue("allowSessionState"));  
          Console.WriteLine("Set allowSessionState value to false"); 
  element.SetAttributeValue("allowSessionState", false); 
  Console.Write("allowSessionState attribute value: ");  
          Console.WriteLine(element.GetAttributeValue("allowSessionState"));  
  serverManager.CommitChanges();  
    }