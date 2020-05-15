---
title: "IGlobalTraceEventProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 2566adb1-eb89-6944-4724-f78f5277acf8
---
# IGlobalTraceEventProvider Interface

Extends the [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md) interface by providing trace events for [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes.  
  
## Syntax  
  
```cpp  
class IGlobalTraceEventProvider : public IHttpEventProvider  
```  
  
## Methods  

 The following table lists the methods exposed by the `IGlobalTraceEventProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[CheckSubscription](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-checksubscription-method.md)|Returns a value that indicates whether the trace event is intended for the module.|  
|[GetCurrentHttpRequestContext](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-getcurrenthttprequestcontext-method.md)|Retrieves the HTTP context for trace events that are request specific.|  
|[GetTraceEvent](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-gettraceevent-method.md)|Retrieves the trace event for the provider.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  

 This class contains no derived classes.  
  
## Remarks  

 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event types receive an `IGlobalTraceEventProvider` pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method.  
  
## Example  

 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `IGlobalTraceEventProvider` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[IGlobalTraceEventProvider#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IGlobalTraceEventProvider/cpp/IGlobalTraceEventProvider.cpp#1)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider subscription="true">  
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
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Inheritance Hierarchy  

 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalTraceEventProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
