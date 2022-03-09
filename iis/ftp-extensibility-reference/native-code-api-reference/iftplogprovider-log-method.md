---
title: "IFtpLogProvider::Log Method"
ms.date: "09/06/2017"
ms.assetid: 0978c707-4bba-46be-8457-abdcfb930f5b
ms.author: "robmcm"
---
# IFtpLogProvider::Log Method
Performs custom logging of FTP activity for the IFtpLogProvider interface.  
  
## Syntax  
  
```cpp#  
HRESULT Log(  
   LOGGING_PARAMETERS * pLoggingParameters  
)  
```  
  
### Parameters  
  
Term|Definition|
|---|---|
|`pLoggingParameters`|[IN] A pointer to an [LOGGING_PARAMETERS Structure](../../ftp-extensibility-reference/native-code-api-reference/logging-parameters-structure.md) that contains FTP log information.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|---|---|
|S_OK|Indicates that the operation was successful.|  
  
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
  
|Type|Description|
|---|---|
|Client|-   IIS 7.5 on                                          Windows 7<br />-   IIS 8.0 on                                          Windows 8<br />-   IIS 10.0 on                                          Windows 10|  
|Server|-   IIS 7.5 on                                          Windows Server 2008 R2<br />-   IIS 8.0 on                                          Windows Server 2012<br />-   IIS 8.5 on                                          Windows Server 2012 R2<br />-   IIS 10.0 on                                          Windows Server 2016|  
|Product|-   IIS 7.0,                                          IIS 7.5,                                          IIS 8.0,                                          IIS 8.5,                                          IIS 10.0|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpLogProvider Interface](../../ftp-extensibility-reference/native-code-api-reference/iftplogprovider-interface-native.md)
