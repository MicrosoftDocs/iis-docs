---
title: "IHttpFileMonitor Interface"
ms.date: "10/07/2016"
ms.assetid: d7385ff5-6b80-6604-72fc-822aa18fe453
---
# IHttpFileMonitor Interface
File change monitor.  
  
## Syntax  
  
```cpp  
class IHttpFileMonitor  
```  
  
## Methods  
 The following table lists the methods exposed by the `IHttpFileMonitor` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[DereferenceFileMonitor](../../web-development-reference\native-code-api-reference/ihttpfilemonitor-dereferencefilemonitor-method.md)|Releases a file monitor interface.|  
|[GetModuleContextContainer](../../web-development-reference\native-code-api-reference/ihttpfilemonitor-getmodulecontextcontainer-method.md)|Retrieves the module context container for a file monitor interface.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Remarks  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer::RegisterFileChangeMonitor Method](../../web-development-reference\native-code-api-reference/ihttpserver-registerfilechangemonitor-method.md)   
 [IGlobalFileChangeProvider::GetFileMonitor Method](../../web-development-reference\native-code-api-reference/iglobalfilechangeprovider-getfilemonitor-method.md)