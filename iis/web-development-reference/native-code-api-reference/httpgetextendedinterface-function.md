---
title: "HttpGetExtendedInterface Function"
ms.date: "10/07/2016"
ms.assetid: 89120dc5-2cae-46a5-82b0-f2a06bc6a7eb
---
# HttpGetExtendedInterface Function
Retrieves an extended HTTP interface given the HTTP server instance and the pointer to be down cast.  
  
## Syntax  
  
```cpp  
template <class HttpType1, class HttpType2>  
HRESULT HttpGetExtendedInterface(  
   __in IHttpServer* pHttpServer,  
   __in HttpType1* pInput,  
   __deref_out HttpType2** ppOutput  
);  
```  
  
### Parameters  
 `pHttpServer`  
 [IN] Points to an instance of the [IHttpServer](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md) interface.  
  
 `pInput`  
 [IN] Points to an instance of the interface to be down cast.  
  
 `ppOutput`  
 [OUT] Points to the extended HTTP interface.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|S_OK|Indicates that the operation was successful.|  
  
## Remarks  
 Template parameters (`HttpType1` and `HttpType2`) can be deduced from the arguments to the function, as shown in the following example.  
  
```  
IHttpRequest * pHttpRequest = pHttpContext->GetRequest();  
IHttpRequest2 * pHttpRequest2;  
HRESULT hr = HttpGetExtendedInterface(g_pHttpServer, pHttpRequest, &pHttpRequest2);  
if( SUCCEEDED(hr) )  
{  
    // Use pHttpRequest2.  
}  
```  
  
 Where `pHttpContext` is an [IHttpContext](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md) pointer and `g_pHttpServer` is an [IHttpServer](../../web-development-reference\native-code-api-reference/ihttpserver-interface.md) pointer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Functions](../../web-development-reference\native-code-api-reference/web-server-core-functions.md)