---
title: "IGlobalTraceEventProvider::GetCurrentHttpRequestContext Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 42b1ea65-1333-aad1-b27f-7bd788f346c4
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IGlobalTraceEventProvider::GetCurrentHttpRequestContext Method
Retrieves the HTTP context for trace events that are request specific.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCurrentHttpRequestContext(  
   IHttpContext** ppHttpContext  
) = 0;  
```  
  
#### Parameters  
 `ppHttpContext`  
 A pointer to the address of an `IHttpContext` interface; otherwise, NULL.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the method is not supported.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) event types receive an [IGlobalTraceEventProvider](../../web-development-reference\webdev-native-api-reference/iglobaltraceeventprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method. You can then retrieve an [IHttpContext](../../web-development-reference\webdev-native-api-reference/ihttpcontext-interface.md) pointer by calling the `GetCurrentHttpRequestContext` method on that `IGlobalTraceEventProvider` pointer.  
  
 One possible use for `GetCurrentHttpRequestContext` is to provide custom buffering of events.  
  
 `GetCurrentHttpRequestContext` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Classes that provide HTTP trace events declare a `private``IHttpContext` pointer member variable. This variable is initialized during construction to a valid `IHttpContext` pointer. When you call `GetCurrentHttpRequestContext`, the dereferenced `ppHttpContext` parameter is set to this variable, and S_OK is returned.  
  
-   Classes that provide global trace events do not modify the `ppHttpContext` parameter and return ERROR_NOT_SUPPORTED immediately.  
  
## Notes for Implementers  
 `IGlobalTraceEventProvider` implementers are responsible for memory management with this data; therefore, `IGlobalTraceEventProvider` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpContext` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IGlobalTraceEventProvider` implementers are responsible for memory management with this data; therefore, `IGlobalTraceEventProvider` clients must not release or call `delete` on the returned `IHttpContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events and declares and initializes an [HTTP_TRACE_CONFIGURATION](../../web-development-reference\webdev-native-api-reference/http-trace-configuration-structure.md) structure that filters for events. The module then retrieves the `IHttpContext` pointer by calling the `GetCurrentHttpRequestContext` method.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalTraceEventProvider#3](IGlobalTraceEventProvider#3)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalTraceEventProvider Interface](../../web-development-reference\webdev-native-api-reference/iglobaltraceeventprovider-interface.md)