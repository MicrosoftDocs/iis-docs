---
title: "IHttpFileInfo::GetVrPath Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: ac22a82f-31dc-f432-2fe0-9e816e439d91
caps.latest.revision: 28
author: "shirhatti"
manager: "wpickett"
---
# IHttpFileInfo::GetVrPath Method
Returns the virtual path for the corresponding file.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetVrPath(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A pointer to a constant null-terminated Unicode string that contains the virtual path of the corresponding file; otherwise, NULL.  
  
## Remarks  
 The behavior of the `GetVrPath` method is implementation specific. You should use the following information as a guideline, but it may not be correct in all scenarios:  
  
-   Implementers that reference an Internet file return a constant null-terminated string.  
  
-   Implementers that reference a non-Internet file return NULL.  
  
> [!CAUTION]
>  Because some implementers return NULL on the `GetVrPath` method, always test for this condition before dereferencing the returned pointer.  
  
## Notes for Implementers  
 [IHttpFileInfo](../../web-development-reference\webdev-native-api-reference/ihttpfileinfo-interface.md) implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` implementers that use dynamic memory allocation must release or call `delete` on the `PCWSTR` pointer when it is no longer needed.  
  
## Notes for Callers  
 `IHttpFileInfo` implementers are responsible for memory management with this data; therefore, `IHttpFileInfo` clients must not release or call `delete` on the returned `PCWSTR` pointer when this data is no longer needed. Furthermore, clients must not cast this data to a pointer that is not a `const` or change the state of the memory referenced by this `PCWSTR`; otherwise; an access violation will be thrown or the data will become invalid.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetFileInfo](../../web-development-reference\webdev-native-api-reference/ihttpcontext-getfileinfo-method.md) method to create an HTTP module that retrieves a pointer to an [IHttpFileInfo](../../web-development-reference\webdev-native-api-reference/ihttpfileinfo-interface.md) interface for the current request. The example then calls the `GetVrPath` method to retrieve virtual path information for the requested file and displays this information to a Web client.  
  
<!-- TODO: review snippet reference  [!CODE [IHttpFileInfo#14](IHttpFileInfo#14)]  -->  
  
 The following text is a sample of the data output from the preceding code example.  
  
```  
HTTP/1.1 200 OK  
content-Type:text/plain  
Server: Microsoft-IIS/7.0  
Date: Thu, 15 Dec 2005 22:22:09 GMT  
Content-Length: 16  
  
VR Path:  NULL  
```  
  
 Your module must export the [RegisterModule](../../web-development-reference\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../web-development-reference\native-code-development-overview\walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IHttpFileInfo Interface](../../web-development-reference\webdev-native-api-reference/ihttpfileinfo-interface.md)