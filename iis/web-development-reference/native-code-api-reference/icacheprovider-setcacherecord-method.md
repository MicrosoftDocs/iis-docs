---
title: "ICacheProvider::SetCacheRecord Method"
description: This article contains information about syntax and requirements for the ICacheProvider::SetCacheRecord method.
ms.date: "10/07/2016"
ms.assetid: ad7bd066-65fc-bd1f-4236-48762170f066
---
# ICacheProvider::SetCacheRecord Method
Sets the cache-specific data on the cache provider.  
  
## Syntax  
  
```cpp  
virtual VOID SetCacheRecord(  
   IHttpCacheSpecificData* pCacheRecord  
) = 0;  
```  
  
### Parameters  
 `pCacheRecord`  
 A pointer to an [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) value.  
  
## Remarks  
 The `pCacheRecord` parameter must not be NULL, because later internal calls to the [GetCacheRecord](../../web-development-reference/native-code-api-reference/icacheprovider-getcacherecord-method.md) method may cause an access violation.  
  
> [!IMPORTANT]
>  The `SetCacheRecord` method is part of the IIS infrastructure and is not intended to be used directly from your code.  
  
## Notes for Implementers  
 [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) implementers declare a `private``IHttpCacheSpecificData` pointer as member data. When constructors of these implementers are called, this member data is assigned to an `IHttpCacheSpecificData` pointer. Before calling `SetCacheRecord`, the caller is responsible for first calling [IHttpCacheSpecificData::ReferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-referencecachedata-method.md) on the `IHttpCacheSpecificData` pointer; `SetCacheRecord` implementers then assign the `private` variable to this `IHttpCacheSpecificData` pointer.  
  
 When `SetCacheRecord` is called, implementers should first check if the current `private` member pointer is non-NULL. If the `private` data is non-NULL, call [IHttpCacheSpecificData::DereferenceCacheData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md) first on this current data so that it can be released, but then always assign the `private` variable to the `pCacheRecord` parameter.  
  
 The following table is a sample of one-to-one interface mappings that must be returned from the [GetCacheKey](../../web-development-reference/native-code-api-reference/icacheprovider-getcachekey-method.md) and `GetCacheRecord` methods from the same implementer of the `ICacheProvider` interface.  
  
|GetCacheKey interface|GetCacheRecord interface|  
|---------------------------|------------------------------|  
|[IFileKey](../../web-development-reference/native-code-api-reference/ifilekey-interface.md)|[IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)|  
|[IHttpTokenKey](../../web-development-reference/native-code-api-reference/ihttptokenkey-interface.md)|[IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md)|  
|[IHttpCacheKey](../../web-development-reference/native-code-api-reference/ihttpcachekey-interface.md)|`IHttpCacheSpecificData`|  
  
## Notes for Callers  
 `ICacheProvider` implementers take ownership of the `IHttpCacheSpecificData` pointer. Before calling `SetCacheRecord`, first call `IHttpCacheSpecificData::ReferenceCacheData` on the pointer so that this pointer has one owner.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)
