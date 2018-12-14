---
title: "ISendResponseProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bbb207ee-d0ce-5b67-a12e-e0c1085a5f01
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
---
# ISendResponseProvider Interface
Retrieves or modifies information about the current response.  
  
## Syntax  
  
```cpp  
class ISendResponseProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `ISendResponseProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetFlags](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getflags-method.md)|Retrieves the flags for the current HTTP response.|  
|[GetHeadersBeingSent](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getheadersbeingsent-method.md)|Retrieves a value that indicates whether the HTTP headers are being returned.|  
|[GetLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getlogdata-method.md)|Retrieves the logging information for the current response.|  
|[GetReadyToLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getreadytologdata-method.md)|Retrieves a value that indicates whether IIS is ready to write information to the logs.|  
|[SetErrorStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md).)|  
|[SetFlags](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setflags-method.md)|Configures the flags for the current HTTP response.|  
|[SetLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setlogdata-method.md)|Configures logging information for the current response.|  
  
## Remarks  
 An `ISendResponseProvider` interface is created and passed to a module's [CHttpModule::OnSendResponse](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/chttpmodule-onsendresponse-method.md) method when the module has registered for the [RQ_SEND_RESPONSE](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)  
  
 `ISendResponseProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IHttpEventProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpeventprovider-interface.md)