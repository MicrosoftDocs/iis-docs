---
title: "IPmCustomActions2::RegisterCustomActionCallback Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fa176765-b774-4bd3-a155-56fcfb0886b7
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
---
# IPmCustomActions2::RegisterCustomActionCallback Method
Registers a custom callback method for actions that will result in multiple responses.  
  
## Syntax  
  
```cpp  
virtual HRESULT RegisterCustomActionCallback(  
   IN PCWSTR pszFunctionName,  
   IN PCWSTR pszFunctionArgs,  
   IN ICustomAction2ResultCallback* pCompletionCallbackClass  
) = 0;  
```  
  
#### Parameters  
 `pszFunctionName`  
 A pointer to a string that contains the name of the custom Run-Time Status and Control action to be performed.  
  
 `pszFunctionArgs`  
 A pointer to a string that contains the arguments to be passed to the function specified by `pszFunctionName`.  
  
 `pCompletionCallbackClass`  
 A pointer to an [ICustomAction2ResultCallback](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/icustomaction2resultcallback-interface.md) interface that will be used to report the results.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Wpframework.h|  
  
## See Also  
 [IPmCustomActions2 Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions2-interface.md)   
 [IPmCustomActions2::UnregisterCustomActionCallback Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ipmcustomactions2-unregistercustomactioncallback-method.md)