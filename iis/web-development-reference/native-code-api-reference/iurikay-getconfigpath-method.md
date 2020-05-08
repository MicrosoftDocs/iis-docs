---
title: "IUriKay::GetConfigPath Method"
ms.date: "10/07/2016"
ms.assetid: fa8f2ba9-e540-45e9-8d4a-190991cac5cb
---
# IUriKay::GetConfigPath Method
Retrieves the path to the configuration file.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetConfigPath(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method accepts no parameters.  
  
## Return Value  
 A string containing the path to the configuration file.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpcach.h|  
  
## See Also  
 [IUriKey Interface](../../web-development-reference/native-code-api-reference/iurikey-interface.md)
