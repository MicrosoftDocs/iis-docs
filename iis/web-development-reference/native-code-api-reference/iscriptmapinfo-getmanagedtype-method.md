---
title: "IScriptMapInfo::GetManagedType Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 19e9c7a4-e52f-8161-3473-b7146823a658
caps.latest.revision: 23
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetManagedType Method
Retrieves the managed type for a request handler.  
  
## Syntax  
  
```cpp  
virtual PCWSTR GetManagedType(  
   DWORD* pcchManagedType = NULL  
) const = 0;  
```  
  
#### Parameters  
 `pcchManagedType`  
 A pointer to a `DWORD` buffer that receives the length, in characters, of the managed type.  
  
## Return Value  
 A pointer to a string that contains the managed type.  
  
## Remarks  
 The `GetManagedType` method retrieves the `type` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains a list of the [!INCLUDE[dnprdnshort](../../wmi-provider/includes/dnprdnshort-md.md)] namespaces for a request handler. For example, the "TraceHandler-Integrated" request handler has a `type` attribute of "System.Web.Handlers.TraceHandler" by default.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetManagedType` method to retrieve the managed namespace for the request handler that is processing the current request. The module returns the managed type to a Web client and then exits.  
  
 The `IScriptMapInfo::GetManagedType` method differs from the [IHttpServer::GetManagedType](../../web-development-reference\native-code-api-reference/ihttpserver-getmanagedtype-method.md) method in that the `IScriptMapInfo::GetManagedType` method will retrieve only the `type` attribute for the [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface, whereas the `IHttpServer::GetManagedType` can retrieve the `type` attribute for any virtual path.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetManagedType#1](IScriptMapInfoGetManagedType#1)]  -->  
  
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
 [IScriptMapInfo Interface](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md)   
 [IHttpServer::GetManagedType Method](../../web-development-reference\native-code-api-reference/ihttpserver-getmanagedtype-method.md)