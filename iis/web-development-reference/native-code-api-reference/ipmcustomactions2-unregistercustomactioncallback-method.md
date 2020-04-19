---
title: "IPmCustomActions2::UnregisterCustomActionCallback Method"
ms.date: "10/07/2016"
ms.assetid: 01def2ab-12c7-44ac-bbf5-040757fda6d3
---
# IPmCustomActions2::UnregisterCustomActionCallback Method
Unregisters the specified custom action callback method.  
  
## Syntax  
  
```cpp  
virtual HRESULT UnregisterCustomActionCallback(  
   IN PCWSTR pszFunctionName  
) = 0;  
```  
  
### Parameters  
 `pszFunctionName`  
 [IN] Name of the custom action callback method to be unregistered.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmCustomActions2 Interface](../../web-development-reference/native-code-api-reference/ipmcustomactions2-interface.md)   
 [IPmCustomActions2::RegisterCustomActionCallback Method](../../web-development-reference/native-code-api-reference/ipmcustomactions2-registercustomactioncallback-method.md)