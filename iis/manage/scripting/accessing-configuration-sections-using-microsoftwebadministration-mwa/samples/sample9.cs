static void Main(string[] args) { 
  ServerManager serverManager = new ServerManager();             
  Configuration config = serverManager.GetApplicationHostConfiguration(); 
  IsapiCgiRestrictionSection section =  
	(IsapiCgiRestrictionSection)config.GetSection("system.webServer/security/isapiCgiRestriction", typeof(IsapiCgiRestrictionSection));
  // Iterating through the elements in the collection 
  foreach (IsapiCgiRestrictionElement element in section.IsapiCgiRestrictions) { 
	Console.Write("Path: " + element.Path); 
	Console.WriteLine(" Allowed: " + element.Allowed); 
  } 
  // Adding a new element to the collection 
  section.IsapiCgiRestrictions.Add(@"%SystemDir%\someDll.dll", false); 
  serverManager.CommitChanges(); 
}