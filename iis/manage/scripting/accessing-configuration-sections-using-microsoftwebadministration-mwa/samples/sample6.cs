static void Main(string[] args) { 
      ServerManager serverManager = new ServerManager(); 
      Configuration config = serverManager.GetApplicationHostConfiguration(); 
      AspSection section = (AspSection)config.GetSection("system.webServer/asp", 
        typeof(AspSection)); 
      Console.WriteLine(section.Session.AllowSessionState); 
      section.Session.AllowSessionState = false; 
      serverManager.CommitChanges(); 
    }