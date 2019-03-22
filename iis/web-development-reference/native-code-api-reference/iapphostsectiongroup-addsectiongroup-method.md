---
title: "IAppHostSectionGroup::AddSectionGroup Method"
ms.date: "10/07/2016"
ms.assetid: 20245f26-f649-fb6e-56ac-c319d0c1512c
---
# IAppHostSectionGroup::AddSectionGroup Method
Adds a new nested configuration section group under the current configuration section group.  
  
## Syntax  
  
```cpp  
HRESULT AddSectionGroup(  
   [in,  
   string] BSTR bstrSectionGroupName,  
   [out,  
   retval] IAppHostSectionGroup** ppSectionGroup  
);  
```  
  
### Parameters  
 `bstrSectionGroupName`  
 A `BSTR` that contains the name of the new section group to add.  
  
 `ppSectionGroup`  
 A pointer to a pointer for the newly created [IAppHostSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example creates a new section group and a new section, and then sets the property values of the newly generated section.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#6](IAppHostAdminLibrary#6)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostSectionGroup Interface](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md)