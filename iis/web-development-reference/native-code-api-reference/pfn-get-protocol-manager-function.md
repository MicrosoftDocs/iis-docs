---
title: "PFN_GET_PROTOCOL_MANAGER Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ba896f3b-16b3-441e-b362-5c796e76f662
caps.latest.revision: 16
author: "shirhatti"
manager: "wpickett"
---
# PFN_GET_PROTOCOL_MANAGER Function
Defines the default entry point of the dynamic-link library (DLL) that allows worker processes to instantiate the [IProtocolManager](../../web-development-reference\native-code-api-reference/iprotocolmanager-interface.md).  
  
## Syntax  
  
```cpp  
typedef HRESULT (*PFN_GET_PROTOCOL_MANAGER)(  
   IN IWorkerProcessFramework* pWpFramework,  
   OUT IProtocolManager** ppProtocolManager  
);  
```  
  
#### Parameters  
 `pWpFramework`  
 The calling [IWorkerProcessFramework](../../web-development-reference\native-code-api-reference/iworkerprocessframework-interface.md) instance.  
  
 `ppProtocolManager`  
 The returned `IProtocolManager` instance.  
  
## Return Value  
 An `HRESULT`.  
  
## Remarks  
 `ppProtocolManager` is non-NULL only if the returned `HRESULT` is nonzero.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process Framework API Reference](../../web-development-reference\native-code-api-reference/worker-process-framework-api-reference.md)