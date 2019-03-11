class CustomPropertiesInfo : PropertyGridObject { 
  private PropertyBag _bag; 

  public CustomPropertiesInfo(ModulePropertiesPage page, PropertyBag bag) 
	: base(page) { 
	Initialize(bag); 
  } 

  [DefaultValue(false)] 
  public bool BooleanProperty { 
	get { 
	  object o = _bag[CustomGlobals.booleanProperty]; 
	  if (o == null) { 
		return false; 
	  } 
	  return (bool)o; 
	} 
	set { 
	  _bag[CustomGlobals.booleanProperty] = value; 
	} 
  } 

  public string StringProperty { 
	get { 
	  object o = _bag[CustomGlobals.stringProperty]; 
	  if (o == null) { 
		return String.Empty; 
	  } 
	  return (string)o; 
	} 
	set { 
	  _bag[CustomGlobals.stringProperty] = value; 
	} 
  } 

  [DefaultValue(100)] 
  public int IntegerProperty { 
	get { 
	  object o = _bag[CustomGlobals.integerProperty]; 
	  if (o == null) { 
		return 100; 
	  } 
	  return (int)o; 
	} 
	set { 
	  _bag[CustomGlobals.integerProperty] = value; 
	} 
  } 

  internal void Initialize(PropertyBag bag) { 
	_bag = bag; 
  } 
}