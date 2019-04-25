---
title: "HTTP_TRACE_CONFIGURATION Structure"
ms.date: "10/07/2016"
ms.assetid: 933a2496-8b0a-256c-e75f-b0a461b58d20
---
# HTTP_TRACE_CONFIGURATION Structure
Contains tracing information for use with trace providers and consumers.  
  
## Syntax  
  
```cpp  
struct HTTP_TRACE_CONFIGURATION{  
   LPCGUID pProviderGuid;  
   DWORD dwAreas;  
   DWORD dwVerbosity;  
   BOOL fProviderEnabled;  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`pProviderGuid`|An `LPCGUID` that represents the unique identifier for the provider.|  
|`dwAreas`|A `DWORD` that contains a bitmask that defines the specific areas to trace. This list of areas is private, but a value of 0xffffe will enable tracing for all areas.|  
|`dwVerbosity`|A `DWORD` that maps numerical values to their verbose counterparts (the values 0 through 5 map to General, FatalError, Error, Warning, Info, and Verbose).|  
|`fProviderEnabled`|`true` if `pProviderGuid` is initialized to a valid current value; otherwise, `false`.|  
  
## Remarks  
 You can call the [IHttpTraceContext::GetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-gettraceconfiguration-method.md) method to read or write an `HTTP_TRACE_CONFIGURATION` pointer as an IN/OUT parameter, or you can call the [IHttpTraceContext::SetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md) method to read an `HTTP_TRACE_CONFIGURATION` pointer as an IN parameter only. When a trace consumer calls `SetTraceConfiguration`, the `HTTP_TRACE_CONFIGURATION` pointer provides the specific areas to trace to an [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) interface.  
  
> [!NOTE]
>  This list of areas is private, but a value of 0xffffe will enable tracing for all areas.  
  
 The `HTTP_TRACE_CONFIGURATION` pointer also returns information about tracing from a `GetTraceConfiguration` call.  
  
 Before you call `SetTraceConfiguration`, verify that the `HTTP_TRACE_CONFIGURATION` pointer and all of its members are initialized. Before you call `GetTraceConfiguration`, verify that the `pProviderGuid` member is initialized to a valid current value; otherwise, the `fProviderEnabled` member will be set to `false`, and `IHttpTraceContext` implementers will immediately return.  
  
 See [IIS Tracing Constants](../../web-development-reference/native-code-api-reference/tracing-constants.md) for defined GUID values that can be assigned to the `pProviderGuid` member.  
  
> [!CAUTION]
>  Because implementers are required to set only the `fProviderEnabled` member during a call to `GetTraceConfiguration`, you should access the remaining members after the method call only if `fProviderEnabled` is `true`; otherwise, these remaining members will be unchanged and invalid.  
  
> [!NOTE]
> You should initialize all fields to known values before calling either the `SetTraceConfiguration` or `GetTraceConfiguration` methods, because the implementation may change.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the [HTTP_TRACE_CONFIGURATION](../../web-development-reference/native-code-api-reference/http-trace-configuration-structure.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[Structs#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/Structs/cpp/HTTP_TRACE_CONFIGURATION.cpp#1)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <traceContext>  
        <traceConfiguration   
            providerGuid="{00000000-0000-0000-1B00-0080000000FF}"   
            areas="0"   
            verbosity="0"   
            providerEnabled="true"/>  
    </traceContext>  
</cacheProvider>  
```  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httptrace.h|  
  
## See Also  
 [Web Server Core Structures](../../web-development-reference/native-code-api-reference/web-server-core-structures.md)