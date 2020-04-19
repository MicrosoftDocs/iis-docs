---
title: "IHttpFileInfo::GetSize Method"
ms.date: "10/07/2016"
ms.assetid: 13bdf371-111b-52bb-bc72-e633142210e3
---
# IHttpFileInfo::GetSize Method
Retrieves the size of the corresponding file for an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual VOID GetSize(  
   OUT ULARGE_INTEGER* pliSize  
) const = 0;  
```  
  
### Parameters  
 `pliSize`  
 [OUT] A pointer to a [ULARGE_INTEGER](https://go.microsoft.com/fwlink/?LinkId=56061) structure.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetSize` method retrieves a structure that contains the size of the file that is currently referenced by the `IHttpFileInfo` interface.  
  
> [!NOTE]
>  `ULARGE_INTEGER` is a structure that is declared in the Winnt.h file, and it consists of two `DWORD` values named `LowPart` and `HighPart`. These values are, respectively, the low-order and high-order sections of the actual file size. For example, a file size that is less than 4 GB will have the full file size in the `LowPart` value and a 0 in the `HighPart` value.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference/native-code-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an `IHttpFileInfo` interface. The example then calls the `GetSize` method to retrieve a pointer to a `ULARGE_INTEGER` structure. Finally, the example converts the `LowPart` value from the `ULARGE_INTEGER` structure to a string and then displays this information to a Web client.  
  
 [!code-cpp[IHttpFileInfoGetSize#1](../../../samples/snippets/cpp/VS_Snippets_IIS/IIS7/IHttpFileInfoGetSize/cpp/IHttpFileInfoGetSize.cpp#1)]  
  
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