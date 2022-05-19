---
title: ICustomAction2ResultCallback Interface
description: Describes the ICustomAction2ResultCallback interface and details its syntax, methods, inheritance hierarchy, and requirements.
ms.date: 10/07/2016
ms.assetid: 51616d49-1f8a-4379-8dd3-8520c846b185
---
# ICustomAction2ResultCallback Interface
Reports the results of a `RegisterCustomAction` or `UnregisterCustomAction` operation that was requested by the [IPmCustomActions2](../../web-development-reference/native-code-api-reference/ipmcustomactions2-interface.md) interface.  
  
## Syntax  
  
```cpp  
class ICustomAction2ResultCallback : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `ICustomAction2ResultCallback` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[ICustomAction2ResultCallback::ReportResult](../../web-development-reference/native-code-api-reference/icustomaction2resultcallback-reportresult-method.md)|Returns the results of a `RegisterCustomAction` or `UnregisterCustomAction` operation.|  
|[IWpfReferencedObject::AddRef](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[IWpfReferencedObject::Release](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md).)|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference/native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `ICustomActionResultCallback`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference/native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)
