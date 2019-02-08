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
 The behavior of this method depends on implementation. Some implementations always return NULL, while others call the [IHttpRequest::GetRawHttpRequest](../../web-development-reference\native-code-api-reference/ihttprequest-getrawhttprequest-method.md) method on an internal [IHttpRequest](../../web-development-reference\native-code-api-reference/ihttprequest-interface.md) pointer and convert the returned [HTTP_REQUEST](http://go.microsoft.com/fwlink/?LinkId=56010) pointer to a `const` GUID pointer.  
  
> [!CAUTION]
>  Because some implementers return NULL, always verify that the returned LPCGUID is not NULL before you perform any operations on this data.  
  
## Notes for Implementers  
 [IHttpTraceContext](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpTraceContext` implementers that use dynamic memory allocation must release or call `delete` on the LPCGUID pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpTraceContext` implementers are responsible for memory management with this data; therefore, `IHttpTraceContext` clients must not release or call `delete` on the returned LPCGUID pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this LPCGUID; otherwise, an access violation will be thrown or the data will become invalid.  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTraceContext Interface](../../web-development-reference\native-code-api-reference/ihttptracecontext-interface.md)