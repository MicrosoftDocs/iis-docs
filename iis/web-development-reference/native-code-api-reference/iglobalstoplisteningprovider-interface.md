---
title: "IGlobalStopListeningProvider Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c0fc5a79-ccca-77d2-421d-0da4cec63f78
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# IGlobalStopListeningProvider Interface
Provides an interface for notifications that indicate whether a worker process is shutting down and will stop listening for new requests.  
  
## Syntax  
  
```cpp  
class IGlobalStopListeningProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalStopListeningProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[DrainRequestsGracefully](../../web-development-reference\native-code-api-reference/iglobalstoplisteningprovider-drainrequestsgracefully-method.md)|Indicates whether IIS will gracefully close any currently pending requests.|  
|[SetErrorStatus](../../web-development-reference\native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 IIS creates and passes an `IGlobalStopListeningProvider` interface to a module's [CGlobalModule::OnGlobalStopListening](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalstoplistening-method.md) method when the module has registered for the [GL_STOP_LISTENING](../../web-development-reference\native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalStopListeningProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalStopListening Method](../../web-development-reference\native-code-api-reference/cglobalmodule-onglobalstoplistening-method.md)