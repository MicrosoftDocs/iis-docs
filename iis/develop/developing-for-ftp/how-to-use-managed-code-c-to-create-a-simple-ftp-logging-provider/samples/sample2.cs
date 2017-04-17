using System;
using System.IO;
using Microsoft.Web.FtpServer;

namespace FtpLogging
{
    public class FtpLogDemo : BaseProvider,
        IFtpLogProvider
    {
        void IFtpLogProvider.Log(FtpLogEntry loggingParameters)
        {
            // Note: You would add your own custom logic here.
            // Open the log file for output.
            using (StreamWriter sw =
                new StreamWriter(@"C:\logfiles\myftpsite\myftplog.log",true))
                {
                // Retrieve the current date and time for the log entry.
                DateTime dt = DateTime.Now;
                // Retrieve the user name.
                string un = loggingParameters.UserName;
                // Write the log entry to the log file.
                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",
                    dt.ToShortDateString(),
                    dt.ToLongTimeString(),
                    loggingParameters.RemoteIPAddress,
                    (un.Length == 0) ? "-" : un,
                    loggingParameters.Command,
                    loggingParameters.SessionId);
            }
        }
    }
}