---
title: "LOGGING_PARAMETERS Structure | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e8a0342f-2636-492f-9fbf-f72dd1133f03
caps.latest.revision: 9
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# LOGGING_PARAMETERS Structure
Defines the information for FTP activity, such as user name, session ID, IP addresses for the client and server. Developers can select which logging information to use when they implement the IFtpLogProvider interface.  
  
## Syntax  
  
```cpp#  
struct LOGGING_PARAMETERS  
{  
   LPWSTR pszSessionId;  
   LPWSTR pszSiteName;  
   LPWSTR pszUserName;  
   LPWSTR pszHostName;  
   LPWSTR pszRemoteIpAddress;  
   unsigned long dwRemoteIpPort;  
   LPWSTR pszLocalIpAddress;  
   unsigned long dwLocalIpPort;  
   unsigned __int64 BytesSent;  
   unsigned __int64 BytesReceived;  
   LPWSTR pszCommand;  
   LPWSTR pszCommandParameters;  
   LPWSTR pszFullPath;  
   unsigned long dwElapsedMilliseconds;  
   unsigned long FtpStatus;  
   unsigned long FtpSubStatus;  
   HRESULT hrStatus;  
   LPWSTR pszInformation;  
};  
```  
  
## Members  
  
|||  
|-|-|  
|Member Name|Definition|  
|BytesReceived|The number of bytes received from the client.|  
|BytesSent|The number of bytes sent to the client.|  
|pszCommand|The FTP command.|  
|pszCommandParameters|The parameters related to the FTP command.|  
|dwElapsedMilliseconds|The number of milliseconds it took for the operation to complete.|  
|FtpStatus|The FTP status of the current command.|  
|FtpSubStatus|The FTP substatus of the current command.|  
|pszFullPath|The full path of the operation for the FTP command.|  
|pszHostName|The FTP virtual host name.|  
|hrStatus|The Windows error code for the operation.|  
|pszInformation|Additional troubleshooting information for the command.|  
|pszLocalIpAddress|The local IP address to which the client is connected.|  
|dwLocalIpPort|The TCP/IP port of the server.|  
|pszRemoteIpAddress|The IP address of the client.|  
|dwRemoteIpPort|The TCP/IP port of the client.|  
|pszSessionId|The session ID.|  
|pszSiteName|The name of the server instance that is being logged.|  
|pszUserName|The name of the user.|  
  
## Example  
 The following code example illustrates how to use the `IFtpLogProvider` interface to create a custom logging module for the FTP service.  
  
```  
public:  
   STDMETHOD(Log)(LOGGING_PARAMETERS * pLoggingParameters)  
   {  
      // Note: You would add your own custom logic here.  
      HRESULT hr = S_OK;  
      DWORD dwResult;  
      HANDLE hFile;  
      char szLogEntry[256]="";  
      const DWORD FILE_WRITE_TO_END_OF_FILE = 0xffffffff;  
  
      OVERLAPPED Overlapped = { 0 };  
      Overlapped.Offset = FILE_WRITE_TO_END_OF_FILE;  
      Overlapped.OffsetHigh = -1;  
  
      // Retrieve the current date and time for the log entry.  
      SYSTEMTIME CurrentTime;  
      GetSystemTime(&CurrentTime);  
  
      // Open the log file for output.  
      hFile = CreateFile(  
         L"\\\\?\\C:\\logfiles\\myftpsite\\myftplog.log",  
         GENERIC_WRITE,  
         FILE_SHARE_READ,  
         NULL,  
         OPEN_ALWAYS,  
         FILE_ATTRIBUTE_NORMAL | FILE_FLAG_WRITE_THROUGH,  
         NULL);  
  
      // Return an error if a failure occurs.  
      if (hFile == INVALID_HANDLE_VALUE)  
      {  
         hr = HRESULT_FROM_WIN32(GetLastError());  
         goto EXIT;  
      }  
  
      // Format the log entry.  
      hr = StringCchPrintfA(  
         szLogEntry,256,  
         "%04d-%02d-%02d\t%02d:%02d:%02d\t%S\t%d\r\n",  
         CurrentTime.wYear,CurrentTime.wMonth,CurrentTime.wDay,  
         CurrentTime.wHour,CurrentTime.wMinute,CurrentTime.wSecond,  
         pLoggingParameters->pszCommand,  
         pLoggingParameters->FtpStatus);  
  
      // Test for error.  
      if (FAILED(hr))  
      {  
         // Return the error if a failure occurs.  
         hr = HRESULT_FROM_WIN32(GetLastError());  
         goto EXIT;  
      }  
  
      // Write the log entry to the log file.  
      if(!WriteFile(hFile, szLogEntry,  
         strlen(szLogEntry), &dwResult, &Overlapped))        
      {  
         // Return an error if a failure occurs.  
         hr = HRESULT_FROM_WIN32(GetLastError());  
         goto EXIT;  
      }  
  
EXIT:  
      // Close the log file if it is open.  
      if(CloseHandle(hFile)==0)  
      {  
         // Return an error if a failure occurs.  
         hr = HRESULT_FROM_WIN32(GetLastError());  
      }  
      return hr;  
   }  
```  
  
## Requirements  
  
|||  
|-|-|  
|Type|Description|  
|Client|-   IIS 7.5 on                                          Windows 7<br />-   IIS 8.0 on                                          Windows 8<br />-   IIS 10.0 on                                          Windows 10|  
|Server|-   IIS 7.5 on                                          Windows Server 2008 R2<br />-   IIS 8.0 on                                          Windows Server 2012<br />-   IIS 8.5 on                                          Windows Server 2012 R2<br />-   IIS 10.0 on                                          Windows Server 2016|  
|Product|-   IIS 7.0,                                          IIS 7.5,                                          IIS 8.0,                                          IIS 8.5,                                          IIS 10.0|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpLogProvider Interface](../../ftp-extenisibility-reference\native-code-api-reference\iftplogprovider-interface-native.md)