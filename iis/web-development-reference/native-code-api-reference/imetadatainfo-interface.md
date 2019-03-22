---
title: "IMetadataInfo Interface"
ms.date: "10/07/2016"
ms.assetid: a833d616-a815-b123-c943-df5af7c4025c
---
# IMetadataInfo Interface
Retrieves metadata information for the current context.  
  
## Syntax  
  
```cpp  
class IMetadataInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IMetadataInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetMetaPath](../../web-development-reference/native-code-api-reference/imetadatainfo-getmetapath-method.md)|Retrieves the configuration path for the current context.|  
|[GetModuleContextContainer](../../web-development-reference/native-code-api-reference/imetadatainfo-getmodulecontextcontainer-method.md)|Returns the context container for the metadata.|  
|[GetVrPath](../../web-development-reference/native-code-api-reference/imetadatainfo-getvrpath-method.md)|Retrieves the physical path for a virtual directory within the current context.|  
|[GetVrToken](../../web-development-reference/native-code-api-reference/imetadatainfo-getvrtoken-method.md)|Retrieves an [IHttpTokenEntry](../../web-development-reference/native-code-api-reference/ihttptokenentry-interface.md) interface for the impersonation account that is configured for a virtual directory.|  
  
## Derived Classes  
  
|Name|Description|  
|----------|-----------------|  
|[IReferencedMetadataInfo345258f4-4161-4f96-9ff1-2056d412d83b](../../web-development-reference/native-code-api-reference/ihttpserver2-interface.md)|Provides an interface for referencing and dereferencing context metadata.|  
  
## Remarks  
 Developers can use the `IMetadataInfo` interface to retrieve metadata-related configuration information.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)