---
title: "ICacheProvider::GetTraceContext Method"
ms.date: "10/07/2016"
ms.assetid: 82947c97-727f-455e-b773-9fa952194dc3
---
# ICacheProvider::GetTraceContext Method
Returns the trace context for the cache provider.  
  
## Syntax  
  
```cpp  
virtual IHttpTraceContext* GetTraceContext(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 An [IHttpTraceContext](../../web-development-reference/native-code-api-reference/ihttptracecontext-interface.md) pointer.  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_CACHE_OPERATION](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events receive an [ICacheProvider](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalCacheOperation](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalcacheoperation-method.md)`virtual` method. You can retrieve an `IHttpTraceContext` pointer by calling the `GetTraceContext` method on the `ICacheProvider` pointer.  
  
## Notes for Implementers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` implementers that use dynamic memory allocation must release or call `delete` on the `IHttpTraceContext` pointer when it is no longer needed.  
  
## Notes for Callers  
 `ICacheProvider` implementers are responsible for memory management with this data; therefore, `ICacheProvider` clients must not release or call `delete` on the returned `IHttpTraceContext` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for `GL_CACHE_OPERATION` and [GL_CACHE_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IHttpTraceContext` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[ICacheProvider#5](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ICacheProvider/cpp/GetTraceContext.cpp#5)]  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 The above code writes a new event to the application log of the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<cacheProvider>  
    <traceContext
        activityId=  
           "{00000000-0000-0000-2400-0080000000FB}">  
        <traceConfiguration
            providerGuid="NULL"
            areas="0"
            verbosity="0"
            providerEnabled="false"/>  
    </traceContext>  
</cacheProvider>  
```  
  
 You can optionally compile the code by using the __`stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ICacheProvider Interface](../../web-development-reference/native-code-api-reference/icacheprovider-interface.md)
