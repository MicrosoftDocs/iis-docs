---
title: "IWorkerProcessFramework::GetCustomInterface Method"
description: IWorkerProcessFramework::GetCustomInterface Method retrieves a custom interface from the worker process framework.
ms.date: "10/07/2016"
ms.assetid: c39f9e81-7186-b497-3d95-e44fe963a694
---
# IWorkerProcessFramework::GetCustomInterface Method
Retrieves a custom interface from the worker process framework.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetCustomInterface(  
   IN DWORD InterfaceId,  
   OUT PVOID* ppInterface  
) = 0;  
```  
  
### Parameters  
 `InterfaceId`  
 The ID of the interface to return.  
  
 `ppInterface`  
 A pointer to a buffer that will receive the interface specified by `InterfaceId`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Use the `GetCustomInterface` method to retrieve any interfaces that are not defined in the [WPF_INTERFACE_ID_ENUM](../../web-development-reference/native-code-api-reference/wpf-interface-id-enum-enumeration.md) enumeration and that may be exposed by the worker process framework. To retrieve interfaces from the worker process framework that are defined by `WPF_INTERFACE_ID_ENUM`, use the [IWorkerProcessFramework::GetWpfInterface](../../web-development-reference/native-code-api-reference/iworkerprocessframework-getwpfinterface-method.md) method.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IWorkerProcessFramework Interface](../../web-development-reference/native-code-api-reference/iworkerprocessframework-interface.md)   
 [IWorkerProcessFramework::GetInterfaceVersion Method](../../web-development-reference/native-code-api-reference/iworkerprocessframework-getinterfaceversion-method.md)   
 [IWorkerProcessFramework::GetWpfInterface Method](../../web-development-reference/native-code-api-reference/iworkerprocessframework-getwpfinterface-method.md)
