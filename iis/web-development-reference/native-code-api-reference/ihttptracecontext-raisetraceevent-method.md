---
title: "IHttpTraceContext::RaiseTraceEvent Method"
description: "Describes the IHttpTraceContext::RaiseTraceEvent method and details its syntax, parameters, return value, remarks, and requirements."
ms.date: 10/07/2016
ms.assetid: 51a59c9b-7685-42ee-bab9-21d1938931f3
---
# IHttpTraceContext::RaiseTraceEvent Method
Raises a trace event for the trace context.  
  
## Syntax  
  
```cpp  
virtual HRESULT RaiseTraceEvent(  
   IN HTTP_TRACE_EVENT* pTraceEvent   
) = 0;  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`pTraceEvent`|An [HTTP_TRACE_EVENT](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md) pointer that contains trace event information.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_FAIL|Indicates that the operation failed.|  
|E_OUTOFMEMORY|Indicates that heap memory is exhausted.|  
  
## Remarks  
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
