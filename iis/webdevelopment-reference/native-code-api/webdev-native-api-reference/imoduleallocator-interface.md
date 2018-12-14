---
title: "IModuleAllocator Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 1e5ba946-ff20-85a7-8be2-117a3bcea494
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
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
|[AllocateMemory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imoduleallocator-allocatememory-method.md)|Allocates a specified amount of memory.|  
  
## Remarks  
 IIS creates and passes an `IModuleAllocator` interface to the [GetHttpModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-gethttpmodule-method.md) method of an HTTP module's [IHttpModuleFactory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md) interface. You can use the [AllocateMemory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/imoduleallocator-allocatememory-method.md) method to allocate memory in the request's memory pool, instead of allocating memory on the heap.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)   
 [IHttpModuleFactory Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-interface.md)   
 [IHttpModuleFactory::GetHttpModule Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmodulefactory-gethttpmodule-method.md)