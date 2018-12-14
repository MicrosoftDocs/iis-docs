---
title: "IHttpTraceContext::GetTraceConfiguration Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 57ac1397-e4e0-422c-af57-cd441981bce9
caps.latest.revision: 24
author: "shirhatti"
manager: "wpickett"
---
# IHttpTraceContext::GetTraceConfiguration Method
Returns the trace configuration for the trace context.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetTraceConfiguration(  
   IN OUT HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration  
) = 0;  
```  
  
#### Parameters  
 `pHttpTraceConfiguration`  
 [IN] [OUT] A pointer to an [HTTP_TRACE_CONFIGURATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-configuration-structure.md) structure that contains information for trace configuration.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Call the `GetTraceConfiguration` method to determine if an event consumer exists before you call the [RaiseTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-raisetraceevent-method.md) method.  
  
> [!NOTE]
>  While current [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) implementers return only S_OK from `GetTraceConfiguration`, you should test for success or failure by passing the returned `HRESULT` to the [SUCCEEDED](http://go.microsoft.com/fwlink/?LinkId=58226) or [FAILED](http://go.microsoft.com/fwlink/?LinkId=58235) macros, respectively, because the implementation may change.  
  
## Thread Safety  
 Most implementers of the [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) interface are thread safe if only the `GetTraceConfiguration` method is called. Calling the [SetTraceConfiguration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-settraceconfiguration-method.md) method is not guaranteed to be thread safe.  
  
## Notes for Implementers  
 Implementers of the `GetTraceConfiguration` method are responsible for copying any internal data into the `HTTP_TRACE_CONFIGURATION` structure, because callers are responsible for disposing of this data when it is no longer needed.  
  
## Notes for Callers  
 Callers to the `GetTraceConfiguration` method are responsible for disposing of any `HTTP_TRACE_CONFIGURATION` data and its fields when this data is no longer needed.  
  
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
 [IHttpTraceContext::SetTraceConfiguration Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-settraceconfiguration-method.md)