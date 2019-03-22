---
title: "IHttpServer2 Interface"
ms.date: "10/07/2016"
ms.assetid: 73ed3784-2b56-46f5-9b73-c2f47600f298
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
|[GetAppPoolConfigFile](../../web-development-reference/native-code-api-reference/ihttpserver2-getapppoolconfigfile-method.md)|Retrieves the path of the application pool’s configuration file.|  
|[GetExtendedInterface](../../web-development-reference/native-code-api-reference/ihttpserver2-getextendedinterface-method.md)|Retrieves the correct down-casted pointer based on version GUID (globally unique identifier) values.|  
|[GetMetadata](../../web-development-reference/native-code-api-reference/ihttpserver2-getmetadata-method.md)|Retrieves metadata about a website given its name and URL.|  
|[GetToken](../../web-development-reference/native-code-api-reference/ihttpserver2-gettoken-method.md)|Retrieves an authentication token given a user name, password, and login method.|  
|[GetWorkerProcessFramework](../../web-development-reference/native-code-api-reference/ihttpserver2-getworkerprocessframework-method.md)|Retrieves the interface of the worker process framework for the server.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpServer](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)  
  
 `IHttpServer2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)