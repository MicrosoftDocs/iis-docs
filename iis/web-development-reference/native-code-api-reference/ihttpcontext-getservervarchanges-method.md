---
title: "IHttpContext::GetServerVarChanges Method"
ms.date: "10/07/2016"
ms.assetid: f5f8d53a-43dd-2c55-8d7a-eb46d27ef001
---
# IHttpContext::GetServerVarChanges Method
Retrieves the changes to the server variables for the current context.  
  
## Syntax  
  
```cpp  
virtual HRESULT GetServerVarChanges(  
   IN DWORD dwOldChangeNumber,  
   OUT DWORD* pdwNewChangeNumber,  
   IN OUT DWORD* pdwVariableSnapShot,  
   IN OUT PCSTR** ppVariableNameSnapShot,  
   IN OUT PCWSTR** ppVariableValueSnapShot,  
   OUT DWORD* pdwDiffedVariables,  
   OUT DWORD** ppDiffedVariableIndices  
) = 0;  
```  
  
### Parameters  
 `dwOldChangeNumber`  
 [IN] A `DWORD` that contains the old change number.  
  
 `pdwNewChangeNumber`  
 [OUT] A pointer to a `DWORD` that contains the new change number.  
  
 `pdwVariableSnapShot`  
 [IN][OUT] A pointer to a `DWORD` that contains the number of server variables in the snapshot.  
  
 `ppVariableNameSnapShot`  
 [IN][OUT] A pointer to the address of a string array that contains the names of the server variables that were changed in the snapshot.  
  
 `ppVariableValueSnapShot`  
 [IN][OUT] A pointer to the address of a string array that contains the values of the server variables that were changed in the snapshot.  
  
 `pdwDiffedVariables`  
 [OUT] A pointer to a `DWORD` that contains the number of server variables that have changed.  
  
 `ppDiffedVariableIndices`  
 [OUT] A pointer to the address of an array of `DWORD` values, terminated by a –1 value, that contains the indices of server variables that have changed.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 IIS uses the `GetServerVarChanges` method to test for changes to the HTTP server variables since the last time the server variables were examined.  
  
> [!NOTE]
>  IIS uses the `GetServerVarChanges` method to internally synchronize the server variables between calls to native and managed code. Developers should not use the `GetServerVarChanges` method when creating their HTTP modules.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetServerVariable Method](../../web-development-reference/native-code-api-reference/ihttpcontext-getservervariable-method.md)
