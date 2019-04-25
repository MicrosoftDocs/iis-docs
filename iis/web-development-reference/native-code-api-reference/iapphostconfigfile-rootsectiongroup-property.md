---
title: "IAppHostConfigFile::RootSectionGroup Property"
ms.date: "10/07/2016"
ms.assetid: 573e8780-9720-d1ae-4876-8d3d1d106aae
---
# IAppHostConfigFile::RootSectionGroup Property
Returns the root configuration section group for the current configuration file.  
  
## Syntax  
  
```cpp  
HRESULT get_RootSectionGroup(  
   [out,  
   retval] IAppHostSectionGroup** ppSectionGroups  
);  
```  
  
### Parameters  
 `ppSectionGroups`  
 A pointer to a pointer for an [IAppHostSectionGroup](../../web-development-reference/native-code-api-reference/iapphostsectiongroup-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Example  
 The following code example demonstrates how to use the root section group to access the configuration system. The sample assumes that you have registered the `mySectionGroup` section group and `myNewSection` section name in the section table and configuration schema.  
  
 [!code-cpp[IAppHostAdminLibrary#8](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostSectionGroupGetItem.cpp#8)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigFile Interface](../../web-development-reference/native-code-api-reference/iapphostconfigfile-interface.md)