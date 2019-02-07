---
title: "IAppHostElementSchema::GetMetadata Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 0fcf6c69-5a84-8721-7a31-b2b2d8cefc0f
caps.latest.revision: 11
author: "shirhatti"
manager: "wpickett"
---
# IAppHostElementSchema::GetMetadata Method
Gets metadata values from the element schema.  
  
## Syntax  
  
```cpp  
HRESULT GetMetadata(  
   [in,  
   string] BSTR bstrMetadataType,  
   [out,  
   retval] VARIANT* pValue  
);  
```  
  
#### Parameters  
 `bstrMetadataType`  
 A `BSTR` that contains the name of the metadata being requested.  
  
 `pValue`  
 A pointer to a `VARIANT` that contains the value of the requested metadata.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_NOT_SUPPORTED|Indicates that the metadata is not recognized.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostElementSchema Interface](../../web-development-reference\webdev-native-api-reference/iapphostelementschema-interface.md)   
 [IAppHostElement::GetMetadata Method](../../web-development-reference\webdev-native-api-reference/iapphostelement-getmetadata-method.md)   
 [IAppHostPropertySchema::GetMetadata Method](../../web-development-reference\webdev-native-api-reference/iapphostpropertyschema-getmetadata-method.md)   
 [IAppHostProperty::GetMetadata Method](../../web-development-reference\webdev-native-api-reference/iapphostproperty-getmetadata-method.md)   
 [IAppHostAdminManager::GetMetadata Method](../../web-development-reference\webdev-native-api-reference/iapphostadminmanager-getmetadata-method.md)