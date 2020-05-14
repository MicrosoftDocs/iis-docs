---
title: "IHttpServer::ReadFragmentFromCache Method"
ms.date: "10/07/2016"
ms.assetid: b658cbf0-4370-930b-b692-b2b34591206f
---
# IHttpServer::ReadFragmentFromCache Method
Retrieves a specific fragment from the cache.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReadFragmentFromCache(  
   __in WCHAR* pszFragmentName,  
   BYTE* pvBuffer,  
   DWORD cbSize,  
   DWORD* pcbCopied  
) = 0;  
```  
  
### Parameters  
 `pszFragmentName`  
 [__in] A pointer to a `WCHAR` that specifies the fragment to retrieve from the cache.  
  
 `pvBuffer`  
 A pointer to a `BYTE` buffer that contains the cache fragment.  
  
 `cbSize`  
 A `DWORD` that contains the length, in bytes, of the buffer.  
  
 `pcbCopied`  
 A pointer to a `DWORD` that contains the number of bytes read from the cache.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_PATH_NOT_FOUND|Indicates that the fragment specified by the `pszFragmentName` parameter could not be found.|  
  
## Remarks  
 Developers can use the [AddFragmentToCache](../../web-development-reference/native-code-api-reference/ihttpserver-addfragmenttocache-method.md), `ReadFragmentFromCache`, and [RemoveFragmentFromCache](../../web-development-reference/native-code-api-reference/ihttpserver-removefragmentfromcache-method.md) methods, respectively, to add [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structures to the fragment cache, or to retrieve and remove `HTTP_DATA_CHUNK` structures from the cache. These methods give developers a small degree of custom functionality to use the built-in IIS cache for storing and retrieving data fragments in the cache.  
  
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
 [IHttpServer::AddFragmentToCache Method](../../web-development-reference/native-code-api-reference/ihttpserver-addfragmenttocache-method.md)
 [IHttpServer::RemoveFragmentFromCache Method](../../web-development-reference/native-code-api-reference/ihttpserver-removefragmentfromcache-method.md)
