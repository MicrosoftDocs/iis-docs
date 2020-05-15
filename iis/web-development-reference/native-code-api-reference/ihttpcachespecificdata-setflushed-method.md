---
title: "IHttpCacheSpecificData::SetFlushed Method"
ms.date: "10/07/2016"
ms.assetid: d4cdb17b-f795-d42d-844b-3228571b804e
---
# IHttpCacheSpecificData::SetFlushed Method

Sets a value indicating that the specific data is to be flushed from the cache.  
  
## Syntax  
  
```cpp  
virtual VOID SetFlushed(  
   VOID  
) = 0;  
```  
  
### Parameters  

 This method takes no parameters.  
  
## Thread Safety  

 Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface are thread safe for the [GetFlushed](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-getflushed-method.md) and `SetFlushed` methods.  
  
## Remarks  

 The behavior of the `SetFlushed` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
- Classes that implement the [IHttpCacheSpecificData](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md) interface initialize a `private` Boolean flag to `false` as an instance variable during the construction of a new pointer. The classes then get and set this flag on subsequent calls to the `GetFlushed` and `SetFlushed` methods, respectively.  
  
- Classes that implement the [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface usually return `false` on `GetFlushed` and perform an empty operation on `SetFlushed`, because local files are considered to be always cached.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [IHttpCacheSpecificData Interface](../../web-development-reference/native-code-api-reference/ihttpcachespecificdata-interface.md)
