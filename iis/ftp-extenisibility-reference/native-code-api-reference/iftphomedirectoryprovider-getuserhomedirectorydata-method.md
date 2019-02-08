---
title: "IFtpHomeDirectoryProvider::GetUserHomeDirectoryData Method | Microsoft Docs"
ms.custom: ""
ms.date: "09/06/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 36671ffa-4c66-40dc-a1c5-6ecd5309e191
caps.latest.revision: 7
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IFtpHomeDirectoryProvider::GetUserHomeDirectoryData Method
Returns the physical path of the home directory for a user.  
  
## Syntax  
  
```cpp#  
HRESULT GetUserHomeDirectoryData(  
   LPWSTR pszSessionId,  
   LPWSTR pszSiteName,  
   LPWSTR pszUserName,  
   LPWSTR * ppszHomeDirectoryData  
)  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Term|Definition|  
|`pszSessionId`|[IN] A pointer to a string that contains the session ID.|  
|`pszSiteName`|[IN] A pointer to a string that contains the site name.|  
|`pszUserName`|[IN] A pointer to a string that contains the user name.|  
|`ppszHomeDirectoryData`|[OUT] A pointer to a string that will contain the physical path for the user.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|||  
|-|-|  
|Value|Description|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example illustrates how to use the `IFtpHomeDirectoryProvider` interface to create a custom home directory module for the FTP service that returns a specific home directory.  
  
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
  
|||  
|-|-|  
|Type|Description|  
|Client|-   IIS 7.5 on                                          Windows 7<br />-   IIS 8.0 on                                          Windows 8<br />-   IIS 10.0 on                                          Windows 10|  
|Server|-   IIS 7.5 on                                          Windows Server 2008 R2<br />-   IIS 8.0 on                                          Windows Server 2012<br />-   IIS 8.5 on                                          Windows Server 2012 R2<br />-   IIS 10.0 on                                          Windows Server 2016|  
|Product|-   IIS 7.0,                                          IIS 7.5,                                          IIS 8.0,                                          IIS 8.5,                                          IIS 10.0|  
|Reference|ftpext.tlb|  
  
## See Also  
 [IFtpHomeDirectoryProvider Interface](../../ftp-extenisibility-reference\native-code-api-reference\iftphomedirectoryprovider-interface-native.md)