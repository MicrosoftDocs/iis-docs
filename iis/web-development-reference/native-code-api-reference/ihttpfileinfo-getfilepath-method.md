---
title: "IHttpFileInfo::GetFilePath Method"
ms.date: "10/07/2016"
ms.assetid: 3e353fe5-9c43-e137-b0e7-91c78d022f71
---
# IHttpFileInfo::GetFilePath Method
Returns the physical path of the file referenced by an `IHttpFileInfo` interface.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetFilePath(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains a physical path for a file.  
  
## Remarks  
 The `GetFilePath` method retrieves the physical path of a file that is currently referenced by the [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface. For example, if you write an HTTP module that calls the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to retrieve an `IHttpFileInfo` interface for the current request, the `GetFilePath` method will return the physical path of the file that was requested by a Web client.  
  
## Example  
 The following code example demonstrates how to use the `IHttpContext::GetFileInfo` method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example then calls the `GetFilePath` method to retrieve the physical path of the file for the current request. Finally, the example displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfoGetFilePath#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfoGetFilePath/cpp/IHttpFileInfoGetFilePath.cpp#1)]  
  
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
 [IHttpFileInfo Interface](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md)