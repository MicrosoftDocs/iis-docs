---
title: "PFN_WEB_CORE_SHUTDOWN Function"
ms.date: "10/07/2016"
ms.assetid: da54f34a-f01e-4242-9902-824e276e23d8
---
# PFN_WEB_CORE_SHUTDOWN Function
Shuts down an instance of the Hosted Web Core.  
  
## Syntax  
  
```cpp  
typedef HRESULT (*PFN_WEB_CORE_SHUTDOWN)(  
   IN DWORD fImmediate  
);  
```  
  
### Parameters  
 `fImmediate`  
 A `DWORD` that specifies whether the shutdown should be immediate or graceful.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_SERVICE_NOT_ACTIVE|Indicates that the Hosted Web Core is not running.|  
|ERROR_INVALID_SERVICE_CONTROL|Indicates that a shutdown is already in progress.|  
|ERROR_SERVICE_REQUEST_TIMEOUT|Indicates that a graceful shutdown was requested but was not able to complete in the time period specified by the `ShutdownTimeLimit` setting in the configuration file.|  
  
## Remarks  
 The `PFN_WEB_CORE_SHUTDOWN` function is a prototype for the `WebCoreShutdown` DLL entry point in Hwebcore.dll that is used to shut down the Hosted Web Core. The hosting process may choose to shut down the Hosted Web Core either gracefully or immediately. If the hosting process chooses a graceful shutdown, the Hosted Web Core will stop receiving new requests and wait for any currently executing requests to finish based on the time period specified by the `ShutdownTimeLimit` setting in the configuration file for the application pool.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Hwebcore.h|  
  
## See Also  
 [Hosted Web Core API Reference](../../web-development-reference/native-code-api-reference/hosted-web-core-api-reference.md)
 [PFN_WEB_CORE_ACTIVATE Function](../../web-development-reference/native-code-api-reference/pfn-web-core-activate-function.md)
