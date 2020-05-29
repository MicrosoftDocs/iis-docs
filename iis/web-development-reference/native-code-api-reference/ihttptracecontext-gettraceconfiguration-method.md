---
title: "IHttpTraceContext::GetTraceConfiguration Method"
ms.date: "10/07/2016"
ms.assetid: 57ac1397-e4e0-422c-af57-cd441981bce9
---
# IHttpTraceContext::GetTraceConfiguration Method
Returns the trace configuration for the trace context.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetTraceConfiguration(  
   IN OUT HTTP_TRACE_CONFIGURATION* pHttpTraceConfiguration  
) = 0;  
```  
  
### Parameters  
 `pHttpTraceConfiguration`  
 [IN] [OUT] A pointer to an [HTTP_TRACE_CONFIGURATION](../../web-development-reference/native-code-api-reference/http-trace-configuration-structure.md) structure that contains information for trace configuration.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Call the `GetTraceConfiguration` method to determine if an event consumer exists before you call the [RaiseTraceEvent](../../web-development-reference/native-code-api-reference/ihttptracecontext-raisetraceevent-method.md) method.  
  
> [!NOTE]
>  While current [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) implementers return only S_OK from `GetTraceConfiguration`, you should test for success or failure by passing the returned `HRESULT` to the [SUCCEEDED](https://go.microsoft.com/fwlink/?LinkId=58226) or [FAILED](https://go.microsoft.com/fwlink/?LinkId=58235) macros, respectively, because the implementation may change.  
  
## Thread Safety  
 Most implementers of the [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) interface are thread safe if only the `GetTraceConfiguration` method is called. Calling the [SetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md) method is not guaranteed to be thread safe.  
  
## Notes for Implementers  
 Implementers of the `GetTraceConfiguration` method are responsible for copying any internal data into the `HTTP_TRACE_CONFIGURATION` structure, because callers are responsible for disposing of this data when it is no longer needed.  
  
## Notes for Callers  
 Callers to the `GetTraceConfiguration` method are responsible for disposing of any `HTTP_TRACE_CONFIGURATION` data and its fields when this data is no longer needed.  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTraceContext Interface](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md)   
 [IHttpTraceContext::SetTraceConfiguration Method](../../web-development-reference/native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md)
