---
title: "IAppHostAdminManager::GetAdminSection Method"
ms.date: "10/07/2016"
ms.assetid: 9b611373-5022-0372-942f-4825a8bc3bd3
---
# IAppHostAdminManager::GetAdminSection Method
Gets an [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] configuration section that has the requested name and configuration path.  
  
## Syntax  
  
```cpp  
HRESULT GetAdminSection(  
   [in,  
   string] BSTR bstrSectionName,  
   [in,  
   string] BSTR bstrPath,  
   [out,  
   retval] IAppHostElement** ppAdminSection  
);  
```  
  
### Parameters  
 `bstrSectionName`  
 A `BSTR` that contains the path to a valid section name in the configuration system.  
  
 `bstrPath`  
 A `BSTR` that contains the configuration system path.  
  
 `ppAdminSection`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is invalid.|  
|ERROR_FILE_NOT_FOUND|Indicates that the requested path was not found.|  
|ERROR_INVALID_PARAMETER|Indicates that a parameter is incorrect.|  
|E_ACCESSDENIED|Indicates that the operation was not successful because of access restrictions.|  
  
## Remarks  
 For a specified configuration path, the return values of this method represent the corresponding values in the hierarchically merged configuration set. To set the configuration path, use the `bstrPath` parameter of this method.  
  
## Example  
 The following code example uses the [IAppHostAdminManager](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md) interface to obtain all merged child elements for the `system.webServer/asp` configuration section in the MACHINE/WEBROOT/APPHOST configuration path.  
  
 [!code-cpp[IAppHostAdminLibrary#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostElementChildElements.cpp#1)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostAdminManager Interface](../../web-development-reference/native-code-api-reference/iapphostadminmanager-interface.md)
 [IAppHostConfigFile::GetAdminSection Method](../../web-development-reference/native-code-api-reference/iapphostconfigfile-getadminsection-method.md)
