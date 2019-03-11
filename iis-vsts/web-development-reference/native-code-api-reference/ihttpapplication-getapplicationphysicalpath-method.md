---
title: "IHttpApplication::GetApplicationPhysicalPath Method"
ms.date: "10/07/2016"
ms.assetid: 37b28860-40de-f634-8988-5a41dced203d
---
# IHttpApplication::GetApplicationPhysicalPath Method
Retrieves the physical path of the application for the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetApplicationPhysicalPath(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the physical path for the application.  
  
## Remarks  
 The `GetApplicationPhysicalPath` method returns the physical path for the root folder of the application that is processing the current request. For example, requests for the default Web site on a server running [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] will usually return the C:\Inetpub\Wwwroot location.  
  
 This path is not always the same folder path as the current request. For example, if a Web client requests both http://example.com/ and http://example.com/example/, these paths may be respectively located at C:\Inetpub\Wwwroot and C:\Inetpub\Wwwroot\Example. However, the `GetApplicationPhysicalPath` method will return only the C:\Inetpub\Wwwroot path for both requests if an application has not been created for the C:\Inetpub\Wwwroot\Example path.  
  
## Example  
 The following code example demonstrates how to use the `GetApplicationPhysicalPath` method to create an HTTP module that retrieves the physical path for the current request and returns the path to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpApplicationGetApplicationPhysicalPath#1](IHttpApplicationGetApplicationPhysicalPath#1)]  -->  
  
 Your module must export the [RegisterModule](../../web-development-reference\native-code-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpApplication Interface](../../web-development-reference\native-code-api-reference/ihttpapplication-interface.md)