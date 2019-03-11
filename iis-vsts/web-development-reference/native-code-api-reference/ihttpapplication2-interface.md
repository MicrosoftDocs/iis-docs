---
title: "IHttpApplication2 Interface"
ms.date: "10/07/2016"
ms.assetid: 0247aaa4-3854-405c-b8a8-40cb39c75866
---
# IHttpApplication2 Interface
Provides an interface for loading a Web application into server memory and initializing it before the first HTTP request arrives.  
  
## Syntax  
  
```cpp  
class IHttpApplication2 : public IHttpApplication  
```  
  
## Methods  
 The following table lists the methods exposed by the  interface.  
  
|Name|Description|  
|----------|-----------------|  
|BeginApplicationWarmup|Starts loading the application into server memory and initializing it before the first HTTP request arrives.|  
|EndApplicationWarming|Ends the application warm up process.|  
|QuaryIsWarmingUp|Indicates whether the application is in the process of warming up.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpApplication](../../web-development-reference\native-code-api-reference/ihttpapplication-interface.md)  
  
 `IHttpApplication2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)