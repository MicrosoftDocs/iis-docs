public void Init(HttpApplication context)            
{
   //          
   // Subscribe to the authenticate event to perform the 
   // authentication. 
   // 
   context.AuthenticateRequest += new        
              EventHandler(this.AuthenticateUser);

   // 
   // Subscribe to the EndRequest event to issue the 
   // challenge if necessary. 
   // 
   context.EndRequest += new 
              EventHandler(this.IssueAuthenticationChallenge);
}