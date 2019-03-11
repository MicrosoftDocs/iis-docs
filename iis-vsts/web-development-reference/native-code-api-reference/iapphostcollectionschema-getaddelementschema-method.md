---
title: "IAppHostCollectionSchema::GetAddElementSchema Method"
ms.date: "10/07/2016"
ms.assetid: 40da661f-b646-932b-b54a-2f38b4229bfd
---
# IAppHostCollectionSchema::GetAddElementSchema Method
Gets the schema for the `add` element that has the requested name.  
  
## Syntax  
  
```cpp  
HRESULT GetAddElementSchema(  
   [in,  
   string] BSTR bstrElementName,  
   [out,  
   retval] IAppHostElementSchema** ppSchema  
);  
```  
  
### Parameters  
 `bstrElementName`  
 A `BSTR` that contains the name of the element.  
  
 `ppSchema`  
 A pointer to a pointer for an [IAppHostElementSchema](../../web-development-reference\native-code-api-reference/iapphostelementschema-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_INDEX|Indicates that the `bstrElementName` was not found.|  
  
## Remarks  
 The `GetAddElementSchema` method returns the schema for an `add` element that matches the `bstrElementName`.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostCollectionSchema::IsMergeAppend Property](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-ismergeappend-property.md)   
 [IAppHostCollectionSchema Interface](../../web-development-reference\native-code-api-reference/iapphostcollectionschema-interface.md)