---
title: "IHttpResponse::Flush Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2e52ec34-c034-1386-61dc-f36126855931
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IHttpResponse::Flush Method
Sends the existing content in the response buffer to the client.  
  
## Syntax  
  
```cpp  
virtual HRESULT Flush(  
   IN BOOL fAsync,  
   IN BOOL fMoreData,  
   OUT DWORD* pcbSent,  
   OUT BOOL* pfCompletionExpected = NULL  
) = 0;  
```  
  
#### Parameters  
 `fAsync`  
 [IN] `true` to complete the operation asynchronously; otherwise, `false`.  
  
 `fMoreData`  
 [IN] `true` to send more data in this response; otherwise, `false`.  
  
 `pcbSent`  
 [OUT] A pointer to a `DWORD` that receives the number of bytes sent to the client.  
  
 `pfCompletionExpected`  
 [OUT] A pointer to a Boolean value that receives whether an asynchronous completion is pending for this call.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is not valid.|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `Flush` method sends the currently available response to the client. At a minimum, the response includes the status headers, but it will also include any response buffer that exists when you call the method.  
  
 Set the `fMoreData` parameter to `true` if more data will be returned after you call the `Flush` method, or set `fMoreData` to `false` if there is no data remaining.  
  
 The `Flush` method supports synchronous and asynchronous operation. Specify the mode of operation by setting the `fAsync` parameter to `true` if the operation is asynchronous, or set `fAsync` to `false` if the operation is synchronous.  
  
> [!NOTE]
>  If you are calling this method asynchronously, you must return immediately after the call.  
  
## Example  
 The following code example demonstrates how to use the `Flush` method to send the current response to the client. Because the `Flush` method has sent the response headers to the client, the subsequent call to the [Clear](../../web-development-reference\webdev-native-api-reference/ihttpresponse-clear-method.md) method will have no effect.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseFlush#1](IHttpResponseFlush#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../web-development-reference\webdev-native-api-reference/ihttpresponse-interface.md)