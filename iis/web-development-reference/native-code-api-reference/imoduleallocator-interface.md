---
title: "IModuleAllocator Interface"
ms.date: "10/07/2016"
ms.assetid: 1e5ba946-ff20-85a7-8be2-117a3bcea494
---
# IModuleAllocator Interface
Allocates memory within the current request's memory pool.  
  
## Syntax  
  
```cpp  
class IModuleAllocator  
```  
  
## Methods  
 The following table lists the methods exposed by the `IModuleAllocator` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[AllocateMemory](../../web-development-reference/native-code-api-reference/imoduleallocator-allocatememory-method.md)|Allocates a specified amount of memory.|  
  
## Remarks  
 IIS creates and passes an `IModuleAllocator` interface to the [GetHttpModule](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md) method of an HTTP module's [IHttpModuleFactory](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md) interface. You can use the [AllocateMemory](../../web-development-reference/native-code-api-reference/imoduleallocator-allocatememory-method.md) method to allocate memory in the request's memory pool, instead of allocating memory on the heap.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)   
 [IHttpModuleFactory Interface](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-interface.md)   
 [IHttpModuleFactory::GetHttpModule Method](../../web-development-reference/native-code-api-reference/ihttpmodulefactory-gethttpmodule-method.md)