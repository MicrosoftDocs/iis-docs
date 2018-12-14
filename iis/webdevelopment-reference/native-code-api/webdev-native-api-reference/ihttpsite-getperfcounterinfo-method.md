---
title: "IHttpSite::GetPerfCounterInfo Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: abb697d2-fa6d-8441-ece4-dfb07abd4dee
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpSite::GetPerfCounterInfo Method
Retrieves an [IHttpPerfCounterInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpperfcounterinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual IHttpPerfCounterInfo* GetPerfCounterInfo(  
   VOID  
) = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an `IHttpPerfCounterInfo` interface.  
  
## Remarks  
 The `GetPerfCounterInfo` method retrieves a pointer to an `IHttpPerfCounterInfo` interface that is used to modify the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] performance counters at the site level.  
  
> [!IMPORTANT]
>  This method is part of the [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpSite Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpsite-interface.md)   
 [IHttpPerfCounterInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpperfcounterinfo-interface.md)   
 [IHttpServer::GetPerfCounterInfo Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-getperfcounterinfo-method.md)