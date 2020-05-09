---
title: "IHttpFileInfo::GetLastModifiedTime Method"
ms.date: "10/07/2016"
ms.assetid: 8bfb6d62-8091-00fd-b72d-cfb4e6d47bf2
---
# IHttpFileInfo::GetLastModifiedTime Method
Retrieves the last modified time structure of the corresponding file for an [IHttpFileInfo](../../web-development-reference/native-code-api-reference/ihttpfileinfo-interface.md) interface.  
  
## Syntax  
  
```cpp  
virtual VOID GetLastModifiedTime(  
   OUT FILETIME* pFileTime  
) const = 0;  
```  
  
### Parameters  
 `pFileTime`  
 [OUT] A pointer to a [FILETIME](https://go.microsoft.com/fwlink/?LinkId=56060) structure.  
  
## Return Value  
 `VOID`.  
  
## Remarks  
 The `GetLastModifiedTime` method retrieves the time offset for the file that is currently referenced by an `IHttpFileInfo` interface as a `FILETIME` structure.  
  
> [!NOTE]
>  The `FILETIME` structure is a 64-bit value that represents the number of 100-nanosecond intervals since January 1, 1601.  
  
 The `GetLastModifiedTime` method is similar to the [IHttpFileInfo::GetLastModifiedString](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedstring-method.md) method, except that you can use the `FILETIME` structure for comparisons that use functions like [CompareFileTime](https://go.microsoft.com/fwlink/?LinkId=56058) and for calculations that use functions like [FileTimeToSystemTime](https://go.microsoft.com/fwlink/?LinkId=56057).  
  
## Comments  
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
 [IHttpFileInfo::GetLastModifiedString Method](../../web-development-reference/native-code-api-reference/ihttpfileinfo-getlastmodifiedstring-method.md)
