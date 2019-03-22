---
title: "Tracing Constants"
ms.date: "10/07/2016"
ms.assetid: 03514e54-e634-49d2-ac3f-08866fca03ee
---
# Tracing Constants
This topic describes the constants that are defined in the Httptrace.h header file.  
  
## Tracing Constants  
  
|Constant|Bitmask|Description|  
|--------------|-------------|-----------------|  
|HTTP_TRACE_EVENT_FLAG_STATIC_DESCRIPTIVE_FIELDS|0x01|If the `dwFlags` member of an [HTTP_TRACE_EVENT](../../web-development-reference/native-code-api-reference/http-trace-event-structure.md) structure is set to this value, indicates that the `pProviderGuid`, `pAreaGuid`, and `pszEventName` members of that structure, as well as the `pszName` and `pszDescription` members in each [HTTP_TRACE_EVENT_ITEM](../../web-development-reference/native-code-api-reference/http-trace-event-item-structure.md) element of that structure, are `static`. In this case, the memory for all of these members is available and immutable for the lifetime of the process and, therefore, does not ever need to be copied.|  
  
## Tracing GUIDs  
 The following constants are used with the [IHttpTraceContext::SetTraceConfiguration](../../web-development-reference/native-code-api-reference/ihttptracecontext-settraceconfiguration-method.md) method. Verify that a module includes the Initguid.h file when you use these GUIDs.  
  
|Constant|GUID|Description|  
|--------------|----------|-----------------|  
|GUID_IIS_ALL_TRACE_PROVIDERS|{00000000-0000-0000-0000-000000000000}|Indicates that a module listens for events from all providers.|  
|GUID_IIS_WWW_SERVER_TRACE_PROVIDER|{3A2A4E84-4C21-4981-AE10-3FDA0D9B0F83}|Indicates that a module listens for events from only the provider for World Wide Web (WWW) server tracing.|  
|GUID_IIS_ASPNET_TRACE_PROVIDER|{AFF081FE-0247-4275-9C4E-021F3DC1DA35}|Indicates that a module listens for events from only the provider for [!INCLUDE[vstecasp](../../wmi-provider/includes/vstecasp-md.md)] tracing.|  
|GUID_IIS_ASP_TRACE_TRACE_PROVIDER|{06B94D9A-B15E-456E-A4Ef-37C984A2CB4B}|Indicates that a module listens for events from only the provider for ASP tracing.|  
|GUID_IIS_WWW_GLOBAL_TRACE_PROVIDER|{D55D3BC9-CBA9-44DF-827E-132D3A4596C2}|Indicates that a module listens for events from only the provider for global tracing.|  
|GUID_IIS_ISAPI_TRACE_PROVIDER|{A1C2040E-8840-4C31-BA11-9871031A19EA}|Indicates that a module listens for events from only the provider for ISAPI tracing.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httptrace.h|  
  
## See Also  
 [Web Server Core Constants](../../web-development-reference/native-code-api-reference/web-server-core-constants.md)   
 [Creating Native-Code HTTP Modules](../../web-development-reference/native-code-development-overview/creating-native-code-http-modules.md)