---
title: "IHttpRequest::GetHeaderChanges Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 635f6d30-ce86-e613-cf4b-cc36320c8c2d
caps.latest.revision: 10
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::GetHeaderChanges Method
Retrieves the changes to the server headers for the current request.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetHeaderChanges(  
   IN DWORD dwOldChangeNumber,  
   OUT DWORD* pdwNewChangeNumber,  
   IN OUT PCSTR knownHeaderSnapshot [HttpHeaderRequestMaximum],  
   IN OUT DWORD* pdwUnknownHeaderSnapShot,  
   IN OUT PCSTR** ppUnknownHeaderNameSnapShot,  
   IN OUT PCSTR** ppUnknownHeaderValueSnapShot,  
   __out_ecount(HttpHeaderRequestMaximum+1) DWORD diffedKnownHeaderIndices [HttpHeaderRequestMaximum+1],  
   OUT DWORD* pdwDiffedUnknownHeaders,  
   OUT DWORD** ppDiffedUnknownHeaderIndices  
) = 0;  
```  
  
#### Parameters  
 `dwOldChangeNumber`  
 [IN] A `DWORD` that contains the old change number.  
  
 `pdwNewChangeNumber`  
 [OUT] A pointer to a `DWORD` that contains the new change number.  
  
 `knownHeaderSnapshot`  
 [IN][OUT] A pointer to a string array that contains the snapshot of all known headers. (The array will contain the new headers when calling, and it will contain the old headers when returning.)  
  
 `pdwUnknownHeaderSnapShot`  
 [IN][OUT] A pointer to a `DWORD` that contains the number of unknown headers in the snapshot.  
  
 `ppUnknownHeaderNameSnapShot`  
 [IN][OUT] A pointer to the address of a string array that contains the names of all unknown headers. (The array will contain the new headers when calling, and it will contain the old headers when returning.)  
  
 `ppUnknownHeaderValueSnapShot`  
 [IN][OUT] A pointer to the address of a string array that contains a list of all header values in the snapshot.  
  
 `diffedKnownHeaderIndices`  
 [OUT] An array of `DWORD` values, terminated by a –1 value, that contain the indexes of headers that have changed in the list of known headers.  
  
 `pdwDiffedUnknownHeaders`  
 [OUT] A pointer to a `DWORD` value that contains number of unknown headers that have changed.  
  
 `ppDiffedUnknownHeaderIndices`  
 [OUT] A pointer to the address of an array of `DWORD` values, terminated by a –1 value, that contain the indexes of headers that have changed in the list of unknown headers.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 IIS uses the `GetHeaderChanges` method to test for changes to the HTTP headers since the last time the headers were examined.  
  
> [!NOTE]
>  IIS uses the `GetHeaderChanges` method to internally synchronize the headers between calls to native and managed code. You should not use the `GetHeaderChanges` method when you create an HTTP module.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpRequest Interface](../../web-development-reference\webdev-native-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::GetHeader Method](../../web-development-reference\webdev-native-api-reference/ihttprequest-getheader-method.md)   
 [IHttpResponse::GetHeader Method](../../web-development-reference\webdev-native-api-reference/ihttpresponse-getheader-method.md)   
 [IHttpResponse::GetHeaderChanges Method](../../web-development-reference\webdev-native-api-reference/ihttpresponse-getheaderchanges-method.md)