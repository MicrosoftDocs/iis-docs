---
title: "ISendResponseProvider::GetLogData Method"
ms.date: "10/07/2016"
ms.assetid: 2c5f2ce8-2f94-7147-2b00-5b81f5091489
---
# ISendResponseProvider::GetLogData Method
Retrieves the logging information for the current response.  
  
## Syntax  
  
```cpp  
virtual VOID* GetLogData(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to `VOID`.  
  
## Remarks  
 The `GetLogData` method retrieves a `VOID` pointer, which you cast to an [HTTP_LOG_FIELDS_DATA](https://go.microsoft.com/fwlink/?LinkId=59280) structure to process log information.  
  
> [!NOTE]
>  The `HTTP_LOG_FIELDS_DATA` structure is defined in the Http.h header file.  
  
> [!IMPORTANT]
>  Your HTTP module must set the registration priority to PRIORITY_ALIAS_FIRST or PRIORITY_ALIAS_HIGH, or `GetLogData` will always return NULL. For more information about setting the registration priority, see the [IHttpModuleRegistrationInfo::SetPriorityForRequestNotification](../../web-development-reference/native-code-api-reference/ihttpmoduleregistrationinfo-setpriorityforrequestnotification-method.md) method.  
  
 Before you call `GetLogData`, you need to call the [ISendResponseProvider::GetReadyToLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-getreadytologdata-method.md) method to verify that IIS is ready to log information. When `GetReadyToLogData` returns `true`, your module can use the `GetLogData` method to retrieve the log information.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `GetReadyToLogData` method to determine whether IIS is ready to log information. The module completes the following steps:  
  
1. Uses the `GetLogData` method to retrieve an `HTTP_LOG_FIELDS_DATA` structure.  
  
2. Uses this structure to retrieve the server name from the log information.  
  
3. Modifies the server port in the log entry.  
  
4. Uses the [SetLogData](../../web-development-reference/native-code-api-reference/isendresponseprovider-setlogdata-method.md) method to submit the modified log information to IIS.  
  
5. Returns the server name to a Web client and then exits.  
  
 [!code-cpp[ISendResponseProviderGetLogData#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/ISendResponseProviderGetLogData/cpp/ISendResponseProviderGetLogData.cpp#1)]  
  
 Your module must export the [RegisterModule](../../web-development-reference/native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [ISendResponseProvider Interface](../../web-development-reference/native-code-api-reference/isendresponseprovider-interface.md)   
 [ISendResponseProvider::GetReadyToLogData Method](../../web-development-reference/native-code-api-reference/isendresponseprovider-getreadytologdata-method.md)   
 [ISendResponseProvider::SetLogData Method](../../web-development-reference/native-code-api-reference/isendresponseprovider-setlogdata-method.md)