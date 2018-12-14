---
title: "IHttpTraceContext::SetTraceConfiguration Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d625426f-a634-4ff0-98b7-91ddeb6d9e8d
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IHttpTraceContext::SetTraceConfiguration Method
Sets the trace configuration for the trace context.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetTraceConfiguration(  
   IN HTTP_MODULE_ID moduleId,  
   IN HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration,  
   IN DWORD cHttpTraceConfiguration = 1  
) = 0;)  
```  
  
#### Parameters  
 `moduleId`  
 [IN] An `HTTP_MODULE_ID` pointer that contains the module identifier for the trace configuration.  
  
 `pHttpTraceConfiguration`  
 [IN] An array of [HTTP_TRACE_CONFIGURATION](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-configuration-structure.md) structures of length `cHttpTraceConfiguration`.  
  
 `cHttpTraceConfiguration`  
 [IN] A `DWORD` that contains the number of `HTTP_TRACE_CONFIGURATION` structures pointed to by `pHttpTraceConfiguration`. The default is 1.  
  
> [!NOTE]
>  `HTTP_MODULE_ID` is a type definition of a `void` pointer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_FAIL|Indicates that the operation failed.|  
|E_OUTOFMEMORY|Indicates that an internal `new` operation returned NULL because the heap memory is exhausted.|  
|ERROR_INVALID_PARAMETER|Indicates that the `HTTP_TRACE_CONFIGURATION::pProviderGuid` property for the `pHttpTraceConfiguration` parameter is NULL.|  
|ERROR_NOT_FOUND|Indicates that an attempt to disable tracing occurred for a provider that does not exist.|  
  
## Remarks  
 Neither the `moduleId` nor the `pHttpTraceConfiguration` parameter can be NULL; otherwise, the `SetTraceConfiguration` method will cause an access violation.  
  
## Thread Safety  
 Most implementers of the [IHttpTraceContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md) interface are thread safe if only the [GetTraceConfiguration](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-gettraceconfiguration-method.md) method is called. Calling the `SetTraceConfiguration` method is not guaranteed to be thread safe.  
  
### Comments  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTraceContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-interface.md)