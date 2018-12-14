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
 Developers can use the `ReportUnhealthy` method to notify IIS that a problem has occurred, and IIS will automatically call [IWpfActions::FailWorkerProcess](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-failworkerprocess-method.md) to shut down the worker process.  
  
## Example  
 The following code example demonstrates how to use the `ReportUnhealthy` method to create an HTTP module that reports an out-of-memory error and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerReportUnhealthy#1](IHttpServerReportUnhealthy#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpServer Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md)   
 [IWpfActions::FailWorkerProcess Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iwpfactions-failworkerprocess-method.md)