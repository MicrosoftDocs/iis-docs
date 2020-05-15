---
title: "IProtocolManager::Shutdown Method"
ms.date: "10/07/2016"
ms.assetid: 845ce040-066f-7d89-84c7-363d144f681c
---
# IProtocolManager::Shutdown Method

Shuts down a protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT Shutdown(  
   IN BOOL fImmediate  
) = 0;  
```  
  
### Parameters  

 `fImmediate`  
 `true` to indicates that the shutdown should be immediate; otherwise, `false`.  
  
## Return Value  

 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  

 The `Shutdown` method is called by a worker process when it is shutting down; other applications should not call `Shutdown`. A worker process may have interdependent protocol managers, and calling the `Shutdown` method for a protocol manager may create a shutdown conflict. This can occur, for example, when a protocol manager cannot shut down because it depends on another protocol manager that is attempting to shut down. In turn, that second protocol manager cannot shut down due to a dependency on the original protocol manager that cannot shut down.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  

 [IProtocolManager Interface](../../web-development-reference/native-code-api-reference/iprotocolmanager-interface.md)   
 [IProtocolManager::GetCustomInterface Method](../../web-development-reference/native-code-api-reference/iprotocolmanager-getcustominterface-method.md)   
 [IProtocolManager::GetPmInterface Method](../../web-development-reference/native-code-api-reference/iprotocolmanager-getpminterface-method.md)
