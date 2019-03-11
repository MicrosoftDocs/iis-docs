class CustomPage : ModulePropertiesPage { 
  private CustomModuleProxy _serviceProxy; 
  private PropertyBag _bag; 
  private PropertyBag _clone; 
  protected override bool CanApplyChanges { 
	get { 
	  return HasChanges; 
	} 
  } 

  protected override bool CanRefresh { 
	get { 
	  return true; 
	} 
  } 

  private CustomModuleProxy ServiceProxy { 
	get { 
	  if (_serviceProxy == null) { 
		_serviceProxy = 
		  (CustomModuleProxy)CreateProxy(typeof(CustomModuleProxy)); 
	  } 
	  return _serviceProxy; 
	} 
  } 

  protected override PropertyBag GetProperties() { 
  } 

  protected override void ProcessProperties(PropertyBag properties) { 
  } 

  protected override void OnException(Exception ex) { 
  } 

  protected override PropertyBag UpdateProperties(out bool updateSuccessful) { 
  } 
}