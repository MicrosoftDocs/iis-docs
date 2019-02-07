---
title: "HTTP_TRACE_TYPE Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f93c5c26-edf9-4577-5ff1-6a3491e1ff84
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# HTTP_TRACE_TYPE Enumeration
Determines what data type the [HTTP_TRACE_EVENT_ITEM](../../web-development-reference\webdev-native-api-reference/http-trace-event-item-structure.md) structure maintains.  
  
## Syntax  
  
```cpp  
enum HTTP_TRACE_TYPE{  
   HTTP_TRACE_TYPE_BYTE = 17,  
   HTTP_TRACE_TYPE_USHORT = 18,  
   HTTP_TRACE_TYPE_ULONG = 19,  
   HTTP_TRACE_TYPE_ULONGLONG = 21,  
   HTTP_TRACE_TYPE_CHAR = 16,  
   HTTP_TRACE_TYPE_SHORT = 2,  
   HTTP_TRACE_TYPE_LONG = 3,  
   HTTP_TRACE_TYPE_LONGLONG = 20,  
   HTTP_TRACE_TYPE_LPCWSTR = 31,  
   HTTP_TRACE_TYPE_LPCSTR = 30,  
   HTTP_TRACE_TYPE_LPCGUID = 72,  
   HTTP_TRACE_TYPE_BOOL = 11,  
};  
```  
  
## Members  
  
|Member name|Description|  
|-----------------|-----------------|  
|`HTTP_TRACE_TYPE_BYTE`|Indicates that the data type is a `BYTE`. Maps to the Managed Object Format (MOF) type `uint8`.|  
|`HTTP_TRACE_TYPE_USHORT`|Indicates that the data type is an `unsigned short`. Maps to the MOF type `uint16`.|  
|`HTTP_TRACE_TYPE_ULONG`|Indicates that the data type is an `unsigned long`. Maps to the MOF type `uint32`.|  
|`HTTP_TRACE_TYPE_ULONGLONG`|Indicates that the data type is an `unsigned long long`. Maps to the MOF type `uint64`.|  
|`HTTP_TRACE_TYPE_CHAR`|Indicates that the data type is a `char`. Maps to the MOF type `int8`.|  
|`HTTP_TRACE_TYPE_SHORT`|Indicates that the data type is a `short`. Maps to the MOF type `int16`.|  
|`HTTP_TRACE_TYPE_LONG`|Indicates that the data type is a `long`. Maps to the MOF type `int32`.|  
|`HTTP_TRACE_TYPE_LONGLONG`|Indicates that the data type is a `long long`. Maps to the MOF type `int64`.|  
|`HTTP_TRACE_TYPE_LPCWSTR`|Indicates that the data type is an `LPCWSTR`. Maps to the MOF type `w`.|  
|`HTTP_TRACE_TYPE_LPCSTR`|Indicates that the data type is an `LPCSTR`. Maps to the MOF type `a`.|  
|`HTTP_TRACE_TYPE_LPCGUID`|Indicates that the data type is an `LPCGUID`. Maps to the MOF type `Guid`.|  
|`HTTP_TRACE_TYPE_BOOL`|Indicates that the data type is a `BOOL`. Maps to the MOF type `boolean`.|  
  
## Remarks  
 [CGlobalModule](../../web-development-reference\webdev-native-api-reference/cglobalmodule-class.md) derived classes that register for [GL_TRACE_EVENT](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) event types receive an [IGlobalTraceEventProvider](../../web-development-reference\webdev-native-api-reference/iglobaltraceeventprovider-interface.md) pointer as a parameter on the [CGlobalModule::OnGlobalTraceEvent](../../web-development-reference\webdev-native-api-reference/cglobalmodule-onglobaltraceevent-method.md) pure `virtual` method. You can then retrieve an [HTTP_TRACE_EVENT](../../web-development-reference\webdev-native-api-reference/http-trace-event-structure.md) array by calling the [IGlobalTraceEventProvider::GetTraceEvent](../../web-development-reference\webdev-native-api-reference/iglobaltraceeventprovider-gettraceevent-method.md) method, for which you supply a dereferenced pointer to a NULL `HTTP_TRACE_EVENT` structure.  
  
 You access each element in the `HTTP_TRACE_EVENT_ITEM` array by enumerating the [pEventItems](../../web-development-reference\webdev-native-api-reference/http-trace-event-structure.md) field in the `HTTP_TRACE_EVENT` structure up to, but not including, the number of elements specified by the [cEventItems](../../web-development-reference\webdev-native-api-reference/http-trace-event-structure.md) field. You then access the `HTTP_TRACE_TYPE` through the [dwDataType](../../web-development-reference\webdev-native-api-reference/http-trace-event-item-structure.md) data field in the `HTTP_TRACE_EVENT_ITEM` structure.  
  
## Example  
 The following code example demonstrates how to create a global module that listens for [GL_TRACE_EVENT](../../web-development-reference\webdev-native-api-reference/request-processing-constants.md) events and then writes the [HTTP_TRACE_TYPE](../../web-development-reference\webdev-native-api-reference/http-trace-type-enumeration.md) information to the Event Viewer.  
  
> [!CAUTION]
>  [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] generates a large number of events in the Event Viewer. To avoid a log overflow error in a production environment, you should generally avoid writing cache information to the event log. For demonstration purposes, this code example writes an entry to the Event Viewer in debug mode only.  
  
<!-- TODO: review snippet reference  [!CODE [Enumerations#2](Enumerations#2)]  -->  
  
 The above code writes a new event to the Event Viewer, where the Data box contains XML similar to the following.  
  
```  
<eventProvider>  
    <traceEvent>  
        <traceEventItems>  
            <traceEventItem>  
                traceType="HTTP_TRACE_TYPE_LPCGUID"   
                pbData="NULL"   
            </traceEventItem>  
        </traceEventItems>  
    </traceEvent>  
</eventProvider>  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httptrace.h|  
  
## See Also  
 [Web Server Core Enumerations](../../web-development-reference\webdev-native-api-reference/web-server-core-enumerations.md)