---
title: "IHttpRequest::InsertEntityBody Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 8e30471e-981b-9026-dc07-5dd2c1e81b02
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IHttpRequest::InsertEntityBody Method
Inserts a new entity body into the existing HTTP request body.  
  
## Syntax  
  
```cpp  
virtual HRESULT InsertEntityBody(  
   IN VOID* pvBuffer,  
   IN DWORD cbBuffer  
) = 0;  
```  
  
#### Parameters  
 `pvBuffer`  
 [IN] A pointer to a `VOID` buffer that contains the request entity body.  
  
 `cbBuffer`  
 [IN] A `DWORD` that contains the size, in bytes, of the buffer.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 The [InsertEntityBody](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttprequest-insertentitybody-method.md) method inserts the entity body that is pointed to by the `pvBuffer` parameter into the HTTP request entity body.  
  
> [!NOTE]
>  The insertion point of the new entity body is before any remaining unread entity body that can be subsequently retrieved from the Web client.  
  
> [!IMPORTANT]
>  IIS does not make a copy of the entity body buffer. Your module's entity buffer must be preserved until the end of the request.  
>   
>  This method does not update the Content-Length header value. A module that uses this method must update the Content-Length separately.  
  
## Example  
 The following code example demonstrates how create an HTTP module that calls the [IHttpContext::AllocateRequestMemory](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-allocaterequestmemory-method.md) method to allocate a 1-KB buffer. The module then copies the string "Hello World" into the buffer. Finally, the module calls the `InsertEntityBody` method to replace the preloaded HTTP request entity body with the buffer and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestInsertEntityBody#1](IHttpRequestInsertEntityBody#1)]  -->  
  
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