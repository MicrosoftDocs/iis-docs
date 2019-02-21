---
title: "IWpfApplicationPreloadUtil Interface"
ms.date: "10/07/2016"
ms.assetid: 180fa728-36d1-4753-8e6a-23b71ced97c8
---
# IWpfApplicationPreloadUtil Interface
Exposes helper functions that return preload information (such as site ID) for an application and report preload failures.  
  
## Syntax  
  
```cpp  
class IWpfApplicationPreloadUtil : public IWpfReferencedObject  
```  
  
## Methods  
 The following table lists the methods exposed by the `IWpfApplicationPreloadUtil` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[IWpfApplicationPreloadUtil::GetApplicationPreloadInfo](../../web-development-reference\native-code-api-reference/iwpfapplicationpreloadutil-getapplicationpreloadinfo-method.md)|Returns preload information (such as site ID and virtual path) for an application given the path to its configuration file.|  
|[IWpfApplicationPreloadUtil::ReportApplicationPreloadFailure](../../web-development-reference\native-code-api-reference/iwpfapplicationpreloadutil-reportapplicationpreloadfailure-method.md)|Reports an application preload failure given the path to the configuration file, failure code, and error string.|  
|[IWpfReferencedObject::AddRef](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-addref-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md).)|  
|[IWpfReferencedObject::Release](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-release-method.md)|(Inherited from [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md).)|  
  
## Inheritance Hierarchy  
 [IWpfReferencedObject](../../web-development-reference\native-code-api-reference/iwpfreferencedobject-interface.md)  
  
 `IWpfApplicationInfoUtil`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [Worker Process and Protocol Manager Interfaces](../../web-development-reference\native-code-api-reference/worker-process-and-protocol-manager-interfaces.md)