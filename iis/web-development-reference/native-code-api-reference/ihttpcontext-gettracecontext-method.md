---
title: "IHttpContext::GetTraceContext Method"
ms.date: "10/07/2016"
ms.assetid: 49aa513f-da98-dd64-2aac-91abc2df844b
---
# IHttpContext::GetTraceContext Method
Retrieves the trace context container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpTraceContext* GetTraceContext(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) interface.  
  
## Remarks  
 Use either the `IHttpContext::GetTraceContext` or [IHttpServer::GetTraceContext](../../web-development-reference/native-code-api-reference/ihttpserver-gettracecontext-method.md) method to retrieve an `IHttpTraceContext` interface when you need to raise an event that is associated with an HTTP request. When you need to raise an event that is not associated with an HTTP request, use only the `IHttpServer::GetTraceContext` method to retrieve an `IHttpTraceContext` interface.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1.  Retrieves a pointer to an `IHttpTraceContext` interface by using the `IHttpContext::GetTraceContext` method.  
  
2.  Retrieves the trace activity GUID by using the [IHttpTraceContext::GetTraceActivityId](../../web-development-reference/native-code-api-reference/ihttptracecontext-gettraceactivityid-method.md) method.  
  
3.  Creates a string that contains the trace activity GUID and writes the string to the Event Viewer.  
  
 [!code-cpp[IHttpContextGetTraceContext#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetTraceContext/cpp/IHttpContextGetTraceContext.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpServer::GetTraceContext Method](../../web-development-reference/native-code-api-reference/ihttpserver-gettracecontext-method.md)   
 [IHttpTraceContext Interface](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md)