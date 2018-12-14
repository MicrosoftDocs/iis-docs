---
title: "IHttpTraceContext::GetTraceActivityId Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f3398f6c-34ce-4051-9dca-f2a1f8726395
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpTraceContext::GetTraceActivityId Method
Returns the trace activity identifier for the trace context.  
  
## Syntax  
  
```cpp  
virtual LPCGUID GetTraceActivityId(  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant GUID; otherwise, NULL.  
  
## Remarks  
 The behavior of this method depends on implementation. Some implementations always return NULL, while others call the [IHttpRequest::GetRawHttpRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-getrawhttprequest-method.md) method on an internal [IHttpRequest](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md) pointer and convert the returned [HTTP_REQUEST](http://go.microsoft.com/fwlink/?LinkId=56010) pointer to a `const` GUID pointer.  
  
> [!CAUTION]
>  Because some implementers return NULL, always verify that the returned LPCGUID is not NULL before you perform any operations on this data.  
  
## Notes for Implementers  
 [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpTraceContext` implementers that use dynamic memory allocation must release or call `delete` on the LPCGUID pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpTraceContext` implementers are responsible for memory management with this data; therefore, `IHttpTraceContext` clients must not release or call `delete` on the returned LPCGUID pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this LPCGUID; otherwise, an access violation will be thrown or the data will become invalid.  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTraceContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md)