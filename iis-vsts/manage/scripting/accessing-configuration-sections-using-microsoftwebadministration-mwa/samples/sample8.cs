public sealed class IsapiCgiRestrictionCollection : ConfigurationElementCollectionBase<IsapiCgiRestrictionElement> { 
   public IsapiCgiRestrictionCollection() {  
      } 
   public new IsapiCgiRestrictionElement this[string path] {  
        get { 
          for (int i = 0; i< Count; i++) { 
            IsapiCgiRestrictionElement restriction = base[i]; 
            if (String.Equals=(Environment.ExpandEnvironmentVariables(restriction.Path),  
              Environment.ExpandEnvironmentVariables(path), StringComparison.OrdinalIgnoreCase)) {  
              return restriction; 
            } 
          } 
        return null; 
      } 
    } 
    public IsapiCgiRestrictionElement Add(string path, bool allowed) { 
        IsapiCgiRestrictionElement element = CreateElement(); 
        element.Path = path; 
        element.Allowed = allowed; 
        return Add(element); 
    } 
    protected override IsapiCgiRestrictionElement CreateNewElement(string elementTagName) { 
        return new IsapiCgiRestrictionElement(); 
      } 
    } 
    public sealed class IsapiCgiRestrictionElement : ConfigurationElement { 
  public IsapiCgiRestrictionElement() { 
      } 
     public bool Allowed { 
      get { 
        return (bool)base["allowed"]; 
      } 
      set { 
        base["allowed"] = value; 
      } 
    }         
     public string Path { 
      get { 
        return (string)base["path"]; 
      } 
      set { 
        base["path"] = value; 
      } 
     } 
   }