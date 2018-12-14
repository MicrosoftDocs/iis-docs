---
title: "IHttpServer::AddFragmentToCache Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1b72f5c0-780b-61af-9796-7bdb5f2017ad
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::AddFragmentToCache Method
Adds an [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structure to the cache.  
  
## Syntax  
  
```cpp  
virtual HRESULT AddFragmentToCache(  
   HTTP_DATA_CHUNK* pDataChunk,  
   __in WCHAR* pszFragmentName  
) = 0;  
```  
  
#### Parameters  
 `pDataChunk`  
 [IN] A pointer to an `HTTP_DATA_CHUNK` structure.  
  
 `pszFragmentName`  
 [IN] A pointer to a `WCHAR` value that specifies the fragment to be added to the cache.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_INVALIDARG|Indicates that one of the parameters is not valid.|  
|ERROR_INVALID_PARAMETER|Indicates that one of the parameters is not valid.|  
  
## Remarks  
 Developers can use the `AddFragmentToCache`, [ReadFragmentFromCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-readfragmentfromcache-method.md), and [RemoveFragmentFromCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-removefragmentfromcache-method.md) methods, respectively, to add `HTTP_DATA_CHUNK` structures to the fragment cache, or to retrieve and remove `HTTP_DATA_CHUNK` structures from the cache. These methods give developers a small degree of custom functionality to use the built-in IIS cache for storing and retrieving data fragments in the cache.  
  
> [!NOTE]
>  Http.sys manages and owns the fragment cache. At any time, Http.sys may override or delete information that you directed to be stored. There is currently no way to lock information in the fragment cache as nonvolatile information.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [IHttpServer::RemoveFragmentFromCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-removefragmentfromcache-method.md)   
 [IHttpServer::ReadFragmentFromCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-readfragmentfromcache-method.md)