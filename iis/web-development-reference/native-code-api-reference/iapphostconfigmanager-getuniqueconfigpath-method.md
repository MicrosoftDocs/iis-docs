---
title: "IAppHostConfigManager::GetUniqueConfigPath Method"
ms.date: "10/07/2016"
ms.assetid: f4f189e2-0977-dae4-7e84-8a9b79cefab9
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
  
### Parameters  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigManager Interface](../../web-development-reference/native-code-api-reference/iapphostconfigmanager-interface.md)
