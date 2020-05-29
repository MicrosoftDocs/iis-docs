---
title: "IHttpTraceContext Interface"
ms.date: "10/07/2016"
ms.assetid: 2bd121f6-32df-4f18-9cad-b83b82dd61e2
---
# IHttpTraceContext Interface
Provides a request-wide method for modules to raise events into the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] tracing infrastructure.  
  
## Syntax  
  
```cpp  
class IHttpTraceContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpTraceContext` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetTraceActivityId](../../web-development-reference/native-code-api-reference/ihttptracecontext-gettraceactivityid-method.md)|Returns the trace activity identifier for the trace context.|  
|[GetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-gettraceconfiguration-method.md)|Returns the trace configuration for the trace context.|  
|[QuickTrace](../../web-development-reference/native-code-api-reference/ihttptracecontext-quicktrace-method.md)|Writes a message to the IIS trace log.|  
|[RaiseTraceEvent](../../web-development-reference/native-code-api-reference/ihttptracecontext-raisetraceevent-method.md)|Raises a trace event for the trace context.|  
|[SetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md)|Sets the trace configuration for the trace context.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 To implement tracing, a module will generally call the [IHttpContext::GetTraceContext](../../web-development-reference/native-code-api-reference/ihttpcontext-gettracecontext-method.md) method to get the `IHttpTraceContext` interface, and then call the `RaiseTraceEvent` method.  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
