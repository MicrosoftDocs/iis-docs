---
title: "IHttpServer::AddFragmentToCache Method"
ms.date: "10/07/2016"
ms.assetid: 1b72f5c0-780b-61af-9796-7bdb5f2017ad
---
# IHttpServer::AddFragmentToCache Method
Adds an [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structure to the cache.  
  
## Syntax  
  
```cpp  
virtual HRESULT AddFragmentToCache(  
   HTTP_DATA_CHUNK* pDataChunk,  
   __in WCHAR* pszFragmentName  
) = 0;  
```  
  
### Parameters  
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
 Developers can use the `AddFragmentToCache`, [ReadFragmentFromCache](../../web-development-reference/native-code-api-reference/ihttpserver-readfragmentfromcache-method.md), and [RemoveFragmentFromCache](../../web-development-reference/native-code-api-reference/ihttpserver-removefragmentfromcache-method.md) methods, respectively, to add `HTTP_DATA_CHUNK` structures to the fragment cache, or to retrieve and remove `HTTP_DATA_CHUNK` structures from the cache. These methods give developers a small degree of custom functionality to use the built-in IIS cache for storing and retrieving data fragments in the cache.  
  
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
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)   
 [IHttpServer::RemoveFragmentFromCache Method](../../web-development-reference/native-code-api-reference/ihttpserver-removefragmentfromcache-method.md)   
 [IHttpServer::ReadFragmentFromCache Method](../../web-development-reference/native-code-api-reference/ihttpserver-readfragmentfromcache-method.md)