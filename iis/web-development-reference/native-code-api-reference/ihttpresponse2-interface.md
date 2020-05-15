---
title: "IHttpResponse2 Interface"
ms.date: "10/07/2016"
ms.assetid: 926ab657-fabb-4523-8f1e-c372f6871f8a
---
# IHttpResponse2 Interface

Provides an interface for flushing data and writing entity data chunks for asynchronous operations.  
  
## Syntax  
  
```cpp  
class IHttpResponse2 : public IHttpResponse  
```  
  
## Methods  

 The following table lists the methods exposed by the `IHttpResponse2` interface.  
  
|Name|Description|  
|----------|-----------------|  
|Flush|Sends all currently buffered output of an asynchronous operation to the client.|  
|WriteEntityChunks|Appends one or more [HTTP_DATA_CHUNK](https://go.microsoft.com/fwlink/?LinkId=56011) structures to the response body for an asynchronous operation.|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Inheritance Hierarchy  

 [IHttpResponse](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)  
  
 `IHttpResponse2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
