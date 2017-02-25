Imports System
Imports System.IO
Imports Microsoft.Web.FtpServer

Namespace FtpLogging
    Public Class FtpLogDemo
        Inherits BaseProvider
        Implements IFtpLogProvider
        Public Sub Log(ByVal loggingParameters As FtpLogEntry) _
            Implements IFtpLogProvider.Log
            ' Note: You would add your own custom logic here.
            ' Open the log file for output.
            Dim sw As StreamWriter = New StreamWriter( _
                "C:\logfiles\myftpsite\myftplog.log", True)
            ' Retrieve the current date and time for the log entry.
            Dim dt As DateTime = DateTime.Now
            ' Retrieve the user name.
            Dim un As String = loggingParameters.UserName
            ' Write the log entry to the log file.
            sw.WriteLine( _
                String.Format("{0}" & vbTab & "{1}" & vbTab & "{2}" & _
                vbTab & "{3}" & vbTab & "{4}" & vbTab & "{5}", _
                dt.ToShortDateString(), _
                dt.ToLongTimeString(), _
                loggingParameters.RemoteIPAddress, _
                IIf((un.Length = 0), "-", un), _
                loggingParameters.Command, _
                loggingParameters.SessionId))
            sw.Dispose()
        End Sub
    End Class
End Namespace