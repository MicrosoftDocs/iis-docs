---
title: "IGlobalTraceEventProvider::GetTraceEvent Method"
ms.date: "10/07/2016"
ms.assetid: cefd0b4e-0eef-fe25-0242-87d496944a0c
---
# IGlobalTraceEventProvider::GetTraceEvent Method
Retrieves the trace event for the provider.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetTraceEvent(  
   OUT HTTP_TRACE_EVENT** ppTraceEvent  
) = 0;  
```  
  
### Parameters  
 `ppTraceEvent`  
 [OUT] A pointer to the address of an [HTTP_TRACE_EVENT](../../web-development-reference\native-code-api-reference/http-trace-event-structure.md) structure.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../web-development-reference\native-code-api-reference/request-processing-constants.md) event types receive an [IGlobalTraceEventProvider](../../web-development-reference\native-code-api-reference/iglobaltraceeventprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method. Clients will usually call the `GetTraceEvent` method on that pointer only if the [CheckSubscription](../../web-development-reference\native-code-api-reference/iglobaltraceeventprovider-checksubscription-method.md) method returns `true`.  
  
 `GetTraceEvent` behavior depends on implementation. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
 All `IGlobalTraceEventProvider` implementers declare a `private``HTTP_TRACE_EVENT` pointer and initialize that pointer during construction to shared `HTTP_TRACE_EVENT` data that is passed to the constructors. The `GetTraceEvent` call sets the dereferenced `ppTraceEvent` pointer to this `private` data and then always returns S_OK.  
  
## Notes for Implementers  
 `IGlobalTraceEventProvider` implementers are responsible for memory management with this data; therefore, `IGlobalTraceEventProvider` implementers that use dynamic memory allocation must release or call `delete` on the `HTTP_TRACE_EVENT` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IGlobalTraceEventProvider` implementers are responsible for memory management with this data; therefore, `IGlobalTraceEventProvider` clients must not release or call `delete` on the returned `HTTP_TRACE_EVENT` pointer when this data is no longer needed.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\native-code-api-reference/request-processing-constants.md) events and then writes the `IGlobalTraceEventProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [IGlobalTraceEventProvider#4](IGlobalTraceEventProvider#4)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider>  
    <traceEvent   
        area="0"   
        event="1"   
        eventVersion="1"   
        flags="1"   
        timeStamp="7394953"   
        verbosity="0"   
        activityGuid="{00000000-0000-0000-5D00-0080000000FB}"   
        areaGuid="{D42CF7EF-DE92-473E-8B6C-621EA663113A}"   
        providerGuid="{3A2A4E84-4C21-4981-AE10-3FDA0D9B0F83}"   
        relatedActivityGuid="NULL"   
        eventName="GENERAL_REQUEST_START"   
        eventItems="7">  
        <traceEventItems>  
            <traceEventItem   
                data="16"   
                traceType="HTTP_TRACE_TYPE_LPCGUID"   
                pbData="NULL"   
                description="NULL"   
                name="ContextId"/>  
            <traceEventItem   
                data="4"   
                traceType="HTTP_TRACE_TYPE_ULONG"   
                pbData="1"   
                description="NULL"   
                name="SiteId"/>  
            <traceEventItem   
                data="30"   
                traceType="HTTP_TRACE_TYPE_LPCWSTR"   
                pbData="DefaultAppPool"   
                description="NULL"   
                name="AppPoolId"/>  
            <traceEventItem   
                data="8"   
                traceType="HTTP_TRACE_TYPE_ULONGLONG"   
                pbData="92"   
                description="NULL"   
                name="ConnId"/>  
            <traceEventItem   
                data="8"   
                traceType="HTTP_TRACE_TYPE_ULONGLONG"   
                pbData="0"   
                description="NULL"   
                name="RawConnId"/>  
            <traceEventItem   
                data="48"   
                traceType="HTTP_TRACE_TYPE_LPCWSTR"   
                pbData="http://server:80/"   
                description="NULL"   
                name="RequestURL"/>  
            <traceEventItem   
                data="4"   
                    traceType="HTTP_TRACE_TYPE_LPCSTR"   
                    pbData="GET"   
                    description="NULL"   
                    name="RequestVerb"/>  
        </traceEventItems>  
    </traceEvent>  
</eventProvider>  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IGlobalTraceEventProvider Interface](../../web-development-reference\native-code-api-reference/iglobaltraceeventprovider-interface.md)