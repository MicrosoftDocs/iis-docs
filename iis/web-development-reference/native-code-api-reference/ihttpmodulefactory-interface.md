---
title: "IHttpModuleFactory Interface"
ms.date: "10/07/2016"
ms.assetid: 4b5ff315-35f8-c4e7-9581-562e71517a78
---
# IHttpModuleFactory Interface
Manages the creation of a [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class.  
  
## Syntax  
  
```cpp  
class IHttpModuleFactory  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpModuleFactory` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetHttpModule](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md)|Creates an instance of a [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class.|  
|[Terminate](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-terminate-method.md)|Terminates an `IHttpModuleFactory` interface.|  
  
## Remarks  
 When you create an HTTP module, you must provide an implementation of an `IHttpModuleFactory` interface. Your exported [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function will use this module factory to create an instance of your [CHttpModule](../../web-development-reference\native-code-api-reference/chttpmodule-class.md) class and to remove your `IHttpModuleFactory` interface from memory.  
  
 Your interface must provide two methods, [GetHttpModule](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md) and [Terminate](../../web-development-reference\native-code-api-reference/ihttpmodulefactory-terminate-method.md). Your module will use these two methods, respectively, to create your `CHttpModule` class instance and to unload itself from memory.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)   
 [CHttpModule Class](../../web-development-reference\native-code-api-reference/chttpmodule-class.md)