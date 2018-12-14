---
title: "ICacheProvider::SetCacheRecord Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ad7bd066-65fc-bd1f-4236-48762170f066
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# ICacheProvider::SetCacheRecord Method
Sets the cache-specific data on the cache provider.  
  
## Syntax  
  
```cpp  
virtual VOID SetCacheRecord(  
   IHttpCacheSpecificData* pCacheRecord  
) = 0;  
```  
  
#### Parameters  
 `pCacheRecord`  
 A pointer to an [IHttpCacheSpecificData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-interface.md) value.  
  
## Remarks  
 The `pCacheRecord` parameter must not be NULL, because later internal calls to the [GetCacheRecord](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcacherecord-method.md) method may cause an access violation.  
  
> [!IMPORTANT]
>  The `SetCacheRecord` method is part of the IIS infrastructure and is not intended to be used directly from your code.  
  
## Notes for Implementers  
 [ICacheProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md) implementers declare a `private``IHttpCacheSpecificData` pointer as member data. When constructors of these implementers are called, this member data is assigned to an `IHttpCacheSpecificData` pointer. Before calling `SetCacheRecord`, the caller is responsible for first calling [IHttpCacheSpecificData::ReferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-referencecachedata-method.md) on the `IHttpCacheSpecificData` pointer; `SetCacheRecord` implementers then assign the `private` variable to this `IHttpCacheSpecificData` pointer.  
  
 When `SetCacheRecord` is called, implementers should first check if the current `private` member pointer is non-NULL. If the `private` data is non-NULL, call [IHttpCacheSpecificData::DereferenceCacheData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachespecificdata-dereferencecachedata-method.md) first on this current data so that it can be released, but then always assign the `private` variable to the `pCacheRecord` parameter.  
  
 The following table is a sample of one-to-one interface mappings that must be returned from the [GetCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-getcachekey-method.md) and `GetCacheRecord` methods from the same implementer of the `ICacheProvider` interface.  
  
|GetCacheKey interface|GetCacheRecord interface|  
|---------------------------|------------------------------|  
|[IFileKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ifilekey-interface.md)|[IHttpFileInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpfileinfo-interface.md)|  
|[IHttpTokenKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenkey-interface.md)|[IHttpTokenEntry](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptokenentry-interface.md)|  
|[IHttpCacheKey](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcachekey-interface.md)|`IHttpCacheSpecificData`|  
  
## Notes for Callers  
 `ICacheProvider` implementers take ownership of the `IHttpCacheSpecificData` pointer. Before calling `SetCacheRecord`, first call `IHttpCacheSpecificData::ReferenceCacheData` on the pointer so that this pointer has one owner.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icacheprovider-interface.md)