---
title: "IHttpResponse::SetStatus Method"
ms.date: "10/07/2016"
ms.assetid: 390a0ab8-6695-4287-4fcc-a1ef24545dcc
---
# IHttpResponse::SetStatus Method
Sets the HTTP status for the response.  
  
## Syntax  
  
```cpp  
virtual HRESULT SetStatus(  
   IN USHORT statusCode,  
   IN PCSTR pszReason,  
   IN USHORT uSubStatus = 0,  
   IN HRESULT hrErrorToReport = S_OK,  
   IN INativeSectionException* pException = NULL  
) = 0;  
```  
  
### Parameters  
 `statusCode`  
 [IN] The HTTP status code to set.  
  
 `pszReason`  
 [IN] A pointer to a string that contains the HTTP status text to set.  
  
 `uSubStatus`  
 [IN] The optional HTTP substatus code to set.  
  
 `hrErrorToReport`  
 [IN] The optional Win32 error associated with the response status code.  
  
 `pException`  
 [IN] A pointer to an optional [INativeSectionException](https://msdn.microsoft.com/89e76f37-6196-566b-c07a-f756855d097c) interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
|ERROR_INVALID_DATA|Indicates that the data is not valid (for example, the data in the status text is too long).|  
|ERROR_NOT_ENOUGH_MEMORY|Indicates that there is insufficient memory to perform the operation.|  
  
## Remarks  
 The `SetStatus` method configures the HTTP response status, which consists of the status code, the substatus code, the status text, a Win32 error (if one exists) associated with the response, and an optional [INativeSectionException](https://msdn.microsoft.com/89e76f37-6196-566b-c07a-f756855d097c) interface.  
  
## Example  
 The following code example demonstrates how to use the `GetStatus` method to create an HTTP module that retrieves the HTTP response status. The example module returns the contents of the HTTP response status to the client and then calls the `SetStatus` method to set the response status to "200 OK" so the client will always receive the result.  
  
 [!code-cpp[IHttpResponseGetStatus#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpResponseGetStatus/cpp/IHttpResponseGetStatus.cpp#1)]  
  
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
 [IHttpResponse Interface](../../web-development-reference/native-code-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::GetStatus Method](../../web-development-reference/native-code-api-reference/ihttpresponse-getstatus-method.md)
