---
title: "IAppHostSectionDefinition::OverrideModeDefault Property"
ms.date: "10/07/2016"
ms.assetid: bd9ee475-e075-2771-d242-60683aca8b0f
---
# IAppHostSectionDefinition::OverrideModeDefault Property
Gets or sets the default override behavior for the current configuration section.  
  
## Syntax  
  
```cpp  
HRESULT get_OverrideModeDefault(  
   [out,  
   retval] BSTR* pbstrOverrideModeDefault  
);  
HRESULT put_OverrideModeDefault(  
   BSTR bstrOverrideModeDefault  
);
```  
  
### Parameters  
 `pbstrOverrideModeDefault`  
 A pointer to a `BSTR` that indicates the default override behavior. Valid values are "Allow" and "Deny".  
  
 `bstrOverrideModeDefault`  
 A `BSTR` that indicates the default override behavior. Valid values are "Allow" and "Deny".  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 If you do not explicitly set the value of this property, the default is "Allow". "Allow" specifies that settings can be overridden in lower levels of configuration; "Deny" specifies that settings cannot be overridden.  
  
## Description  
 The following code example creates a new section group and a new section, and then sets the `OverrideModeDefault` property value of the newly generated section to "Deny".  
  
## Code  
 [!code-cpp[IAppHostAdminLibrary#7](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostSectionGroupAddSectionGroup.cpp#7)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionDefinition Interface](../../web-development-reference/native-code-api-reference/iapphostsectiondefinition-interface.md)
