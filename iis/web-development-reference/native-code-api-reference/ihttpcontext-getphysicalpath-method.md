---
title: "IHttpContext::GetPhysicalPath Method"
ms.date: "10/07/2016"
ms.assetid: 664708a6-d319-eb3f-81fa-309082bce260
---
# IHttpContext::GetPhysicalPath Method

Retrieves the physical path for the current request.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetPhysicalPath(  
   DWORD* pcchPhysicalPath = NULL  
) = 0;  
```  
  
### Parameters  

 `pcchPhysicalPath`  
 A pointer to a `DWORD` that will contain the length of the string returned by `GetPhysicalPath`.  
  
## Return Value  

 A pointer to a string that contains the path.  
  
## Remarks  

 You can use the `GetPhysicalPath` method to retrieve the physical path of the current file that is being requested. For example, if a request were made for your site's home page, the `GetPhysicalPath` method might return *SystemDrive*\Inetpub\Wwwroot\Default.htm.  
  
## Example  

 The following code example demonstrates how to use the `GetPhysicalPath` method to create an HTTP module that retrieves the full path of the current request.  
  
 [!code-cpp[IHttpContextGetPhysicalPath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpContextGetPhysicalPath/cpp/IHttpContextGetPhysicalPath.cpp#1)]  
  
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

 [IHttpContext Interface](../../web-development-reference/native-code-api-reference/ihttpcontext-interface.md)
