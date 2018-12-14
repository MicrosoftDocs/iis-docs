---
title: "IHttpServer::SatisfiesPrecondition Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cc0beadd-fa0d-b706-02db-f4931ae6c78a
caps.latest.revision: 18
author: "shirhatti"
manager: "wpickett"
---
# IHttpServer::SatisfiesPrecondition Method
Determines whether a specific precondition has been met for the current request.  
  
## Syntax  
  
```cpp  
virtual BOOL SatisfiesPrecondition(  
   IN PCWSTR pszPrecondition  
) const = 0;  
```  
  
#### Parameters  
 `pszPrecondition`  
 [IN] A pointer to a string that contains the precondition to test.  
  
## Return Value  
 `true` if the precondition has been met; otherwise, `false`.  
  
## Remarks  
 The `SatisfiesPrecondition` method tests whether a specific precondition has been met for the current request. For example, an HTTP handler may require a specific version of the [!INCLUDE[dnprdnshort](../../../wmi-provider/includes/dnprdnshort-md.md)], or an HTTP module may require integrated or ISAPI mode.  
  
 The following table lists the possible preconditions for [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)].  
  
|Value|Description|  
|-----------|-----------------|  
|`integratedMode` or `ISAPIMode`|Specifies the required mode of operation as integrated or ISAPI mode.|  
|`runtimeVersionv1.0`, `runtimeVersionv1.1`, or `runtimeVersionv2.0`|Specifies the required version of the [!INCLUDE[dnprdnshort](../../../wmi-provider/includes/dnprdnshort-md.md)].|  
|`bitness32` or `bitness64`|Specifies a 32-bit or 64-bit requirement.|  
|`appPoolName=name1;name2`|Specifies the names of required application pools.|  
  
## Example  
 The following code example demonstrates how to use the `SatisfiesPrecondition` method to create an HTTP module that determines whether the `integratedMode` precondition has been met and then returns a status message to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpServerSatisfiesPrecondition#1](IHttpServerSatisfiesPrecondition#1)]  -->  
  
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