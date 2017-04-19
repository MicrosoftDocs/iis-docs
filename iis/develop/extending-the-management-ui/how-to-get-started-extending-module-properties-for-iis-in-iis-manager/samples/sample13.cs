protected override PropertyBag UpdateProperties(out bool updateSuccessful) { 
  updateSuccessful = false; 
  try { 
	ServiceProxy.UpdateCustomSettings(_clone); 
	_bag = _clone; 
	updateSuccessful = true; 
  } 
  catch (Exception ex) { 
	OnException(ex); 
  } 
  return _bag; 
}