---
title: "HTTP_TRACE_EVENT_ITEM Structure"
ms.date: "10/07/2016"
ms.assetid: bed30d06-6c7c-34e9-2a31-8f9044a3445c
---
# HTTP_TRACE_EVENT_ITEM Structure
Contains itemized tracing information returned from trace providers.  
  
## Syntax  
  
```cpp  
struct HTTP_TRACE_EVENT_ITEM{  
   LPCWSTR pszName;  
   HTTP_TRACE_TYPE dwDataType;  
   PBYTE pbData;  
   DWORD cbData;  
   LPCWSTR pszDataDescription;  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`pszName`|A `LPCWSTR` that contains the name of the item, such as "RequestUrl".|  
|`dwDataType`|An [HTTP_TRACE_TYPE](../../web-development-reference/native-code-api-reference/http-trace-type-enumeration.md) that contains the data type pointed to by `pbData`.|  
|`pbData`|A `PBYTE` that contains the actual data that can be downcast (dependent on the value of `dwDataType`).|  
|`cbData`|A `DWORD` that contains the number of bytes pointed to by `pbData`.|  
|`pszDataDescription`|A `LPCWSTR` that contains an optional description of the data pointed to by `pbData`; otherwise, NULL.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference/native-code-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) event types receive an [IGlobalTraceEventProvider](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method. You can retrieve an [HTTP_TRACE_EVENT](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md) pointer by calling the [IGlobalTraceEventProvider::GetTraceEvent](../../web-development-reference/native-code-api-reference/iglobaltraceeventprovider-gettraceevent-method.md) method, for which you supply a pointer to the address of a NULL `HTTP_TRACE_EVENT` structure. You can then access each element in the `HTTP_TRACE_EVENT_ITEM` array by enumerating the [pEventItems](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md) field in the `HTTP_TRACE_EVENT` structure up to, but not including, the number of elements specified by the [cEventItems](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md) field.  
  
 The `pbData` field can be cast to more specific data, depending on the `dwDataType` field.  
  
> [!CAUTION]
>  Before performing any cast operation, always verify that the cast is correct to guarantee correct program behavior.  
  
> [!NOTE]
>  For program clarity, consider using the [reinterpret_cast](https://go.microsoft.com/fwlink/?LinkId=57573) or [static_cast](https://go.microsoft.com/fwlink/?LinkId=57557) operators whenever possible when you perform these casts.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference/native-code-api-reference/request-processing-constants.md) events and then writes the `HTTP_TRACE_EVENT_ITEM` information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
 [!code-cpp[Structs#3](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/Structs/cpp/HTTP_TRACE_EVENT_ITEM.cpp#3)]  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider>  
    <traceEvent>  
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
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httptrace.h|  
  
## See Also  
 [Web Server Core Structures](../../web-development-reference/native-code-api-reference/web-server-core-structures.md)