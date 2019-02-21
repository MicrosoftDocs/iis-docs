---
title: "IHttpServer::GetPerfCounterInfo Method"
ms.date: "10/07/2016"
ms.assetid: 23f0f7c4-3edd-0308-8491-91a27e1c0acc
---
# IHttpServer::GetPerfCounterInfo Method
Retrieves an [IHttpPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual IHttpPerfCounterInfo* GetPerfCounterInfo(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md) interface.  
  
## Remarks  
 The `GetPerfCounterInfo` method retrieves a pointer to an [IHttpPerfCounterInfo](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md) interface that is used to modify the [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] performance counters at the server level.  
  
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
 [IHttpServer Interface](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md)   
 [IHttpPerfCounterInfo Interface](../../web-development-reference\native-code-api-reference/ihttpperfcounterinfo-interface.md)   
 [IHttpSite::GetPerfCounterInfo Method](../../web-development-reference\native-code-api-reference/ihttpsite-getperfcounterinfo-method.md)