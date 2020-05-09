---
title: "IHttpRequest::GetRemainingEntityBytes Method"
ms.date: "10/07/2016"
ms.assetid: 290bdb6a-d69c-775f-b436-6c703a826d2b
---
# IHttpRequest::GetRemainingEntityBytes Method
Returns the number of remaining bytes to be read from the client.  
  
## Syntax  
  
```cpp  
virtual DWORD GetRemainingEntityBytes(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the number of bytes of data that remain to be read.  
  
## Remarks  
 The `GetRemainingEntityBytes` method determines the size of the remaining data bytes in the current request. For example, if you created a module that used the [IHttpRequest::ReadEntityBody](../../web-development-reference/native-code-api-reference/ihttprequest-readentitybody-method.md) method to retrieve a partial segment of the current request, you would use the `GetRemainingEntityBytes` method to determine the amount of data that is left in the request for processing.  
  
## Example  
 The following code example demonstrates how to use the `GetRemainingEntityBytes` method to create an HTTP module that retrieves the number of bytes to be read from the client.  
  
 [!code-cpp[IHttpRequestGetRemainingEntityBytes#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetRemainingEntityBytes/cpp/IHttpRequestGetRemainingEntityBytes.cpp#1)]  
  
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
 [IHttpRequest Interface](../../web-development-reference/native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::ReadEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-readentitybody-method.md)   
 [IHttpRequest::InsertEntityBody Method](../../web-development-reference/native-code-api-reference/ihttprequest-insertentitybody-method.md)
