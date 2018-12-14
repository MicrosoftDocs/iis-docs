---
title: "IScriptMapInfo::GetAllowPathInfoForScriptMappings Method | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: decdb30f-9bb2-36e0-1b66-2baf79b4b1cd
caps.latest.revision: 22
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo::GetAllowPathInfoForScriptMappings Method
Retrieves a value that indicates whether a script map handler has the `allowPathInfo` attribute set to `true`.  
  
## Syntax  
  
```cpp  
virtual BOOL GetAllowPathInfoForScriptMappings(  
   VOID  
) const = 0;  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 `true` if the `allowPathInfo` attribute for the script map is set to `true`; otherwise, `false`.  
  
## Remarks  
 Developers can use the `GetAllowPathInfoForScriptMappings` method to retrieve a value that specifies whether an HTTP handler is configured to allow for *PathInfo* data when it processes requests. *PathInfo* refers to the additional path information that may follow the file name and extension in a Uniform Resource Identifier (URI). For example, if you request the URI http://localhost/test.dll/myinfo, the *PathInfo* portion of that URI is /myinfo.  
  
 To configure which HTTP handlers will allow for *PathInfo* information to be used, set the `allowPathInfo` attribute to `true` for an HTTP handler in the ApplicationHost.config file. For example, the configuration section for Internet Server API (ISAPI) DLLs in your ApplicationHost.config file may resemble the following example:  
  
```  
<add name="ISAPI-dll"  
    path="*.dll"  
    verb="*"  
    modules="IsapiModule"  
    resourceType="File"  
    requireAccess="Execute"  
    allowPathInfo="true" />  
```  
  
 This example enables the *PathInfo* data for ISAPI DLLs. Likewise, set the `allowPathInfo` attribute to `false` to disable *PathInfo* data.  
  
## Example  
 The following code example demonstrates how to use the `GetAllowPathInfoForScriptMappings` method to create an HTTP module that retrieves a pointer to an [IScriptMapInfo](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md) interface. The example then uses the `GetAllowPathInfoForScriptMappings` method to retrieve a value that indicates whether *PathInfo* data is enabled for the script map. The module returns the result to a Web client and then exits.  
  
<!-- TODO: review snippet reference  [!CODE [IScriptMapInfoGetAllowPathInfoForScriptMappings#1](IScriptMapInfoGetAllowPathInfoForScriptMappings#1)]  -->  
  
 Your module must export the [RegisterModule](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/pfn-registermodule-function.md) function. You can export this function by creating a module definition (.def) file for your project, or you can compile the module by using the `/EXPORT:RegisterModule` switch. For more information, see [Walkthrough: Creating a Request-Level HTTP Module By Using Native Code](../../../webdevelopment-reference\native-code-development-overview\native-code-dev-overview/walkthrough-creating-a-request-level-http-module-by-using-native-code.md).  
  
 You can optionally compile the code by using the `__stdcall (/Gz)` calling convention instead of explicitly declaring the calling convention for each function.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [IScriptMapInfo Interface](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-interface.md)