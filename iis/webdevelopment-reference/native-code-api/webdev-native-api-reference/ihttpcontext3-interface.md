---
title: "IHttpContext3 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0d446756-92cf-4edb-a806-615829b55339
caps.latest.revision: 7
author: "shirhatti"
ms.author: "robmcm"
manager: "wpickett"
---
# IHttpContext3 Interface
Represents the reprocessing of an HTTP request and enables additional support for asynchronous operations.  
  
## Syntax  
  
```cpp  
class IHttpContext3 : public IHttpContext2  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpContext3` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetNamedContextContainer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-getnamedcontextcontainer-method.md)|Retrieves a container of named context objects.|  
|[EnableFullDuplex](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-enablefullduplex-method.md)|Enables an asynchronous full-duplex connection for this context.|  
|[InheritServerVariable](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-inheritservervariable-method.md)|Causes the request to inherit the specified server variable.|  
|[PostCompletion](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext3-postcompletion-method.md)|Posts the completion of the asynchronous operation.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpContext4](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext4-interface.md)|Represents the reprocessing of an HTTP request and enables additional support for diagnostic operations.|  
  
## Inheritance Hierarchy  
 [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)  
  
 [IHttpContext2](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext2-interface.md)  
  
 `IHttpContext3`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)