---
title: "IScriptMapInfo::GetResourceType Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7889d2ef-4ca3-087e-d371-6ce2730b4bb4
caps.latest.revision: 19
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetResourceType Method
Retrieves the resource type for a request handler.  
  
## Syntax  
  
```cpp  
virtual DWORD GetResourceType(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 A `DWORD` that contains the resource type.  
  
## Remarks  
 The `GetResourceType` method retrieves the `resourceType` attribute for a request handler that is located in the `<handlers>` section of the ApplicationHost.config file. This attribute contains the type of resource that the request handler will process. The following values for the resource type are defined in the Schema.xml file for IIS:  
  
```  
<attribute name="resourceType" type="enum" defaultValue="Unspecified">  
   <enum name="File" value="0" />  
   <enum name="Directory" value="1" />  
   <enum name="Either" value="2" />  
   <enum name="Unspecified" value="3" />  
</attribute>  
```  
  
 For example, when a client requests a file that is processed by the static file handler, the default resource type is a value of 2, which specifies either file or directory resources because the static file handler processes both static files and directory browsing requests. A request for a classic ASP page, however, will return a value of 1, which specifies a file resource by default.  
  
## Example  
 The following code example demonstrates how to use the [IHttpContext::GetScriptMap](../../web-development-reference\native-code-api-reference/ihttpcontext-getscriptmap-method.md) method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../web-development-reference\native-code-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetResourceType` method to retrieve the resource type for the request handler that is processing the current request. The module converts the resource type to a string, returns the string to a Web client, and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetResourceType#1](IScriptMapInfoGetResourceType#1)]  -->  
  
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