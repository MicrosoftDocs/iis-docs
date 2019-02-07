---
title: "IPmCustomActions2 Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 20ec2a31-666e-43de-b0a1-be2bd98f9ba6
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
---
# IPmCustomActions2 Interface
Enables the worker process to register and unregister custom actions that will result in multiple responses.  
  
## Syntax  
  
```cpp  
class IPmCustomActions2 : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IPmCustomActions` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IPmCustomActions2::RegisterCustomActionCallback](../../web-development-reference\native-code-api-reference/ipmcustomactions2-registercustomactioncallback-method.md)|Registers a custom callback method for actions that will result in multiple responses.|  
|[IPmCustomActions2::UnregisterCustomActionCallback](../../web-development-reference\native-code-api-reference/ipmcustomactions2-unregistercustomactioncallback-method.md)|Unregisters the specified custom action callback method.|  
|[AddRef](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[Release](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md).)|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `IPmCustomActions2`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference\native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)