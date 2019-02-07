---
title: "IAppHostConfigFile::GetAdminSection Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 83c44f92-2b3a-ee32-3bd3-34ae9284d12d
caps.latest.revision: 13
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
 `bstrSectionName`  
 A `BSTR` that contains the name of the requested section.  
  
 `bstrPath`  
 A `BSTR` that contains the requested configuration path.  
  
 `ppAdminSection`  
 A pointer to a pointer for an [IAppHostElement](../../web-development-reference\webdev-native-api-reference/iapphostelement-interface.md) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the section contains invalid data.|  
  
## Example  
 The following code example demonstrates how to use the `GetAdminSection` method to obtain a reference to the `system.webServer/defaultDocument` configuration section in the MACHINE/WEBROOT/APPHOST configuration path.  
  
<!-- TODO: review snippet reference  [!CODE [IAppHostAdminLibrary#5](IAppHostAdminLibrary#5)]  -->  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Ahadmin.h|  
  
## See Also  
 [IAppHostConfigFile Interface](../../web-development-reference\webdev-native-api-reference/iapphostconfigfile-interface.md)