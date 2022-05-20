---
title: "IAppHostConfigFile::GetAdminSection Method"
description: "Describes the IAppHostConfigFile::GetAdminSection method and details its parameters, return value, code example, and requirements."
ms.date: 10/07/2016
ms.assetid: 83c44f92-2b3a-ee32-3bd3-34ae9284d12d
---
# IAppHostConfigFile::GetAdminSection Method
Gets a configuration section for a given configuration section and configuration path.  
  
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
 A `BSTR` that contains the name of the requested section.  
  
 `bstrPath`  
 A `BSTR` that contains the requested configuration path.  
  
 `ppAdminSection`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference/native-code-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the section contains invalid data.|  
  
## Example  
 The following code example demonstrates how to use the `GetAdminSection` method to obtain a reference to the `system.webServer/defaultDocument` configuration section in the MACHINE/WEBROOT/APPHOST configuration path.  
  
 [!code-cpp[IAppHostAdminLibrary#5](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IAppHostAdminLibrary/cpp/IAppHostPropertyGetValue.cpp#5)]  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigFile Interface](../../web-development-reference/native-code-api-reference/iapphostconfigfile-interface.md)
