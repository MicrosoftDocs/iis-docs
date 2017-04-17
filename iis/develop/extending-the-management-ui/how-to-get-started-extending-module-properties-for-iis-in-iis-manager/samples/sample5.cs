public class CustomModuleService : ModuleService { 
      [ModuleServiceMethod] 

      public PropertyBag GetCustomSettings() { 
        PropertyBag bag = new PropertyBag(); 
        ConfigurationSection section = 
          ManagementUnit.Configuration.GetSection("system.webServer/myCustomSection"); 
        bag[CustomGlobals.booleanProperty] = 
          section.GetAttributeValue("booleanProperty"); 
        bag[CustomGlobals.stringProperty] = 
          section.GetAttributeValue("stringProperty"); 
        bag[CustomGlobals.integerProperty] = 
          section.GetAttributeValue("integerProperty"); 
        return bag; 
      } 

      [ModuleServiceMethod] 
      public void UpdateCustomSettings(PropertyBag updatedSettings) { 
        if (updatedSettings == null) { 
          throw new ArgumentNullException("updatedSettings"); 
        } 
        ConfigurationSection section = 
          ManagementUnit.Configuration.GetSection("system.webServer/myCustomSection"); 

        foreach (int key in updatedSettings.ModifiedKeys) { 
          switch (key) { 
            case CustomGlobals.booleanProperty: 
              section.SetAttributeValue("booleanProperty", 
                updatedSettings[CustomGlobals.booleanProperty]); 
              break; 
            case CustomGlobals.stringProperty: 
              section.SetAttributeValue("stringProperty", 
                updatedSettings[CustomGlobals.stringProperty]); 
              break; 
            case CustomGlobals.integerProperty: 
              section.SetAttributeValue("integerProperty", 
                updatedSettings[CustomGlobals.integerProperty]); 
            break; 
          } 
        } 
        ManagementUnit.Update(); 
      } 
    }