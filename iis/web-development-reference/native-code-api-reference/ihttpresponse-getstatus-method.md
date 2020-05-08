---
title: "IHttpResponse::GetStatus Method"
ms.date: "10/07/2016"
ms.assetid: e18e4cf1-29cd-b4b4-51d8-72d8093a257a
---
# IHttpResponse::GetStatus Method
Retrieves the HTTP status for the response.  
  
## Syntax  
  
```cpp  
virtual VOID GetStatus(  
   OUT USHORT * pStatusCode,  
   OUT USHORT * pSubStatus = NULL,  
   OUT PCSTR * ppszReason = NULL,  
   OUT USHORT * pcchReason = NULL,  
   OUT HRESULT * phrErrorToReport = NULL,  
   OUT PCWSTR * ppszModule = NULL,  
   OUT DWORD * pdwNotification = NULL,  
   OUT INativeSectionException ** ppException = NULL  
) = 0;  
```  
  
### Parameters  
 `pStatusCode`  
 [OUT] A pointer to an unsigned short integer that receives the HTTP status code for the response.  
  
 `pSubStatus`  
 [OUT] A pointer to an unsigned short integer that receives the HTTP substatus code for the response.  
  
 `ppszReason`  
 [OUT] A pointer to a string that receives the HTTP status text for the response.  
  
 `pcchReason`  
 [OUT] A pointer to an unsigned short integer that receives the length, in characters, of the response status string.  
  
 `phrErrorToReport`  
 [OUT] A pointer to an `HRESULT` that receives the Win32 error associated with the response status.  
  
 `ppszModule`  
 [OUT] A pointer to a string that receives the name of the module that set the status.  
  
 `pdwNotification`  
 [OUT] A pointer to a `DWORD` that receives the notification during which the error status was set.  
  
 `ppException`  
 [OUT] A pointer to an [INativeSectionException](https://msdn.microsoft.com/89e76f37-6196-566b-c07a-f756855d097c) interface that is associated with this status.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetStatus` method returns the complete HTTP response status, which consists of the status code, the substatus code, the status text, and—if an error exists—the Win32 error associated with the response status.  
  
> [!NOTE]
>  The response status string is in a server-owned buffer.  
  
## Example  
 The following code example demonstrates how to use the `GetStatus` method to create an HTTP module that retrieves the HTTP response status. The example module returns the contents of the HTTP response status to the client, and it calls the [IHttpResponse::SetStatus](../../web-development-reference/native-code-api-reference/ihttpresponse-setstatus-method.md) method to set the response status to "200 OK" so the client will always receive the result.  
  
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
 [IHttpResponse::SetStatus Method](../../web-development-reference/native-code-api-reference/ihttpresponse-setstatus-method.md)
