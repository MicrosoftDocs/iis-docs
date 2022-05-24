---
title: "IHttpFileInfo::GetLastModifiedString Method"
description: Learn how the IHttpFileInfo::GetLastModifiedString method retrieves the last modified string of the corresponding file for an IHttpFileInfo interface.
ms.date: "10/07/2016"
ms.assetid: 935948f5-f9cc-9cdf-10f9-46b5dcc86ea9
---
# IHttpFileInfo::GetLastModifiedString Method
Retrieves the last modified string of the corresponding file for an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual PCSTR GetLastModifiedString(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a string that contains the last modified date and time.  
  
## Remarks  
 The `GetLastModifiedString` method retrieves a string that contains the date and time that a file currently referenced by an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface was last modified. The `GetLastModifiedString` method is similar to the [IHttpFileInfo::GetLastModifiedTime](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedtime-method.md) method, except that the `GetLastModifiedString` method returns only a string, whereas the `GetLastModifiedTime` method returns a [FILETIME](https://go.microsoft.com/fwlink/?LinkId=56060) structure that you can use for comparisons.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example then calls the `GetLastModifiedString` method to retrieve a string that contains the last modified date and time. Finally, the example displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfoGetLastModifiedString#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfoGetLastModifiedString/cpp/IHttpFileInfoGetLastModifiedString.cpp#1)]  
  
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
 [IHttpFileInfo::GetLastModifiedTime Method](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedtime-method.md)
