---
title: "IGlobalThreadCleanupProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 81fe1c2f-2088-0306-641b-00de09242675
---
# IGlobalThreadCleanupProvider Interface
Provides an interface for thread cleanup notifications.  
  
## Syntax  
  
```cpp  
class IGlobalThreadCleanupProvider : public IHttpEventProvider  
```  
  
## Methods  
 The following table lists the methods exposed by the `IGlobalThreadCleanupProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetApplication](../../web-development-reference/native-code-api-reference/iglobalthreadcleanupprovider-getapplication.md)|Retrieves an [IHttpApplication](../../web-development-reference/native-code-api-reference/ihttpapplication-interface.md) interface.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
 IIS creates and passes an `IGlobalThreadCleanupProvider` interface to a module's [CGlobalModule::OnGlobalThreadCleanup](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalthreadcleanup-method.md) method when the module has registered for the [GL_THREAD_CLEANUP](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  
 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalThreadCleanupProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
 [CGlobalModule::OnGlobalThreadCleanup Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalthreadcleanup-method.md)
