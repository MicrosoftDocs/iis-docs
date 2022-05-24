---
title: "IHttpServer2::GetAppPoolConfigFile Method"
description: IHttpServer2::GetAppPoolConfigFile Method retrieves the path of the application pool’s configuration file.
ms.date: "10/07/2016"
ms.assetid: 9c43fdc5-be61-4557-8873-5af3c4f806af
---
# IHttpServer2::GetAppPoolConfigFile Method
Retrieves the path of the application pool’s configuration file.  
  
## Syntax  
  
```cpp  
virtual _Ret_writes_(*pcchConfigFilePath) PCWSTR GetAppPoolConfigFile(  
   _Out_ DWORD * pcchConfigFilePath = NULL  
) const = 0;  
```  
  
### Parameters  
 `pcchConfigFilePath`  
 [OUT] The number of characters in the path to retrieve.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer2 Interface](../../web-development-reference/native-code-api-reference/ihttpserver2-interface.md)
