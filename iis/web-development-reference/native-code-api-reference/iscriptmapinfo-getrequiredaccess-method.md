---
title: "IScriptMapInfo::GetRequiredAccess Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 05d6d12c-ab7b-aa07-63ce-d3e061fe0057
caps.latest.revision: 20
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetRequiredAccess Method
Retrieves the required-access setting for the script processor.  
  
## Syntax  
  
```cpp  
virtual DWORD GetRequiredAccess(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the required-access setting for the script processor.  
  
## Remarks  
 The `GetRequiredAccess` method retrieves the `requireAccess` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the type of access (for example, read, write, and so on) that the request handler requires. The following values for the required-access setting are defined in the Schema.xml file for IIS:  
  
```  
<attribute name="requireAccess" type="enum" defaultValue="Script">  
   <enum name="None" value="0" />  
   <enum name="Read" value="1" />  
   <enum name="Write" value="2" />  
   <enum name="Script" value="3" />  
   <enum name="Execute" value="4" />  
</attribute>  
```  
  
 For example, when a client requests a file that is processed by the static file handler, the required-access value is 1, because the static file handler requires read-only access by default. A request for an Internet Server API (ISAPI) DLL, however, will return a value of 4, because execute access is required.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetRequiredAccess` method to retrieve the required-access setting for the request handler that is processing the current request. The module converts the required-access setting to a string, returns the string to a Web client, and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetRequiredAccess#1](IScriptMapInfoGetRequiredAccess#1)]  -->  
  
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