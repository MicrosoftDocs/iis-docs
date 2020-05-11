---
title: "IHttpContext::GetExecuteFlags Method"
ms.date: "10/07/2016"
ms.assetid: d4470530-25e6-17cb-d5fb-d817bb02e98c
---
# IHttpContext::GetExecuteFlags Method
Retrieves the execution flags for the current context.  
  
## Syntax  
  
```cpp  
virtual DWORD GetExecuteFlags(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the execution flags.  
  
## Remarks  
 The `GetExecuteFlags` method retrieves the execution flags for the current context. The following table lists the possible values for these flags.  
  
|Value|Description|  
|-----------|-----------------|  
|EXECUTE_FLAG_NO_HEADERS|Suppress the HTTP headers for the child request.|  
|EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR|Ignore the current script map handler for this request chain.|  
|EXECUTE_FLAG_IGNORE_APPPOOL|Execute the request even if the child request is not in the same application pool.|  
|EXECUTE_FLAG_DISABLE_CUSTOM_ERROR|Disable custom errors for the child request.|  
|EXECUTE_FLAG_SAME_URL|The URL for the child request is the same as the parent request.|  
|EXECUTE_FLAG_BUFFER_RESPONSE|Do not flush the child response; return the response to the parent request.|  
|EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE|The child response is still eligible for caching by Http.sys.|  
  
## Example  
 The following code example demonstrates how to create an HTTP module that performs the following tasks:  
  
1. The module registers for the [RQ_SEND_RESPONSE](../../web-development-reference/native-code-api-reference/request-processing-constants.md) notification.  
  
2. The module creates a [CHttpModule](../../web-development-reference/native-code-api-reference/chttpmodule-class.md) class that contains an [OnSendResponse](../../web-development-reference/native-code-api-reference/chttpmodule-onsendresponse-method.md) method.  
  
3. When a Web client requests a URL, IIS calls the module's `OnSendResponse` method. This method performs the following tasks:  
  
    1. Clears the existing response buffer and sets the MIME type for the response.  
  
    2. Retrieves the execution flags for the current context by using the `GetExecuteFlags` method.  
  
    3. Tests for individual execution flags and returns the status to the Web client.  
  
4. The module removes the `CHttpModule` class from memory and then exits.  
  
 [!code-cpp[IHttpContextGetExecuteFlags#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetExecuteFlags/cpp/IHttpContextGetExecuteFlags.cpp#1)]  
  
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
 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)   
 [IHttpContext::ExecuteRequest Method](../../web-development-reference/native-code-api-reference/ihttpcontext-executerequest-method.md)
