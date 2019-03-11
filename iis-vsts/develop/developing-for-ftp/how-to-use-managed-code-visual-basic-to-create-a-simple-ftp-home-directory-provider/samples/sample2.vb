Imports System
Imports Microsoft.Web.FtpServer

Namespace FtpHomeDirectory
  Public Class FtpHomeDirDemo
    Inherits BaseProvider
    Implements IFtpHomeDirectoryProvider

    Function IFtpHomeDirectoryProvider_GetUserHomeDirectoryData( _
      ByVal sessionId As String, _
      ByVal siteName As String, _
      ByVal userName As String) _
        As String _
        Implements IFtpHomeDirectoryProvider.GetUserHomeDirectoryData

      ' Note: You would add your own custom logic here.

      ' Return the user's home directory based on their user name.
      Return ("C:\Ftpusers\" + userName)

    End Function

  End Class
End Namespace