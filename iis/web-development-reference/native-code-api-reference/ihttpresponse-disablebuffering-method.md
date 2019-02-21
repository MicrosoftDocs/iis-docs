---
title: "IHttpResponse::DisableBuffering Method"
ms.date: "10/07/2016"
ms.assetid: 20bd4ed1-77a9-edd0-dae9-0cc77a1876ec
---
# IHttpResponse::DisableBuffering Method
Disables response buffering for the current request.  
  
## Syntax  
  
```cpp  
virtual VOID DisableBuffering(  
   VOID  
) = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] contains a response buffering feature that is turned on by default, but you can disable it by using the `DisableBuffering` method. With buffering enabled, IIS builds the entire response in memory before it returns any data to a Web client. This increases network performance, but there may be situations where you want to disable buffering. For example, if you are writing an application that requires a long period of time to complete, a Web client will have to wait until the response has been completely built and returned by IIS before the client sees any data. With buffering disabled, the Web client will see data incrementally as it is returned by IIS.  
  
> [!NOTE]
>  The `DisableBuffering` method does not disable buffering for the [CHttpModule::OnSendResponse](../../web-development-reference\native-code-api-reference/chttpmodule-onsendresponse-method.md) method.  
  
## Example  
 The following code example demonstrates how to use the `DisableBuffering` method to create an HTTP module that disables response buffering for the current request.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpResponseDisableBuffering#1](IHttpResponseDisableBuffering#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpResponse Interface](../../web-development-reference\native-code-api-reference/ihttpresponse-interface.md)