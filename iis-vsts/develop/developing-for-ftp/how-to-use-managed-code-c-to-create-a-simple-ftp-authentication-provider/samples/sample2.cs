using System;
using Microsoft.Web.FtpServer;

namespace FtpAuthentication
{
    public class FtpAuthDemo : BaseProvider,
        IFtpAuthenticationProvider,
        IFtpRoleProvider
    {
        bool IFtpAuthenticationProvider.AuthenticateUser(
            string sessionId,
            string siteName,
            string userName,
            string userPassword,
            out string canonicalUserName)
        {
            // Note: You would add your own custom logic here.
            canonicalUserName = userName;
            string strUserName = "MyUser";
            string strPassword = "MyPassword";

            // Verify that the user name and password are valid.
            // Note: In this example, the user name is case-insensitive
            // and the password is case-sensitive.
            if (((userName.Equals(strUserName,
                StringComparison.OrdinalIgnoreCase))==true) &&
                userPassword == strPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IFtpRoleProvider.IsUserInRole(
            string sessionId,
            string siteName,
            string userName,
            string userRole)
        {
            // Note: You would add your own custom logic here.
            string strUserName = "MyUser";
            string strRoleName = "MyRole";

            // Verify that the user name and role name are valid.
            // Note: In this example, both the user name and
            // the role name are case-insensitive.
            if (((userName.Equals(strUserName,
                StringComparison.OrdinalIgnoreCase))==true) &&
                ((userRole.Equals(strRoleName,
                StringComparison.OrdinalIgnoreCase))==true))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}