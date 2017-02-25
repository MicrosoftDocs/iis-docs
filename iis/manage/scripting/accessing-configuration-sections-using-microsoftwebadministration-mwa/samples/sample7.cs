public sealed class IsapiCgiRestrictionSection : ConfigurationSection {  
    private IsapiCgiRestrictionCollection _collection;             
    public IsapiCgiRestrictionSection() { 
      }         
    public IsapiCgiRestrictionCollection IsapiCgiRestrictions { 
        get { 
          if (_collection == null) { 
            _collection = 
              (IsapiCgiRestrictionCollection)GetCollection(typeof(IsapiCgiRestrictionCollection)); 
          } 
        return _collection; 
        } 
      } 
    }