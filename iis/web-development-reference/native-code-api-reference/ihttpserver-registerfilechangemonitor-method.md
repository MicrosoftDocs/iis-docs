---
title: "IHttpServer::RegisterFileChangeMonitor Method"
ms.date: "10/07/2016"
ms.assetid: 609b619c-3713-c9c5-85c4-07d615ac6970
---
# IHttpServer::RegisterFileChangeMonitor Method

Registers file-change notification for a particular directory.  
  
## Syntax  
  
```cpp  
virtual HRESULT RegisterFileChangeMonitor(  
   PCWSTR pszPath,  
   HANDLE hToken,  
   IHttpFileMonitor** ppFileMonitor  
) = 0;  
```  
  
### Parameters  

 `pszPath`  
 The directory path to monitor.  
  
 `hToken`  
 An optional token to use for monitoring registration.  
  
 `ppFileMonitor`  
 The monitoring object that should be released when it is no longer needed. This action may stop file-change monitoring.  
  
## Return Value  

 An HRESULT.  
  
## Remarks  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|
