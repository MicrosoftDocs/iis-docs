---
title: "ISendResponseProvider::GetLogData Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2c5f2ce8-2f94-7147-2b00-5b81f5091489
caps.latest.revision: 14
author: "shirhatti"
manager: "wpickett"
---
# ISendResponseProvider::GetLogData Method
Retrieves the logging information for the current response.  
  
## Syntax  
  
```cpp  
virtual VOID* GetLogData(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to `VOID`.  
  
## Remarks  
 The `GetLogData` method retrieves a `VOID` pointer, which you cast to an [HTTP_LOG_FIELDS_DATA](http://go.microsoft.com/fwlink/?LinkId=59280) structure to process log information.  
  
> [!NOTE]
>  The `HTTP_LOG_FIELDS_DATA` structure is defined in the Http.h header file.  
  
> [!IMPORTANT]
>  Your HTTP module must set the registration priority to PRIORITY_ALIAS_FIRST or PRIORITY_ALIAS_HIGH, or `GetLogData` will always return NULL. For more information about setting the registration priority, see the [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method.  
  
 Before you call `GetLogData`, you need to call the [ISendResponseProvider::GetReadyToLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getreadytologdata-method.md) method to verify that IIS is ready to log information. When `GetReadyToLogData` returns `true`, your module can use the `GetLogData` method to retrieve the log information.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `GetReadyToLogData` method to determine whether IIS is ready to log information. The module completes the following steps:  
  
1.  Uses the `GetLogData` method to retrieve an `HTTP_LOG_FIELDS_DATA` structure.  
  
2.  Uses this structure to retrieve the server name from the log information.  
  
3.  Modifies the server port in the log entry.  
  
4.  Uses the [SetLogData](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setlogdata-method.md) method to submit the modified log information to IIS.  
  
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
 [ISendResponseProvider::GetReadyToLogData Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-getreadytologdata-method.md)   
 [ISendResponseProvider::SetLogData Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/isendresponseprovider-setlogdata-method.md)