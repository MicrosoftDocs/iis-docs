---
title: "IHttpTraceContext Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2bd121f6-32df-4f18-9cad-b83b82dd61e2
caps.latest.revision: 32
author: "shirhatti"
manager: "wpickett"
---
# IHttpTraceContext Interface
Provides a request-wide method for modules to raise events into the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] tracing infrastructure.  
  
## Syntax  
  
```cpp  
class IHttpTraceContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpTraceContext` class.  
  
|Name|Description|  
|----------|-----------------|  
|[GetTraceActivityId](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-gettraceactivityid-method.md)|Returns the trace activity identifier for the trace context.|  
|[GetTraceConfiguration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-gettraceconfiguration-method.md)|Returns the trace configuration for the trace context.|  
|[QuickTrace](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-quicktrace-method.md)|Writes a message to the IIS trace log.|  
|[RaiseTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-raisetraceevent-method.md)|Raises a trace event for the trace context.|  
|[SetTraceConfiguration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-settraceconfiguration-method.md)|Sets the trace configuration for the trace context.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 To implement tracing, a module will generally call the [IHttpContext::GetTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-gettracecontext-method.md) method to get the `IHttpTraceContext` interface, and then call the `RaiseTraceEvent` method.  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)