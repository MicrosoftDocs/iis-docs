#region Using directives
using System;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Security.Principal;
using System.IO;
#endregion
 
namespace IIS7Demos
{
    /// 
    /// This module performs basic authentication. 
    /// For details on basic authentication see RFC 2617. 
    /// 
    /// The basic operational flow is: 
    /// 
    ///     On AuthenticateRequest: 
    ///         extract the basic authentication credentials 
    ///         verify the credentials 
    ///         if successful, create the user principal with these credentials 
    /// 
    ///     On SendResponseHeaders: 
    ///         if the request is being rejected with an unauthorized status code (401), 
    ///         add the basic authentication challenge to trigger basic authentication. 
    ///       
    /// 

    public class BasicAuthenticationModule : IHttpModule
    {
        #region member declarations
        public const String     HttpAuthorizationHeader = "Authorization";  // HTTP1.1 Authorization header 
        public const String     HttpBasicSchemeName = "Basic"; // HTTP1.1 Basic Challenge Scheme Name 
        public const Char       HttpCredentialSeparator = ':'; // HTTP1.1 Credential username and password separator 
        public const int        HttpNotAuthorizedStatusCode = 401; // HTTP1.1 Not authorized response status code 
        public const String     HttpWWWAuthenticateHeader = "WWW-Authenticate"; // HTTP1.1 Basic Challenge Scheme Name 
        public const String     Realm = "demo"; // HTTP.1.1 Basic Challenge Realm 
        #endregion

        #region Main Event Processing Callbacks
        public void AuthenticateUser(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;
            String userName = null;
            String password = null;
            String realm = null;
            String authorizationHeader = context.Request.Headers[HttpAuthorizationHeader];

            // 
            //  Extract the basic authentication credentials from the request 
            // 
            if (!ExtractBasicCredentials(authorizationHeader, ref userName, ref password))
                return;
            // 
            // Validate the user credentials 
            // 
            if (!ValidateCredentials(userName, password, realm))
               return;

            // 
            // Create the user principal and associate it with the request 
            // 
            context.User = new GenericPrincipal(new GenericIdentity(userName), null);
        }

        public void IssueAuthenticationChallenge(Object source, EventArgs e)
        {
            HttpApplication application = (HttpApplication)source;
            HttpContext context = application.Context;

            // 
            // Issue a basic challenge if necessary 
            // 

            if (context.Response.StatusCode == HttpNotAuthorizedStatusCode)
            {
                context.Response.AddHeader(HttpWWWAuthenticateHeader, "Basic realm =\"" + Realm + "\"");
            }
        }
        #endregion

        #region Utility Methods
        protected virtual bool ValidateCredentials(String userName, String password, String realm)
        {
            // 
            //  Validate the credentials using Membership (default provider) 
            // 
            // NOTE: Membership is commented out for clarity reasons.   
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
            // WARNING: DO NOT USE THE CODE BELOW IN PRODUCTION 
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
            // return Membership.ValidateUser(userName, password); 
            if (userName.Equals("test") && password.Equals("test"))
            {
                return true;
            }
            else 
            {
                return false;
            }    
        }
      
        protected virtual bool ExtractBasicCredentials(String authorizationHeader, ref String username, ref String password)
        {
            if ((authorizationHeader == null) || (authorizationHeader.Equals(String.Empty)))
               return false;
            String verifiedAuthorizationHeader = authorizationHeader.Trim();
            if (verifiedAuthorizationHeader.IndexOf(HttpBasicSchemeName) != 0)     
                return false;

            // get the credential payload 
            verifiedAuthorizationHeader = verifiedAuthorizationHeader.Substring(HttpBasicSchemeName.Length, verifiedAuthorizationHeader.Length - HttpBasicSchemeName.Length).Trim();
           // decode the base 64 encoded credential payload 
            byte[] credentialBase64DecodedArray = Convert.FromBase64String(verifiedAuthorizationHeader);
            UTF8Encoding encoding = new UTF8Encoding();
            String decodedAuthorizationHeader = encoding.GetString(credentialBase64DecodedArray, 0, credentialBase64DecodedArray.Length);

            // get the username, password, and realm 
            int separatorPosition = decodedAuthorizationHeader.IndexOf(HttpCredentialSeparator);

           if (separatorPosition <= 0)
              return false;
            username = decodedAuthorizationHeader.Substring(0, separatorPosition).Trim();
           password = decodedAuthorizationHeader.Substring(separatorPosition + 1, (decodedAuthorizationHeader.Length - separatorPosition - 1)).Trim();

            if (username.Equals(String.Empty) || password.Equals(String.Empty))
               return false;

           return true;
        }
        #endregion

        #region IHttpModule Members
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
        public void Dispose()
        {
            // 
            // Do nothing here 
            // 
        }
        #endregion

    }
}
