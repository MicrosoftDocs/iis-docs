---
title: "ISendResponseProvider::GetReadyToLogData Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: c3ddf072-65c5-3260-de3f-653255dc7513
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# ISendResponseProvider::GetReadyToLogData Method
Retrieves a value that indicates whether IIS is ready to write information to the logs.  
  
## Syntax  
  
```cpp  
virtual BOOL GetReadyToLogData(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if IIS is ready to log information; otherwise, `false`.  
  
## Remarks  
 When writing HTTP modules that retrieve or modify the IIS log values, you should first call the `GetReadyToLogData` method to determine whether IIS is ready to log information. If the `GetReadyToLogData` method returns `false`, your module should not call the [ISendResponseProvider::GetLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getlogdata-method.md) method or it will return NULL.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `GetReadyToLogData` method to determine whether IIS is ready log information. The module completes the following steps:  
  
1.  Uses the `GetLogData` method to retrieve an [HTTP_LOG_FIELDS_DATA](http://go.microsoft.com/fwlink/?LinkId=59280) structure.  
  
2.  Uses this structure to retrieve the server name from the log information.  
  
3.  Modifies the server port in the log entry.  
  
4.  Uses the [ISendResponseProvider::SetLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setlogdata-method.md) method to submit the modified log information to IIS.  
  
5.  Returns the server name to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [ISendResponseProviderGetLogData#1](ISendResponseProviderGetLogData#1)]  -->  
  
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
 [ISendResponseProvider Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-interface.md)   
 [ISendResponseProvider::GetLogData Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getlogdata-method.md)