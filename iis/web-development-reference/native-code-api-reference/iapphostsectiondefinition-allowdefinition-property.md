---
title: "IAppHostSectionDefinition::AllowDefinition Property"
ms.date: "10/07/2016"
ms.assetid: 1b17e521-76e4-4b7b-c891-b771a83ccd6c
---
# IAppHostSectionDefinition::AllowDefinition Property
Gets or sets a value that indicates valid configuration path locations for the configuration section.  
  
## Syntax  
  
```cpp  
HRESULT get_AllowDefinition(  
   [out,  
   retval] BSTR* pbstrAllowDefinition  
);  
HRESULT put_AllowDefintion(  
   BSTR bstrAllowDefinition  
);  
```  
  
### Parameters  
 `pbstrAllowDefinition`  
 A pointer to a `BSTR` that indicates a configuration path location. Valid values are "Everywhere", "MachineToApplication", "MachineOnly", "MachineToWebRoot", and "AppHostOnly". The default is "Everywhere".  
  
 `bstrAllowDefinition`  
 A `BSTR` that indicates a configuration path location. Valid values are "Everywhere", "MachineToApplication", "MachineOnly", "MachineToWebRoot", and "AppHostOnly"  
  
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
 [IAppHostSectionDefinition Interface](../../web-development-reference/native-code-api-reference/iapphostsectiondefinition-interface.md)