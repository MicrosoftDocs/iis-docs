---
title: "IReferencedMetadataInfo Interface"
ms.date: "10/07/2016"
ms.assetid: 345258f4-4161-4f96-9ff1-2056d412d83b
---
# IReferencedMetadataInfo Interface
Provides an interface for referencing and dereferencing context metadata.  
  
## Syntax  
  
```cpp  
class IReferencedMetadataInfo : public IMetadataInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IReferencedMetadataInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[ReferenceMetadata](../../web-development-reference/native-code-api-reference/ireferencedmetadatainfo-referencemetadata-method.md)|References the metadata of the current context for later retrieval.|  
|[DereferenceMetadata](../../web-development-reference/native-code-api-reference/ireferencedmetadatainfo-dereferencemetadata-method.md)|Releases the referenced context metadata.|  
  
## Derived Classes  
 This interface contains no derived classes.  
  
## Inheritance Hierarchy  
 [IMetadataInfo](../../web-development-reference/native-code-api-reference/imetadatainfo-interface.md)  
  
 `IReferencedMetadataInfo`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference/native-code-api-reference/web-server-core-interfaces.md)
