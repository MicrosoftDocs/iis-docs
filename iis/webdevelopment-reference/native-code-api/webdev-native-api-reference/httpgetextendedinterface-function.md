---
title: "HttpGetExtendedInterface Function | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 89120dc5-2cae-46a5-82b0-f2a06bc6a7eb
caps.latest.revision: 4
author: "shirhatti"
manager: "wpickett"
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
  
#### Parameters  
 `pHttpServer`  
 [IN] Points to an instance of the [IHttpServer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md) interface.  
  
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
  
 Where `pHttpContext` is an [IHttpContext](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpcontext-interface.md) pointer and `g_pHttpServer` is an [IHttpServer](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/ihttpserver-interface.md) pointer.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Functions](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-functions.md)