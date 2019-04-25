---
title: "IHttpRequest::GetHttpVersion Method"
ms.date: "10/07/2016"
ms.assetid: f040ca7b-9b53-af66-c03f-b298d45448ea
---
# IHttpRequest::GetHttpVersion Method
Returns the HTTP version for the request.  
  
## Syntax  
  
```cpp  
virtual VOID GetHttpVersion(  
   OUT USHORT* pMajorVersion,  
   OUT USHORT* pMinorVersion  
) const = 0;  
```  
  
### Parameters  
 `pMajorVersion`  
 [OUT] A pointer to a `USHORT` buffer that receives the HTTP major version.  
  
 `pMinorVersion`  
 [OUT] A pointer to a `USHORT` buffer that receives the HTTP minor version.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetHttpVersion` method returns the HTTP version for the request, which enables you to write a module that can process a request differently depending on the HTTP version.  
  
> [!NOTE]
>  Request for Comments (RFC) 1945, "Hypertext Transfer Protocol -- HTTP/1.0," and 2616, "Hypertext Transfer Protocol -- HTTP/1.1," describe the different HTTP versions.  
  
## Example  
 The following code example demonstrates how to use the `GetHttpVersion` method to create an HTTP module that retrieves the HTTP version for the current request. The example then returns this information to a Web client.  
  
 [!code-cpp[IHttpRequestGetHttpVersion#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpRequestGetHttpVersion/cpp/IHttpRequestGetHttpVersion.cpp#1)]  
  
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