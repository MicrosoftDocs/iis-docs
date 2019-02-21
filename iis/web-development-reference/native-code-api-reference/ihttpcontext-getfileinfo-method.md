---
title: "IHttpContext::GetFileInfo Method"
ms.date: "10/07/2016"
ms.assetid: a3f4a0d8-8524-95a1-d8f0-22852f72736d
---
# IHttpContext::GetFileInfo Method
Retrieves the file information container for the current context.  
  
## Syntax  
  
```cpp  
virtual IHttpFileInfo* GetFileInfo(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to an [IHttpFileInfo](../../web-development-reference\native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Remarks  
 The `GetFileInfo` method returns a pointer to an `IHttpFileInfo` interface for the current context. The `IHttpFileInfo` interface contains several methods that can retrieve a variety of file-related information about the current request.  
  
## Example  
 The following code example demonstrates how to use the `GetFileInfo` method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example calls the [IHttpFileInfo::GetFilePath](../../web-development-reference\native-code-api-reference/ihttpfileinfo-getfilepath-method.md) method to retrieve the physical path of the file for the current request and then displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpContextGetFileInfo#1](IHttpContextGetFileInfo#1)]  -->  
  
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
 [IHttpContext Interface](../../web-development-reference\native-code-api-reference/ihttpcontext-interface.md)