---
title: "IAppHostSectionDefinition::OverrideModeDefault Property | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bd9ee475-e075-2771-d242-60683aca8b0f
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#7](IAppHostAdminLibrary#7)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionDefinition Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostsectiondefinition-interface.md)