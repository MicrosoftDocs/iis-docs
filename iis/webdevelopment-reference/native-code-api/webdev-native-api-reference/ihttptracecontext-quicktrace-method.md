---
title: "IHttpTraceContext::QuickTrace Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: a0d43e55-a773-4f55-ae09-33b451adfe4b
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IHttpTraceContext::QuickTrace Method
Writes a message to the IIS trace log.  
  
## Syntax  
  
```cpp  
virtual  
    HRESULT  
    QuickTrace(  
        IN PCWSTR   pszData1,  
        IN PCWSTR   pszData2 = NULL,  
        IN HRESULT  hrLastError = S_OK,  
        IN UCHAR    Level = 4  
    ) = 0;  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|`pszData1`|A message to log.|  
|`pszData2`|A second message to log.|  
|`hrLastError`|The `HRESULT` to log. The default is S_OK.|  
|`level`|The trace level. The possible values are 1 through 7. The default is 4 (TRACE_LEVEL_INFORMATION). For more information, see the Remarks section.|  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Event trace levels 1 through 5 correspond to Event Tracing for Windows (ETW) trace levels. For more information about these trace levels, see the [EVENT_TRACE_HEADER](http://go.microsoft.com/fwlink/?LinkId=102211) structure. You can also use trace level 6 (defined as HTTP_TRACE_LEVEL_START in the Httptrace.h header file) and trace level 7 (defined as HTTP_TRACE_LEVEL_END in Httptrace.h).  
  
## Example  
 The following example demonstrates how to use the [IHttpRequest::SetUrl](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-seturl-method.md) method to change a requested URL to another URL and log the change with the `QuickTrace` method.  
  
 You must enable Failed Event Request tracing to see the event.  
  
<!-- TODO: review snippet reference  [!CODE [_GPR#1](_GPR#1)]  -->  
<!-- TODO: review snippet reference [!CODE [_GPR#2](_GPR#2)]  -->  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestSetHttpMethod#1](IHttpRequestSetHttpMethod#1)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|