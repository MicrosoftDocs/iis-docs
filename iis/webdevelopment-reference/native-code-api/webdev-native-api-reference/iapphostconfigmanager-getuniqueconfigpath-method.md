---
title: "IAppHostConfigManager::GetUniqueConfigPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f4f189e2-0977-dae4-7e84-8a9b79cefab9
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
---
# IAppHostConfigManager::GetUniqueConfigPath Method
Gets a unique configuration path that represents the deepest path where configuration is defined.  
  
## Syntax  
  
```cpp  
HRESULT GetUniqueConfigPath(  
   [in,  
   string] BSTR bstrConfigPath,  
   [out,  
   retval,  
   string] BSTR* pbstrUniquePath  
);  
```  
  
#### Parameters  
 `bstrConfigPath`  
 A `BSTR` that contains a requested configuration path.  
  
 `pbstrUniquePath`  
 A pointer to a `BSTR` that contains a configuration path. The returned path represents the deepest location in `bstrConfigPath` that has an available configuration.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The following table shows example input and output values of the `GetUniqueConfigPath` method. These values require that the configuration has been set at the MACHINE, MACHINE/WEBROOT, and MACHINE/WEBROOT/Site1 levels.  
  
|Input values for `bstrConfigPath`|Output values for `pbstrUniquePath`|  
|---------------------------------------|-----------------------------------------|  
|MACHINE|MACHINE|  
|MACHINE/WEBROOT/Site1|MACHINE/WEBROOT/Site1|  
|MACHINE/WEBROOT/Site1/HelloWorldApp|MACHINE/WEBROOT/Site1|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigManager Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iapphostconfigmanager-interface.md)