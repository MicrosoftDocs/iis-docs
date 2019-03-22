---
title: "IHttpRequest::NegotiateClientCertificate Method"
ms.date: "10/07/2016"
ms.assetid: c140602f-90ef-75b2-ce8e-676a3b8a722f
---
# IHttpRequest::NegotiateClientCertificate Method
Initiates client certificate negotiation with a Web client.  
  
## Syntax  
  
```cpp  
HRESULT NegotiateClientCertificate(  
   IN BOOL fAsync,  
   OUT BOOL* pfCompletionPending = NULL  
)   
```  
  
### Parameters  
 `fAsync`  
 [IN] `true` to specify that negotiation should occur asynchronously; otherwise, `false`.  
  
 `pfCompletionPending`  
 [OUT] `true` to specify that an asynchronous completion is pending; otherwise, `false`.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that the operation was successful.|  
|E_FAIL|Indicates that the operation failed.|  
  
## Remarks  
 Developers can use the `NegotiateClientCertificate` method to manually initiate client certificate negotiation with a Web client, even if IIS is configured to accept or ignore client certificates. `NegotiateClientCertificate` supports both synchronous and asynchronous operation by specifying the appropriate setting in the `fAsync` parameter. When your module calls `NegotiateClientCertificate` asynchronously, the module must return processing to the integrated request-processing pipeline immediately after calling the method if the `pfCompletionPending` value indicates that an asynchronous completion is pending.  
  
## Example  
 The following example demonstrates how to call `NegotiateClientCertificate` method.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetClientCertificate#1](IHttpRequestGetClientCertificate#1)]  -->  
  
 For more information on how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference/native-code-development-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
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
 [IHttpRequest::GetClientCertificate Method](../../web-development-reference/native-code-api-reference/ihttprequest-getclientcertificate-method.md)