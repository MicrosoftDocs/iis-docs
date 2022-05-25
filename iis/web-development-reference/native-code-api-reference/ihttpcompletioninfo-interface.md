---
title: "IHttpCompletionInfo Interface"
description: IHttpCompletionInfo Interface provides information about an asynchronous completion.
ms.date: "10/07/2016"
ms.assetid: 3f6d645d-aa2e-1de3-610d-104d8b775a10
---
# IHttpCompletionInfo Interface
Provides information about an asynchronous completion.  
  
## Syntax  
  
```cpp  
class IHttpCompletionInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpCompletionInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetCompletionBytes](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionbytes-method.md)|Returns the number of bytes completed for an asynchronous operation.|  
|[GetCompletionStatus](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo-getcompletionstatus-method.md)|Returns the status of an asynchronous operation.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IHttpCompletionInfo2](../../web-development-reference/native-code-api-reference/ihttpcompletioninfo2-interface.md)|Provides an interface to get the number of bytes completed by an asynchronous operation.|  
  
## Remarks  
 An `IHttpCompletionInfo` interface is created and passed to a module's [CHttpModule::OnAsyncCompletion](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md) method when the module completes an asynchronous operation. The `GetCompletionBytes` and `GetCompletionStatus` methods, respectively, retrieve the number of bytes completed and the return the status of an asynchronous operation.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CHttpModule::OnAsyncCompletion Method](../../web-development-reference/native-code-api-reference/chttpmodule-onasynccompletion-method.md)
