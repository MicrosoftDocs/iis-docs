---
title: "HTTP_TRACE_EVENT Structure | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3e72fafd-2422-eb83-1e1f-4359f65ff06e
caps.latest.revision: 36
author: "shirhatti"
manager: "wpickett"
---
# HTTP_TRACE_EVENT Structure
Contains tracing information returned from trace providers.  
  
## Syntax  
  
```cpp  
struct HTTP_TRACE_EVENT{  
   LPCGUID pProviderGuid;  
   DWORD dwArea;  
   LPCGUID pAreaGuid;  
   DWORD dwEvent;  
   LPCWSTR pszEventName;  
   DWORD dwEventVersion;  
   DWORD dwVerbosity;  
   LPCGUID pActivityGuid;  
   LPCGUID pRelatedActivityGuid;  
   DWORD dwTimeStamp;  
   DWORD dwFlags;  
   DWORD cEventItems;  
   __field_ecount(cEventItems) HTTP_TRACE_EVENT_ITEM * pEventItems;  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`pProviderGuid`|An `LPCGUID` that contains the identifier of the provider. Possible values include, but are not limited to, the values in the Tracing GUIDs section defined in [Tracing Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/tracing-constants.md).|  
|`dwArea`|A `DWORD` that contains the area of interest for the event. The area value should be a positive integer.|  
|`pAreaGuid`|A `LPCGUID` that indicates the area of interest.|  
|`dwEvent`|A `DWORD` that contains the unique identifier of the event for the event provider.|  
|`pszEventName`|A `LPCWSTR` that contains the name of the event. This value is set by the event provider to give a description of the event type.|  
|`dwEventVersion`|A `DWORD` that contains the event version. Usually 0 or 1, but can contain any nonnegative integer value.|  
|`dwVerbosity`|A `DWORD` that maps numerical values to their verbose counterparts (the values 0 through 5 map to General, FatalError, Error, Warning, Info, and Verbose).|  
|`pActivityGuid`|A `LPCGUID` that contains the unique request identifier.|  
|`pRelatedActivityGuid`|A `LPCGUID` that contains a value for associating related activities. Most providers set this value to NULL and then allow IIS to populate the value before sending the event to event listeners.|  
|`dwTimeStamp`|A `DWORD` that contains the optional time stamp, represented by an internal tick count.|  
|`dwFlags`|A `DWORD` that contains additional flags. Most providers set this value to HTTP_TRACE_EVENT_FLAG_STATIC_DESCRIPTIVE_FIELDS, described in the Tracing Constants section defined in [Tracing Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/tracing-constants.md).|  
|`cEventItems`|A `DWORD` that contains the number of elements in the `pEventItems` array.|  
|`pEventItems`|An array of [HTTP_TRACE_EVENT_ITEM Structure](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/http-trace-event-item-structure.md) structures of length `cEventItems`.|  
  
## Remarks  
 Most of the members of the `HTTP_TRACE_EVENT` structure map directly to Event Tracing for Windows (ETW) events. The `dwArea` and `pAreaGuid` members are unique to IIS.  
  
 [CGlobalModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) event types receive an [IGlobalTraceEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method. You can then retrieve an `HTTP_TRACE_EVENT` pointer by calling the [IGlobalTraceEventProvider::GetTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iglobaltraceeventprovider-gettraceevent-method.md) method, for which you supply a pointer to the address of a NULL `HTTP_TRACE_EVENT` structure.  
  
 For more information, see [Tracing Constants](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/tracing-constants.md).  
  
 The `dwArea` and `pAreaGuid` members contain two different constants for the area of interest for an event.  
  
## Example  
 The following example populates the `HTTP_TRACE_EVENT` structure and calls the [IHttpTraceContext::RaiseTraceEvent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttptracecontext-raisetraceevent-method.md) method.  
  
<!-- TODO: review snippet reference  [!CODE [_RaiseEvnt#2](_RaiseEvnt#2)]  -->  
<!-- TODO: review snippet reference [!CODE [_RaiseEvnt#3](_RaiseEvnt#3)]  -->  
  
 If failed-request tracing is properly configured, you will see the `NOTIFY_MODULE_START` and `NOTIFY_MODULE_END` events in the trace log. For more information about logging failed requests, see [Configuring Tracing for Failed Requests in IIS 7.0](http://go.microsoft.com/fwlink/?LinkId=99788). The XML below is the `NOTIFY_MODULE_START` portion of the Failed Request Tracing log. Most of the data is system dependent and will not match the event below.  
  
```  
   <Event xmlns="http://schemas.microsoft.com/win/2004/08/events/event">  
 <System>  
  <Provider Name="WWW Server" Guid="{3A2A4E84-4C21-4981-AE10-3FDA0D9B0F83}"/>  
  <EventID>0</EventID>  
  <Version>1</Version>  
  <Level>5</Level>  
  <Opcode>1</Opcode>  
  <Keywords>0x100</Keywords>  
  <TimeCreated SystemTime="2007-08-27T21:10:30.186Z"/>  
  <Correlation ActivityID="{00000000-0000-0000-9800-0080000000FA}"/>  
  <Execution ProcessID="1308" ThreadID="3608"/>  
  <Computer>N2-IIS</Computer>  
 </System>  
 <EventData>  
  <Data Name="ContextId">{00000000-0000-0000-9800-0080000000FA}</Data>  
  <Data Name="ModuleName">A_raizeEvent</Data>  
  <Data Name="Notification">1</Data>  
  <Data Name="fIsPostNotification">false</Data>  
  <Data Name="fIsCompletion">false</Data>  
 </EventData>  
 <RenderingInfo Culture="en-US">  
  <Opcode>NOTIFY_MODULE_START</Opcode>  
  <Keywords>  
   <Keyword>RequestNotifications</Keyword>  
  </Keywords>  
  <freb:Description Data="Notification">BEGIN_REQUEST</freb:Description>  
 </RenderingInfo>  
 <ExtendedTracingInfo xmlns="http://schemas.microsoft.com/win/2004/08/events/trace">  
  <EventGuid>{002E91E3-E7AE-44AB-8E07-99230FFA6ADE}</EventGuid>  
 </ExtendedTracingInfo>  
</Event>  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httptrace.h|  
  
## See Also  
 [Web Server Core Structures](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-structures.md)