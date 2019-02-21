---
title: "IHttpServer::RemoveFragmentFromCache Method"
ms.date: "10/07/2016"
ms.assetid: d2fcb067-d89b-e57f-4faf-8f38d79843f8
---
# IHttpServer::RemoveFragmentFromCache Method
Removes a specific fragment from the cache.  
  
## Syntax  
  
```cpp  
virtual HRESULT RemoveFragmentFromCache(  
   __in WCHAR* pszFragmentName  
) = 0;  
```  
  
### Parameters  
 `pszFragmentName`  
 [IN] A pointer to a `WCHAR` that specifies the fragment to be removed from the cache.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the fragment specified by the `pszFragmentName` parameter could not be found.|  
  
## Remarks  
 Developers can use the [AddFragmentToCache](../../web-development-reference\native-code-api-reference/ihttpserver-addfragmenttocache-method.md), [ReadFragmentFromCache](../../web-development-reference\native-code-api-reference/ihttpserver-readfragmentfromcache-method.md), and `RemoveFragmentFromCache` methods, respectively, to add [HTTP_DATA_CHUNK](http://go.microsoft.com/fwlink/?LinkId=56011) structures to the fragment cache, or to retrieve and remove `HTTP_DATA_CHUNK` structures from the cache. These methods give developers a small degree of custom functionality to use the built-in IIS cache for storing and retrieving data fragments in the cache.  
  
> [!NOTE]
>  Http.sys manages and owns the fragment cache. At any time, Http.sys may override or delete information that you directed to be stored. There is currently no way to lock information in the fragment cache as nonvolatile information.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md)   
 [IHttpServer::AddFragmentToCache Method](../../web-development-reference\native-code-api-reference/ihttpserver-addfragmenttocache-method.md)   
 [IHttpServer::ReadFragmentFromCache Method](../../web-development-reference\native-code-api-reference/ihttpserver-readfragmentfromcache-method.md)