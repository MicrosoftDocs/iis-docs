---
title: "IHttpContext::GetServerVarChanges Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f5f8d53a-43dd-2c55-8d7a-eb46d27ef001
caps.latest.revision: 12
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpContext Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::GetServerVariable Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-getservervariable-method.md)