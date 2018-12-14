---
title: "IScriptMapInfo Interface | Microsoft Docs"
ms.custom: ""
ms.date: "10/07/2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: cc44126f-5ba3-b432-bc2c-aea50024efaa
caps.latest.revision: 21
author: "shirhatti"
manager: "wpickett"
---
# IScriptMapInfo Interface
Retrieves configuration settings for request handlers.  
  
## Syntax  
  
```cpp  
class IScriptMapInfo  
```  
  
## Methods  
 The following table lists the methods exposed by the `IScriptMapInfo` interface.  
  
|Name|Description|  
|----------|-----------------|  
|[GetAllowedVerbs](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getallowedverbs-method.md)|Retrieves the list of allowed verbs for a script map.|  
|[GetAllowPathInfoForScriptMappings](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getallowpathinfoforscriptmappings-method.md)|Retrieves a value that indicates whether a script map handler has the `allowPathInfo` attribute set to `true`.|  
|[GetIsStarScriptMap](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getisstarscriptmap-method.md)|Retrieves a value that indicates whether a request handler is a wildcard mapping.|  
|[GetManagedType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getmanagedtype-method.md)|Retrieves the managed type for a request handler.|  
|[GetModules](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getmodules-method.md)|Retrieves the list of modules for a request handler.|  
|[GetName](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getname-method.md)|Retrieves the configured name for a request handler.|  
|[GetPath](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getpath-method.md)|Retrieves the `path` attribute for a request handler.|  
|[GetRequiredAccess](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getrequiredaccess-method.md)|Retrieves the required-access setting for the script processor.|  
|[GetResourceType](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getresourcetype-method.md)|Retrieves the resource type for a request handler.|  
|[GetResponseBufferLimit](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getresponsebufferlimit-method.md)|Retrieves the response buffer limit for the script processor.|  
|[GetScriptProcessor](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/iscriptmapinfo-getscriptprocessor-method.md)|Retrieves the script processor for a request handler.|  
  
## Remarks  
 The settings for request handlers in [!INCLUDE[iisver](../../../wmi-provider/includes/iisver-md.md)] are stored in the ApplicationHost.config file, and they contain various attributes that define how request handlers work. For example, the following excerpt from an ApplicationHost.config file shows some of the possible configuration settings for ASP 3.0 or earlier, Internet Server API (ISAPI) DLLs, and static file handling.  
  
```  
<handlers>  
    <add name="ASPClassic"  
        path="*.asp"  
        verb="GET,HEAD,POST"  
        modules="IsapiModule"  
        scriptProcessor="D:\Windows\system32\inetsrv\asp.dll"  
        resourceType="File" />  
    <add name="ISAPI-dll"  
        path="*.dll"  
        verb="*"  
        modules="IsapiModule"  
        resourceType="File"  
        requireAccess="Execute"  
        allowPathInfo="true" />  
    <add name="StaticFile"  
        path="*"  
        verb="*"  
        modules="StaticFileModule,DefaultDocumentModule,DirectoryListingModule"  
        resourceType="Either"  
        requireAccess="Read"/>  
</handlers>  
```  
  
 Classes that implement the `IScriptMapInfo` interface can retrieve the various attributes for request handlers without having to access the ApplicationHost.config file directly.  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../../../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../../../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../../../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../../../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../../../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../../../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../../../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../../../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../../../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../../../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../../../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../../../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../../../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../../../wmi-provider/includes/iis100-md.md)]<br />-   [!INCLUDE[iisexp75](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../../webdevelopment-reference\native-code-api\webdev-native-api-reference/web-server-core-interfaces.md)