static void Main(string[] args) 
{
  // Initialize the server manager used to administer the sections 
  ServerManager serverManager = new ServerManager();

  // Get the applicationHost.config file 
  Configuration config = serverManager.GetApplicationHostConfiguration();

  // Get the custom configuration section from that file 
  ConfigurationSection section = config.GetSection("myCustomSection");

  // Output the default value of the booleanProperty 
  Console.WriteLine(section.GetAttributeValue("booleanProperty"));

  // Set the new value of the booleanProperty 
  section.SetAttributeValue("booleanProperty", true);

  // Update the config file with the changes that you have made 
  serverManager.CommitChanges();

}