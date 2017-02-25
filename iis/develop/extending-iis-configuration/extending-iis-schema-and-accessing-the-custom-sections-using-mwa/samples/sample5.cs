static void Main(string[] args) {
        ServerManager serverManager = new ServerManager();
        Configuration config = serverManager.GetApplicationHostConfiguration();
        ConfigurationSection section = config.GetSection("myCustomSection");
        Console.WriteLine(section.GetAttributeValue("booleanProperty"));
        Console.WriteLine(section.GetAttributeValue("stringProperty"));
        Console.WriteLine(section.GetAttributeValue("integerProperty"));
        Console.WriteLine(section.GetAttributeValue("enumProperty"));
        section.SetAttributeValue("booleanProperty", true);
        section.SetAttributeValue("stringProperty", "customString");
        section.SetAttributeValue("integerProperty", 300);
        section.SetAttributeValue("enumProperty", "EnumValue2");
        serverManager.CommitChanges();
      }