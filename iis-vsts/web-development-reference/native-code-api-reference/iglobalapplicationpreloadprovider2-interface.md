---
title: "IGlobalApplicationPreloadProvider2 Interface"
ms.date: "10/07/2016"
ms.assetid: d9f95de2-db90-4f28-b6ba-d37b9d7972bf
---
# IGlobalApplicationPreloadProvider2 Interface
Provides information about whether an application’s worker process is recycled.  
  
## Syntax  
  
```cpp  
class IGlobalApplicationPreloadProvider2 : public IGlobalApplicationPreloadProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalApplicationPreloadProvider2` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IsProcessRecycled](../../web-development-reference\native-code-api-reference/iglobalapplicationpreloadprovider2-isprocessrecycled-method.md)|Indicates whether the application’s worker process has recycled.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference\native-code-api-reference/ihttpeventprovider-interface.md)  
  
 [IGlobalApplicationPreloadProvider](../../web-development-reference\native-code-api-reference/iglobalapplicationpreloadprovider-interface.md)  
  
 `IGlobalApplicationPreloadProvider2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)