---
title: "PFNGetIsapiProcessHost Function"
ms.date: "10/07/2016"
ms.assetid: d4f3a36f-6da3-f4f9-6d63-4d35a8ca8e1a
---
# PFNGetIsapiProcessHost Function
Provides a `typedef` to retrieve a reference to the process model host.  
  
## Syntax  
  
```cpp  
typedef HRESULT(  
   __stdcall* PFNGetIsapiProcessHost)(  
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
  
## Remarks  
 The `PFNGetIsapiProcessHost` function provides a convenient `typedef` to the [GetIsapiProcessHost](../../web-development-reference/native-code-api-reference/getisapiprocesshost-function.md) function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [Windows Process Activation Service Functions](../../web-development-reference/native-code-api-reference/windows-process-activation-service-functions.md)   
 [GetIsapiProcessHost Function](../../web-development-reference/native-code-api-reference/getisapiprocesshost-function.md)
