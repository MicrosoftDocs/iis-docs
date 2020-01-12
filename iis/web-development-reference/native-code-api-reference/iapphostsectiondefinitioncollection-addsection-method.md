---
title: "IAppHostSectionDefinitionCollection::AddSection Method"
ms.date: "10/07/2016"
ms.assetid: d6515912-4d1b-f956-ae6b-80576da89e4a
---
# IAppHostSectionDefinitionCollection::AddSection Method
Adds a new configuration section definition to the collection.  
  
## Syntax  
  
```cpp  
HRESULT AddSection(  
   [in,  
   string] BSTR bstrSectionName,  
   [out,  
   retval] IAppHostSectionDefinition** ppConfigSection  
);  
```  
  
### Parameters  
 `bstrSectionName`  
 A `BSTR` that specifies the name of the configuration section definition to be added.  
  
 `ppConfigSection`  
 A pointer to a pointer for the newly created [IAppHostSectionDefinition](../../web-development-reference/native-code-api-reference/iapphostsectiondefinition-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example creates a new section group and a new section, and then sets the property values of the newly generated section.  
  
 [!code-cpp[IAppHostAdminLibrary#6](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostPropertySetValue.cpp#6)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionDefinitionCollection Interface](../../web-development-reference/native-code-api-reference/iapphostsectiondefinitioncollection-interface.md)