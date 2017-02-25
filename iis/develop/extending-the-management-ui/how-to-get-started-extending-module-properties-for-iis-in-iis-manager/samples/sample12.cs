protected override void ProcessProperties(PropertyBag properties) { 
      _bag = properties; 
      _clone = _bag.Clone(); 

      CustomPropertiesInfo info = (CustomPropertiesInfo)TargetObject; 
      if (info == null) { 
        info = new CustomPropertiesInfo(this, _clone); 
        TargetObject = info; 
      } 
      else { 
        info.Initialize(_clone); 
      } 
      ClearDirty(); 
    }