---
title: "IHttpRequest::ReadEntityBody Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e29ce6f7-d839-ee92-184f-747f98f6a456
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::ReadEntityBody Method
Returns the HTTP request entity body.  
  
## Syntax  
  
```cpp  
virtual HRESULT ReadEntityBody(  
   OUT VOID* pvBuffer,  
   IN DWORD cbBuffer,  
   IN BOOL fAsync,  
   OUT DWORD* pcbBytesReceived,  
   OUT BOOL* pfCompletionPending = NULL  
) = 0;  
```  
  
#### Parameters  
 `pvBuffer`  
 [OUT] A pointer to a buffer that receives the request body.  
  
 `cbBuffer`  
 [IN] The size, in bytes, of the buffer pointed to by `pvBuffer`.  
  
 `fAsync`  
 [IN] `true` to complete the operation asynchronously; otherwise, `false`.  
  
 `pcbBytesReceived`  
 [OUT] A pointer to a `DWORD` buffer that receives the number of bytes actually read if the method call completes synchronously.  
  
 `pfCompletionPending`  
 [OUT] A pointer to a Boolean buffer that receives a value that specifies whether an asynchronous completion is pending.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_CONNECTION_INVALID|Indicates that the byte count for the current request is incorrect.|  
|ERROR_HANDLE_EOF|Indicates that there is no remaining data to be read.|  
|ERROR_INVALID_PARAMETER|Indicates that an invalid value was passed in one of the parameters.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `ReadEntityBody` method supports both synchronous and asynchronous calls.  
  
> [!NOTE]
>  If you are calling the `ReadEntityBody` method asynchronously, your module needs to return immediately after the call.  
  
 After the `ReadEntityBody` method is called, the `pvBuffer` buffer will contain the request body, and the `pcbBytesReceived` buffer will contain the size, in bytes, of the request body that was returned in the `pvBuffer` buffer if the method call completed synchronously.  
  
 In addition, the `pfCompletionPending` buffer will contain a Boolean value that specifies whether an asynchronous completion is pending.  
  
## Example  
 The following code example demonstrates how to use the `ReadEntityBody` method to create an HTTP module that retrieves a 1-KB buffer section from the current request.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestReadEntityBody#1](IHttpRequestReadEntityBody#1)]  -->  
  
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
 [IHttpRequest Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::GetRemainingEntityBytes Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-getremainingentitybytes-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-insertentitybody-method.md)