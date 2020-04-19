---
title: "IHttpServer::IsCommandLineLaunch Method"
ms.date: "10/07/2016"
ms.assetid: 43f13c9f-116e-b51e-a520-6d6a04217869
---
# IHttpServer::IsCommandLineLaunch Method
Tests whether the worker process was launched from the command line.  
  
## Syntax  
  
```cpp  
virtual BOOL IsCommandLineLaunch(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] was launched from a command line; otherwise, `false`.  
  
## Remarks  
 The `IsCommandLineLaunch` method retrieves the startup status for a worker process. For example, if a worker process is started by a normal HTTP request for a Web site that is hosted by [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)], `IsCommandLineLaunch` will return `true`. In contrast, if a worker process is started by the [Hosted Web Core](../../web-development-reference/native-code-api-reference/hosted-web-core-api-reference.md), `IsCommandLineLaunch` will return `false`.  
  
## Example  
 The following code example demonstrates how to create an HTTP module that uses the `IsCommandLineLaunch` method to test whether the worker process was launched from a command line. The module then returns this information to a Web client.  
  
 [!code-cpp[IHttpServerIsCommandLineLaunch#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpServerIsCommandLineLaunch/cpp/IHttpServerIsCommandLineLaunch.cpp#1)]  
  
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
 [IHttpServer Interface](../../web-development-reference/native-code-api-reference/ihttpserver-interface.md)