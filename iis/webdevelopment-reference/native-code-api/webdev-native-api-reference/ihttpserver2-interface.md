---
title: "IHttpServer2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 73ed3784-2b56-46f5-9b73-c2f47600f298
caps.latest.revision: 5
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer2 Interface
Represents the processing context for global-level operations, and enables retrieving configuration files, extended interfaces, metadata, tokens, and the worker process framework.  
  
## Syntax  
  
```cpp  
class IHttpServer2 : public IHttpServer  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpServer2` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAppPoolConfigFile](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-getapppoolconfigfile-method.md)|Retrieves the path of the application pool’s configuration file.|  
|[GetExtendedInterface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-getextendedinterface-method.md)|Retrieves the correct down-casted pointer based on version GUID (globally unique identifier) values.|  
|[GetMetadata](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-getmetadata-method.md)|Retrieves metadata about a website given its name and URL.|  
|[GetToken](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-gettoken-method.md)|Retrieves an authentication token given a user name, password, and login method.|  
|[GetWorkerProcessFramework](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver2-getworkerprocessframework-method.md)|Retrieves the interface of the worker process framework for the server.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpServer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)  
  
 `IHttpServer2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)