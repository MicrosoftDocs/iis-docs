---
title: "IHttpServer::ReportUnhealthy Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 08546d0e-7d6c-eb00-0cd8-2bcf460e7674
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::ReportUnhealthy Method
Reports the worker process as unhealthy.  
  
## Syntax  
  
```cpp  
virtual VOID ReportUnhealthy(  
   IN PCWSTR pszReasonString,  
   IN HRESULT hrReason  
) = 0;  
```  
  
#### Parameters  
 `pszReasonString`  
 [IN] A pointer to a string that contains the cause of the unhealthy status.  
  
 `hrReason`  
 [IN] An `HRESULT` that contains the error condition for the unhealthy status.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 Developers can use the `ReportUnhealthy` method to notify IIS that a problem has occurred, and IIS will automatically call [IWpfActions::FailWorkerProcess](../../web-development-reference\native-code-api-reference/iwpfactions-failworkerprocess-method.md) to shut down the worker process.  
  
## Example  
 The following code example demonstrates how to use the `ReportUnhealthy` method to create an HTTP module that reports an out-of-memory error and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerReportUnhealthy#1](IHttpServerReportUnhealthy#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md)   
 [IWpfActions::FailWorkerProcess Method](../../web-development-reference\native-code-api-reference/iwpfactions-failworkerprocess-method.md)