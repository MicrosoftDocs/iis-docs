---
title: "GetIsapiProcessHost Function"
ms.date: "10/07/2016"
ms.assetid: df43ddf4-ec60-42a3-2dd5-f1738ffbb8ad
---
# GetIsapiProcessHost Function
Retrieves a reference to the process model host.  
  
## Syntax  
  
```cpp  
HRESULT __stdcall GetIsapiProcessHost(  
   IProcessHostSupportFunctions* pFunctions,  
   IProcessHost** ppProcessHost  
);  
```  
  
### Parameters  
 `pFunctions`  
 A pointer to an [IProcessHostSupportFunctions](../../web-development-reference/native-code-api-reference/iprocesshostsupportfunctions-interface.md) interface.  
  
 `ppProcessHost`  
 A pointer to the address of an [IProcessHost](../../web-development-reference/native-code-api-reference/iprocesshost-interface.md) interface.  
  
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
|Product|IIS 7.0, IIS 7.5, IIS Express 7.5, IIS 8.0|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Functions](../../web-development-reference/native-code-api-reference/windows-process-activation-service-functions.md)   
 [PFNGetIsapiProcessHost Function](../../web-development-reference/native-code-api-reference/pfngetisapiprocesshost-function.md)
