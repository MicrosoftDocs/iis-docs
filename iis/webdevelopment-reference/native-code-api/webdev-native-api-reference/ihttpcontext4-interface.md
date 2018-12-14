---
title: "IHttpContext4 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fbb3e3e5-8063-41ab-a5e5-e00d63955682
caps.latest.revision: 3
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
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
|[GetRequestElapsedTime](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext4-getrequestelapsedtime-method.md)|Retrieves the elapsed time of the request in milliseconds.|  
|[GetRequestStartTime](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext4-getrequeststarttime-method.md)|Retrieves the start time of the request in milliseconds.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)  
  
 [IHttpContext2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext2-interface.md)  
  
 [IHttpContext3](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-interface.md)  
  
 `IHttpContext4`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Product|IIS 10.0|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)