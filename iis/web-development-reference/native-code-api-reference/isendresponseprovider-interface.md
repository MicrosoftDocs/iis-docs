---
title: "ISendResponseProvider Interface"
description: This article describes the ISendResponseProvider interface and provides the syntax, methods, and requirements.
ms.date: "10/07/2016"
ms.assetid: bbb207ee-d0ce-5b67-a12e-e0c1085a5f01
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
|[GetFlags](../../web-development-reference/native-code-api-reference/isendresponseprovider-getflags-method.md)|Retrieves the flags for the current HTTP response.|  
|[GetHeadersBeingSent](../../web-development-reference/native-code-api-reference/isendresponseprovider-getheadersbeingsent-method.md)|Retrieves a value that indicates whether the HTTP headers are being returned.|  
|[GetLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-getlogdata-method.md)|Retrieves the logging information for the current response.|  
|[GetReadyToLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-getreadytologdata-method.md)|Retrieves a value that indicates whether IIS is ready to write information to the logs.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
|[SetFlags](../../web-development-reference/native-code-api-reference/isendresponseprovider-setflags-method.md)|Configures the flags for the current HTTP response.|  
|[SetLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-setlogdata-method.md)|Configures logging information for the current response.|  
  
## Remarks  
 An `ISendResponseProvider` interface is created and passed to a module's [CHttpModule::OnSendResponse](../../web-development-reference/native-code-api-reference/chttpmodule-onsendresponse-method.md) method when the module has registered for the [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `ISendResponseProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)
