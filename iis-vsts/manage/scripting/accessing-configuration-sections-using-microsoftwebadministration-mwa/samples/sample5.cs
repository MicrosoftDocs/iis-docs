public sealed class AspSection : ConfigurationSection { 
   private AspSession _session; 
    public AspSection() 
    { 
    } 

    public AspSession Session 
    {          
        get 
    { 
        if (_session == null) 
         {             
              _session = (AspSession)GetChildElement("session", 
typeof(AspSession)); 
         } 
       return _session; 
    }         
 }         
   } 

    public sealed class AspSession : ConfigurationElement { 
    public AspSession() 
    { 
    } 
     public bool AllowSessionState 
     { 
        get { 
       return (bool)base["allowSessionState"]; 
          } 
         set 
    { 
           base["allowSessionState"] = value; 
         } 
      } 
    }