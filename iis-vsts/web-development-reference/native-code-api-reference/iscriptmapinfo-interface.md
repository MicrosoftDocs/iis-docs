---
title: "IScriptMapInfo Interface"
ms.date: "10/07/2016"
ms.assetid: cc44126f-5ba3-b432-bc2c-aea50024efaa
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
|[GetAllowedVerbs](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getallowedverbs-method.md)|Retrieves the list of allowed verbs for a script map.|  
|[GetAllowPathInfoForScriptMappings](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getallowpathinfoforscriptmappings-method.md)|Retrieves a value that indicates whether a script map handler has the `allowPathInfo` attribute set to `true`.|  
|[GetIsStarScriptMap](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getisstarscriptmap-method.md)|Retrieves a value that indicates whether a request handler is a wildcard mapping.|  
|[GetManagedType](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getmanagedtype-method.md)|Retrieves the managed type for a request handler.|  
|[GetModules](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getmodules-method.md)|Retrieves the list of modules for a request handler.|  
|[GetName](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getname-method.md)|Retrieves the configured name for a request handler.|  
|[GetPath](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getpath-method.md)|Retrieves the `path` attribute for a request handler.|  
|[GetRequiredAccess](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getrequiredaccess-method.md)|Retrieves the required-access setting for the script processor.|  
|[GetResourceType](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getresourcetype-method.md)|Retrieves the resource type for a request handler.|  
|[GetResponseBufferLimit](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getresponsebufferlimit-method.md)|Retrieves the response buffer limit for the script processor.|  
|[GetScriptProcessor](../../web-development-reference\native-code-api-reference/iscriptmapinfo-getscriptprocessor-method.md)|Retrieves the script processor for a request handler.|  
  
## Remarks  
 The settings for request handlers in [!INCLUDE[iisver](../../wmi-provider/includes/iisver-md.md)] are stored in the ApplicationHost.config file, and they contain various attributes that define how request handlers work. For example, the following excerpt from an ApplicationHost.config file shows some of the possible configuration settings for ASP 3.0 or earlier, Internet Server API (ISAPI) DLLs, and static file handling.  
  
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
|Client|-   IIS 7.0 on [!INCLUDE[winvista](../../wmi-provider/includes/winvista-md.md)]<br />-   IIS 7.5 on Windows 7<br />-   IIS 8.0 on Windows 8<br />-   IIS 10.0 on Windows 10|  
|Server|-   IIS 7.0 on [!INCLUDE[winsrv2008](../../wmi-provider/includes/winsrv2008-md.md)]<br />-   IIS 7.5 on Windows Server 2008 R2<br />-   IIS 8.0 on Windows Server 2012<br />-   IIS 8.5 on Windows Server 2012 R2<br />-   IIS 10.0 on Windows Server 2016|  
|Product|-   IIS 7.0, IIS 7.5, IIS 8.0, IIS 8.5, IIS 10.0<br />-   [!INCLUDE[iisexp75](../../web-development-reference/native-code-api-reference/includes/iisexp75-md.md)], [!INCLUDE[iisexp80](../../web-development-reference/native-code-api-reference/includes/iisexp80-md.md)], [!INCLUDE[iisexp100](../../web-development-reference/native-code-api-reference/includes/iisexp100-md.md)]|  
|Header|Httpserv.h|  
  
## See Also  
 [Web Server Core Interfaces](../../web-development-reference\native-code-api-reference/web-server-core-interfaces.md)