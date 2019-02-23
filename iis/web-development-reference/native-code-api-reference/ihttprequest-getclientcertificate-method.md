---
title: "IHttpRequest::GetClientCertificate Method"
ms.date: "10/07/2016"
ms.assetid: e75ebc13-a6b4-968c-8f0b-729ba591a57b
---
# IHttpRequest::GetClientCertificate Method
Retrieves the client certificate associated with the request.  
  
## Syntax  
  
```cpp  
HRESULT GetClientCertificate(  
   OUT HTTP_SSL_CLIENT_CERT_INFO** ppClientCertInfo,  
   OUT BOOL* pfClientCertNegotiated  
);  
```  
  
### Parameters  
 `ppClientCertInfo`  
 [OUT] A pointer to an [HTTP_SSL_CLIENT_CERT_INFO](https://go.microsoft.com/fwlink/?LinkId=63150) structure.  
  
 `pfClientCertNegotiated`  
 [OUT] `true` if the client certificate has been negotiated already; otherwise, `false`. For more information, see the Remarks section.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Definition|  
|-----------|----------------|  
|S_OK|Indicates that no error occurred, but does not guarantee that a certificate was found. For more information, see the Remarks section.|  
|HRESULT_FROM_WIN32(ERROR_NOT_FOUND)|Indicates no client certificate was found. ERROR_NOT_FOUND is defined in Winerror.h.|  
|ERROR_INVALID_PARAMETER|Indicates that the `ppClientCertInfo` or `pfClientCertNegotiated` parameter is NULL.|  
  
## Remarks  
 A successful HRESULT does not guarantee that a client certificate was found. Developers must also verify that `ppClientCertInfo` is not NULL.  
  
 A `pfClientCertNegotiated` value of `true` does not guarantee that the `ppClientCertInfo` is not NULL.  
  
 Developers can use the `GetClientCertificate` method to retrieve the client certificate associated with the current request. After you call the `GetClientCertificate` method, the `ppClientCertInfo` parameter will contain a pointer to an `HTTP_SSL_CLIENT_CERT_INFO` structure, which will contain the client certificate if one is available or NULL if no certificate is available.  
  
 For URLs that do not require a client certificate, you can call the [NegotiateClientCertificate](../../web-development-reference\native-code-api-reference/ihttprequest-negotiateclientcertificate-method.md) method before you call `GetClientCertificate` to attempt a manual loading of the client certificate.  
  
## Example  
 The following example demonstrates how to get a pointer to the [HTTP_SSL_CLIENT_CERT_INFO](https://go.microsoft.com/fwlink/?LinkId=63150) structure by implementing the [CHttpModule::OnBeginRequest](../../web-development-reference\native-code-api-reference/chttpmodule-onbeginrequest-method.md) method.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpRequestGetClientCertificate#2](IHttpRequestGetClientCertificate#2)]  -->  
  
 For more information about how to create and deploy a native DLL module, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpRequest Interface](../../web-development-reference\native-code-api-reference/ihttprequest-interface.md)   
 [IHttpRequest::NegotiateClientCertificate Method](../../web-development-reference\native-code-api-reference/ihttprequest-negotiateclientcertificate-method.md)