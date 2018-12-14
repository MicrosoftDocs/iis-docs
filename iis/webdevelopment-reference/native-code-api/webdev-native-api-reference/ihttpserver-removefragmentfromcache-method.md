---
title: "IHttpServer::RemoveFragmentFromCache Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d2fcb067-d89b-e57f-4faf-8f38d79843f8
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::RemoveFragmentFromCache Method
Removes a specific fragment from the cache.  
  
## Syntax  
  
```cpp  
virtual HRESULT RemoveFragmentFromCache(  
   __in WCHAR* pszFragmentName  
) = 0;  
```  
  
#### Parameters  
 `pszFragmentName`  
 [IN] A pointer to a `WCHAR` that specifies the fragment to be removed from the cache.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the fragment specified by the `pszFragmentName` parameter could not be found.|  
  
## Remarks  
 Developers can use the [AddFragmentToCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-addfragmenttocache-method.md), [ReadFragmentFromCache](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-readfragmentfromcache-method.md), and `RemoveFragmentFromCache` methods, respectively, to add [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structures to the fragment cache, or to retrieve and remove `HTTP_DATA_CHUNK` structures from the cache. These methods give developers a small degree of custom functionality to use the built-in IIS cache for storing and retrieving data fragments in the cache.  
  
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
 [IHttpServer::AddFragmentToCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-addfragmenttocache-method.md)   
 [IHttpServer::ReadFragmentFromCache Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-readfragmentfromcache-method.md)