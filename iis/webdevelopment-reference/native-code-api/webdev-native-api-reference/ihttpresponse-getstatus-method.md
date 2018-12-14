---
title: "IHttpResponse::GetStatus Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: e18e4cf1-29cd-b4b4-51d8-72d8093a257a
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
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
 [OUT] A pointer to an [INativeSectionException](http://msdn.microsoft.com/en-us/89e76f37-6196-566b-c07a-f756855d097c) interface that is associated with this status.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetStatus` method returns the complete HTTP response status, which consists of the status code, the substatus code, the status text, and—if an error exists—the Win32 error associated with the response status.  
  
> [!NOTE]
>  The response status string is in a server-owned buffer.  
  
## Example  
 The following code example demonstrates how to use the `GetStatus` method to create an HTTP module that retrieves the HTTP response status. The example module returns the contents of the HTTP response status to the client, and it calls the [IHttpResponse::SetStatus](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setstatus-method.md) method to set the response status to "200 OK" so the client will always receive the result.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseGetStatus#1](IHttpResponseGetStatus#1)]  -->  
  
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
 [IHttpResponse Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-interface.md)   
 [IHttpResponse::SetStatus Method](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpresponse-setstatus-method.md)