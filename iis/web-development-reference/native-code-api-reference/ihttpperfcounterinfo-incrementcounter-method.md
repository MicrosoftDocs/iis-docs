---
title: "IHttpPerfCounterInfo::IncrementCounter Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 38f4fbb2-7ae1-0028-4c19-53abe9d9ead2
caps.latest.revision: 17
author: "shirhatti"
manager: "wpickett"
---
# IHttpPerfCounterInfo::IncrementCounter Method
Increments a performance counter by a specified amount.  
  
## Syntax  
  
```cpp  
virtual VOID IncrementCounter(  
   DWORD dwCounterIndex,  
   DWORD dwValue = 1  
) = 0;  
```  
  
#### Parameters  
 `dwCounterIndex`  
 The performance counter to increment.  
  
 `dwValue`  
 The amount to increment for the counter specified by `dwCounterIndex`.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `IncrementCounter` method increases the performance counter specified by the `dwCounterIndex` parameter by the value contained in the `dwValue` parameter.  
  
> [!IMPORTANT]
>  This method is part of the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] infrastructure and is not intended to be used directly from your code.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpPerfCounterInfo Interface](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md)   
 [IHttpPerfCounterInfo::DecrementCounter Method](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-decrementcounter-method.md)