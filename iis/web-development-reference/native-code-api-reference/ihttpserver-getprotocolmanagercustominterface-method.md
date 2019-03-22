---
title: "IHttpServer::GetProtocolManagerCustomInterface Method"
ms.date: "10/07/2016"
ms.assetid: 4e7c0771-aa07-a501-d49e-94c98295bfac
---
# IHttpServer::GetProtocolManagerCustomInterface Method
Retrieves a custom interface for a protocol manager.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetProtocolManagerCustomInterface(  
   IN PCWSTR pProtocolManagerDll,  
   IN PCWSTR pProtocolManagerDllInitFunction,  
   IN DWORD dwCustomInterfaceId,  
   OUT PVOID* ppCustomInterface  
) = 0;  
```  
  
### Parameters  
 `pProtocolManagerDll`  
 [IN] A pointer to a string that contains the path to the protocol manager DLL.  
  
 `pProtocolManagerDllInitFunction`  
 [IN] A pointer to a string that contains the name of the initialization function for the protocol manager.  
  
 `dwCustomInterfaceId`  
 [IN] A `DWORD` that contains the ID of the interface to return for the protocol manager.  
  
 `ppCustomInterface`  
 [OUT] A pointer to a `VOID` buffer that contains the custom interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_FILE_NOT_FOUND|Indicates that the protocol manager specified by `pProtocolManagerDll` does not exist, or that the DLL entry point specified by `pProtocolManagerDllInitFunction` is not valid.|  
|ERROR_INVALID_PARAMETER|Indicates the interface specified by `dwCustomInterfaceId` is not valid.|  
  
## Remarks  
 The `GetProtocolManagerCustomInterface` method exposes the [IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface](../../web-development-reference/native-code-api-reference/load-protocol-manager-and-get-custom-interface.md) method to HTTP modules.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)   
 [IWpfExposeProtocolManagerCustomInterface::LoadProtocolManagerAndGetCustomInterface Method](../../web-development-reference/native-code-api-reference/load-protocol-manager-and-get-custom-interface.md)