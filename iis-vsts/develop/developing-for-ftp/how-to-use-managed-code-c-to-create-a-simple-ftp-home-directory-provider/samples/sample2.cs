using System;
using Microsoft.Web.FtpServer;
 
namespace FtpHomeDirectory
{
    public class FtpHomeDirDemo : BaseProvider,
        IFtpHomeDirectoryProvider
    {
        string IFtpHomeDirectoryProvider.GetUserHomeDirectoryData(
            string sessionId,
            string siteName,
            string userName)
        {
            // Note: You would add your own custom logic here.
            // Return the user's home directory based on their user name.
            return @"C:\Ftpusers\" + userName;
        }
    }
}