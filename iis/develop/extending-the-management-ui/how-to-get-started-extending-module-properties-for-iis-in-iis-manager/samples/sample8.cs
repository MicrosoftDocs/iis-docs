class CustomModuleProxy : ModuleServiceProxy { 
  public CustomModuleProxy() { 
  } 

  public PropertyBag GetCustomSettings() { 
	return (PropertyBag)Invoke("GetCustomSettings"); 
  } 

  public void UpdateCustomSettings(PropertyBag updatedSettings) { 
	Invoke("UpdateCustomSettings", updatedSettings); 
  } 
}