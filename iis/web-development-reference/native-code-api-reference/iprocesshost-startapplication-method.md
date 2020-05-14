---
title: "IProcessHost::StartApplication Method"
ms.date: "10/07/2016"
ms.assetid: 37eb4762-b0a0-286e-ed01-c57f159504a2
---
# IProcessHost::StartApplication Method
Starts the specified application.  
  
## Syntax  
  
```cpp  
virtual HRESULT __stdcall StartApplication(  
   PCWSTR appId,  
   PCWSTR appPath,  
   IUnknown** ppRuntimeObject  
) = 0;  
```  
  
### Parameters  
 `appId`  
 A string that contains the unique application ID.  
  
 `appPath`  
 A string that contains the virtual path to the application.  
  
 `ppRuntimeObject`  
 A pointer to the address of an [IPphManager](https://msdn.microsoft.com/efe1bc47-3c38-aaf6-51a3-c5c30d4a055c) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The `StartApplication` method does not directly start the application; rather, the request is forwarded to the application manager.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Webhost.h|  
  
## See Also  
 [IProcessHost Interface](../../web-development-reference/native-code-api-reference/iprocesshost-interface.md)
 [IProcessHost::Shutdown Method](../../web-development-reference/native-code-api-reference/iprocesshost-shutdown-method.md)
 [IProcessHost::ShutdownApplication Method](../../web-development-reference/native-code-api-reference/iprocesshost-shutdownapplication-method.md)
