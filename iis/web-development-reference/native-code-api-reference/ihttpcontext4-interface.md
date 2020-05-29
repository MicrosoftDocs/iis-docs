---
title: "IHttpContext4 Interface"
ms.date: "10/07/2016"
ms.assetid: fbb3e3e5-8063-41ab-a5e5-e00d63955682
ms.author: "robmcm"
---
# IHttpContext4 Interface
Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.  
  
## Syntax  
  
```  
class IHttpContext4 : public IHttpContext3  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpContext4` class  
  
|Name|Description|  
|----------|-----------------|  
|[GetRequestElapsedTime](../../web-development-reference/native-code-api-reference/ihttpcontext4-getrequestelapsedtime-method.md)|Retrieves the elapsed time of the request in milliseconds.|  
|[GetRequestStartTime](../../web-development-reference/native-code-api-reference/ihttpcontext4-getrequeststarttime-method.md)|Retrieves the start time of the request in milliseconds.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpContext](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)  
  
 [IHttpContext2](../../web-development-reference/native-code-api-reference/ihttpcontext2-interface.md)  
  
 [IHttpContext3](../../web-development-reference/native-code-api-reference/ihttpcontext3-interface.md)  
  
 `IHttpContext4`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Product|IIS 10.0|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
