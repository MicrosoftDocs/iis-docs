---
title: "IReferencedMetadataInfo::ReferenceMetadata Method"
ms.date: "10/07/2016"
ms.assetid: 6c58b484-dbec-4fc2-9625-40b35ec86ce9
---
# IReferencedMetadataInfo::ReferenceMetadata Method
References the metadata of the current context for later retrieval.  
  
## Syntax  
  
```cpp  
virtual VOID ReferenceMetadata(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 This method returns no values.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IReferencedMetadataInfo Interface](../../web-development-reference/native-code-api-reference/ireferencedmetadatainfo-interface.md)