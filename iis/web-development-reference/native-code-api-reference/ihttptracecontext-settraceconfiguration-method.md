---
title: "IHttpTraceContext::SetTraceConfiguration Method"
ms.date: "10/07/2016"
ms.assetid: d625426f-a634-4ff0-98b7-91ddeb6d9e8d
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
  
### Parameters  
 `moduleId`  
 [IN] An `HTTP_MODULE_ID` pointer that contains the module identifier for the trace configuration.  
  
 `pHttpTraceConfiguration`  
 [IN] An array of [HTTP_TRACE_CONFIGURATION](../../web-development-reference/native-code-api-reference/http-trace-configuration-structure.md) structures of length `cHttpTraceConfiguration`.  
  
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
 Most implementers of the [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) interface are thread safe if only the [GetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-gettraceconfiguration-method.md) method is called. Calling the `SetTraceConfiguration` method is not guaranteed to be thread safe.  
  
### Comments  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpTraceContext Interface](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md)
