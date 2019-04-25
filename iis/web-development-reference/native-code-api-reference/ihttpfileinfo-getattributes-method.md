---
title: "IHttpFileInfo::GetAttributes Method"
ms.date: "10/07/2016"
ms.assetid: 4b602175-bf9b-19c7-dd9b-2313bbf30d5a
---
# IHttpFileInfo::GetAttributes Method
Retrieves the attributes of the corresponding file for an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual DWORD GetAttributes(  
   VOID  
) const = 0;  
```  
  
### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the file attribute values.  
  
## Remarks  
 The `GetAttributes` method retrieves a `DWORD` that contains a bitmask of attribute values for the file that is currently referenced by an `IHttpFileInfo` interface. For example, if you write an application that calls the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to retrieve an `IHttpFileInfo` interface, the `GetAttributes` method will return attributes of the file that is being used for the current request.  
  
> [!NOTE]
>  The bitmask values for file attributes are defined in the Io.h header file.  
  
## Example  
 The following code example demonstrates how to use the `IHttpContext::GetFileInfo` method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface for the current request. The example then calls the `GetAttributes` method to retrieve the attributes for the requested file, and it determines the status of the read-only, hidden, and archive attributes. Finally, the example displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfoGetAttributes#1](~/samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfoGetAttributes/cpp/IHttpFileInfoGetAttributes.cpp#1)]  
  
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