---
title: "IAppHostCollectionSchema::ClearElementSchema Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 26ff0624-64ae-f45e-8ec1-39104ee5deb4
caps.latest.revision: 7
author: "shirhatti"
manager: "wpickett"
---
# IAppHostCollectionSchema::ClearElementSchema Property
Gets the schema for the element that will be used to clear all items from the collection.  
  
## Syntax  
  
```cpp  
HRESULT get_ClearElementSchema(  
   [out,  
   retval] IAppHostElementSchema** ppSchema  
);  
```  
  
#### Parameters  
 `ppSchema`  
 A pointer to a pointer for an [IAppHostElementSchema](../../web-development-reference\native-code-api-reference/iapphostelementschema-interface.md) object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostCollectionSchema Interface](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-interface.md)