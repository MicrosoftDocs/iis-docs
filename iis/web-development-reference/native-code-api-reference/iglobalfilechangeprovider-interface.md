---
title: "IGlobalFileChangeProvider Interface"
ms.date: "10/07/2016"
ms.assetid: 14f8fe14-2950-0618-b7b0-bb930c5e8c60
---
# IGlobalFileChangeProvider Interface

Provides a global-level interface for [GL_FILE_CHANGE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notifications.  
  
## Syntax  
  
```cpp  
class IGlobalFileChangeProvider : public IHttpEventProvider  
```  
  
## Methods  

 The following table lists the methods exposed by the `IGlobalFileChangeProvider` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetFileMonitor](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-getfilemonitor-method.md)|Returns an [IHttpFileMonitor](../../web-development-reference/native-code-api-reference/ihttpfilemonitor-interface.md) file-change monitor.|  
|[GetFileName](../../web-development-reference/native-code-api-reference/iglobalfilechangeprovider-getfilename-method.md)|Retrieves the full path to a file that has been changed.|  
|[SetErrorStatus](../../web-development-reference/native-code-api-reference/ihttpeventprovider-seterrorstatus-method.md)|(Inherited from [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md).)|  
  
## Derived Classes  

 This interface contains no derived classes.  
  
## Remarks  

 An `IGlobalFileChangeProvider` interface is created and passed to a module's [CGlobalModule::OnGlobalFileChange](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md) method when the module has registered for the `GL_FILE_CHANGE` notification in the module's exported [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function.  
  
## Inheritance Hierarchy  

 [IHttpEventProvider](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)  
  
 `IGlobalFileChangeProvider`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  

 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [CGlobalModule::OnGlobalFileChange Method](../../web-development-reference/native-code-api-reference/cglobalmodule-onglobalfilechange-method.md)   
 [IHttpEventProvider Interface](../../web-development-reference/native-code-api-reference/ihttpeventprovider-interface.md)   
 [PFN_REGISTERMODULE Function](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md)
