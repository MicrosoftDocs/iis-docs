---
title: "IHttpConnectionStoredContext Interface"
ms.date: "10/07/2016"
description: IHttpConnectionStoredContext interface defines context information for connection-stored data.
ms.assetid: f6a67d77-c255-4c59-9f05-a65552534dee
---
# IHttpConnectionStoredContext Interface
Defines context information for connection-stored data.  
  
## Syntax  
  
```cpp  
IHttpConnectionStoredContext : public IHttpStoredContext  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpConnectionStoredContext` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[NotifyDisconnect](../../web-development-reference/native-code-api-reference/ihttpconnectionstoredcontext-notifydisconnect.md)|Notifies the caller that an established connection was disconnected.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IHttpStoredContext](../../web-development-reference/native-code-api-reference/ihttpstoredcontext-interface.md)  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|
