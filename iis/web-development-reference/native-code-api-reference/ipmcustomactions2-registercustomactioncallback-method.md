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
 A pointer to an [ICustomAction2ResultCallback](../../web-development-reference\webdev-native-api-reference/icustomaction2resultcallback-interface.md) interface that will be used to report the results.  
  
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
|Header|Wpframework.h|  
  
## See Also  
 [IPmCustomActions2 Interface](../../web-development-reference\webdev-native-api-reference/ipmcustomactions2-interface.md)   
 [IPmCustomActions2::UnregisterCustomActionCallback Method](../../web-development-reference\webdev-native-api-reference/ipmcustomactions2-unregistercustomactioncallback-method.md)