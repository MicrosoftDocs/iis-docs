---
title: IFtpHomeDirectoryProvider Interface (Native)
description: Describe the IFtpHomeDirectoryProvider native interface and provides the interface's syntax, methods, an example, and requirements.
ms.date: 09/06/2017
ms.assetid: b7bc3cf4-96eb-4cb2-ad39-1323d581da3f
ms.author: "robmcm"
---
# IFtpHomeDirectoryProvider Interface (Native)
Provides an interface to implement returning the physical path for a user's home directory.  
  
## Syntax  
  
```cpp#  
interface IFtpHomeDirectoryProvider : IUknown  
```  
  
## Methods  
 The following table lists the methods exposed by the `IFtpHomeDirectoryProvider` interface.  
  
|Name|Definition|
|---|---|
|[IFtpHomeDirectoryProvider::GetUserHomeDirectoryData Method](../../ftp-extensibility-reference/native-code-api-reference/iftphomedirectoryprovider-getuserhomedirectorydata-method.md)|Returns the physical path of the home directory for a user.|  
  
## Example  
 The following code example illustrates using the `IFtpHomeDirectoryProvider` interface to create a custom home directory module for the FTP service that returns a specific home directory.  
  
```  
public:  
   STDMETHOD(GetUserHomeDirectoryData)(  
      LPWSTR pszSessionId,  
      LPWSTR pszSiteName,  
      LPWSTR pszUserName,  
      LPWSTR * ppszHomeDirectoryData)  
   {  
      // Note: You would add your own custom logic here.  
      HRESULT hr = S_OK;  
      WCHAR wszPath[MAX_PATH] = L"";  
  
      // Calculate the user's home directory based on their user name.  
      hr = StringCchPrintf(wszPath,_countof(wszPath),  
         L"\\\\?\\C:\\ftpusers\\%s",pszUserName);  
      // Return an error if a failure occurs.  
      if (FAILED(hr))  
      {  
         return hr;  
      }  
  
      // Allocate a block of memory for the user's home directory.  
      LPWSTR wszHomeDirectoryData =  
          (LPWSTR)CoTaskMemAlloc(_countof(wszPath) * sizeof(WCHAR));  
      // Return an error if a failure occurs.  
      if (wszHomeDirectoryData == NULL)  
      {  
         return E_OUTOFMEMORY;  
      }  
  
      // Copy the user's home directory into the memory block.  
      hr = StringCchCopy(wszHomeDirectoryData,  
         _countof(wszPath), wszPath);  
      // Return an error if a failure occurs.  
      if (FAILED(hr))  
      {  
      return hr;  
      }  
  
      // Return the user's home directory.  
       (*ppszHomeDirectoryData) = wszHomeDirectoryData;  
      return S_OK;  
   }  
```  
  
## Requirements  
  
|Type|Description|
|---|---|
|Client|-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0|  
|Reference|ftpext.tlb|
