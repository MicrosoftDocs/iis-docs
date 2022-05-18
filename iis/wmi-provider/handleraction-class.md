---
title: "HandlerAction Class"
description: This article has information on syntax, methods, properties, subclasses, inheritance hierarchy, and requirements for the HandlerAction Class. 
ms.date: "10/07/2016"
ms.assetid: 68538138-fb53-ff14-d44e-d4dd82928822
---
# HandlerAction Class
Exposes configuration settings for handlers.  
  
## Syntax  
  
```vbs  
class HandlerAction : CollectionElement  
```  
  
## Methods  
 This class contains no methods.  
  
## Properties  
 The following table lists the properties exposed by the `HandlerAction` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AllowPathInfo`|A read/write `boolean` value. `true` if the handler will process full path information in a Uniform Resource Identifier (URI); otherwise, `false`. The default is `false`.<br /><br /> For example, when `true`, this property will allow the handler to process a full path such as "/vdir/myisapi.dll/zip"; when `false`, this property will allow only the partial path "/zip".|  
|`Modules`|A read/write `string` value that specifies the module to which you want to map a file or extension. The default is `null`.|  
|`Name`|A required unique read/write `string` value that specifies a unique name for the handler mapping. The only key property.|  
|`Path`|A read/write `string` value that specifies a file extension or file name with extension of the file type to be handled. The default is `null`.|  
|`PreCondition`|A read/write `string` value that optionally specifies conditions under which the handler can run. The possible values are listed later in the Remarks section.|  
|`RequireAccess`|A read/write `sint32` enumeration that specifies handler access requirements. The possible values are listed later in the Remarks section.|  
|`ResourceType`|A read/write `sint32` enumeration that specifies the mapping type for the handler. The possible values are listed later in the Remarks section.|  
|`ResponseBufferLimit`|A read/write `uint32` value that sets the maximum size, in bytes, of the response buffer for a request handler. If response buffering is enabled in the `Buffer` property of the [PagesSection](../wmi-provider/pagessection-class.md) class, the `ResponseBufferLimit` property controls the maximum number of bytes that an ASP page can write to the response buffer before a flush occurs. The default is 4194304 bytes.|  
|`ScriptProcessor`|A read/write `string` value that specifies the full path to the ISAPI extension .dll file or CGI .exe file that processes the request, if appropriate. If you specify this property, you must specify either "ISAPIModule" or "CGIModule" in the `Modules` property. The default is `null`.|  
|`Type`|A read/write `string` value that specifies the namespace path of a managed handler. The type specified must be a valid managed type that is in the global assembly cache, the application's Bin directory, or the app_code directory. The default is `null`.|  
|`Verb`|A read/write `string` value that specifies a comma-delimited list of verbs. Use this property if you want the mapping to apply to specific request types. The default is `null`.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 Instances of this class are contained in the `Handlers` property of the [HandlersSection](../wmi-provider/handlerssection-class.md) class.  
  
 The following table lists the possible values for the `Precondition` property. The default is `null`.  
  
> [!NOTE]
>  The evaluation of a precondition is a logical `AND` of the components. Because any unknown precondition evaluates to `false`, the presence of an unknown precondition will cause the unknown precondition to be ignored.  
  
|Value|Description|  
|-----------|-----------------|  
|appPoolName=pool1;pool2|The handler will be used for any application pool named in the semicolon-delimited list.|  
|appPoolName!=pool1;pool2|The handler will not be used for any application pool named in the semicolon-delimited list.|  
|bitness32|The handler entry applies only to 32-bit worker processes. For 64-bit computers, you should use this value to specify which application pools run in 32-bit mode.|  
|bitness64|The handler applies only to 64-bit worker processes. For 64-bit computers, you should use this value to specify which application pools run in 64-bit mode.|  
|integratedMode|The handler will be used only for application pools in integrated mode.|  
|ISAPIMode|The handler will be used only for application pools in ISAPI mode.|  
|runtimeVersion|The handler will be used only for application pools that load a certain version of the common language runtime (CLR). To enable this precondition, append a string in the format v*MajorVersion*.*MinorVersion* to the string "runtimeVersion" (for example, "runtimeVersionv2.0").|  
  
 The following table lists the possible values for the `RequireAccess` property. The default is 3 (`Script`).  
  
> [!NOTE]
> Settings in the `AccessPolicy` property of the [HandlersSection](../wmi-provider/handlerssection-class.md) class determine which rights are permitted and, therefore, what handlers are allowed to execute.  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|The handler has no access requirements.|  
|1|`Read`|The handler requires read permission.|  
|2|`Write`|The handler requires write permission.|  
|3|`Script`|The handler requires script rights.|  
|4|`Execute`|The handler requires executable rights.|  
  
 The following table lists the possible values for the `ResourceType` property. The default is 3 (`Unspecified`).  
  
> [!NOTE]
> This property is labeled **Path Type** in [!INCLUDE[iismgr](../wmi-provider/includes/iismgr-md.md)].  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`File`|The mapping is for a file. If the incoming request does not map to a physical file on disk, the request is not passed to the handler.|  
|1|`Directory`|The mapping is for a directory. If the incoming request does not map to a physical folder on disk, the request is not passed to the handler.|  
|2|`Either`|The mapping is for either a file or a directory. If the incoming request does not map to a physical file or folder on disk, the request is not passed to the handler.|  
|3|`Unspecified`|The mapping type is not specified. The request is passed to the handler regardless of whether or not the request maps to a physical file or folder on disk. Use this setting if you are mapping your handler to a file name (for example, "MyHandler.axd") that you know does not exist on disk.|  
  
## Example  
 The following example adds three different categories of handlers to the `<handlers>` section: a legacy script map handler, two native module handlers, and a managed handler.  
  
> [!NOTE]
> Adding or removing a configuration element changes the underlying configuration section, but not the object variable in script that represents the configuration section. In order for the change to appear in your scripts, you must call the WMI `Refresh_` method on the object variable after you make the change. This will update the object variable with the latest data from the configuration store.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the <handlers> section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HandlersSection", oHandlersSection  
  
' Display the old list of handlers.  
WScript.Echo "---[Old Handler List]---"  
Call DisplayHandlers  
  
' Create a legacy script map handler.  
' The required properties are Name, Modules, and ScriptProcessor.  
Set oHandler = oWebAdmin.Get("HandlerAction").SpawnInstance_  
oHandler.Name = "ASPClassic"   
oHandler.Path="*.asp"   
oHandler.Verb="GET,HEAD,POST"   
oHandler.Modules="ISAPIModule"   
oHandler.ResourceType= 0 '0 is "File"  
oHandler.ScriptProcessor = "%windir%\system32\inetsrv\asp.dll"  
  
' Add the handler to the <handlers> section.  
oHandlersSection.Add "Handlers", oHandler  
  
' Create a native module handler for static files.  
' The required properties are Name, Modules, and Path.  
Set oHandler = oWebAdmin.Get("HandlerAction").SpawnInstance_  
oHandler.Name = "StaticFile"   
oHandler.Path="*"   
oHandler.Verb="*"   
oHandler.Modules="StaticFileModule,DefaultDocumentModule,DirectoryListingModule"  
oHandler.ResourceType=2  
oHandler.RequireAccess=1  
  
' Add the handler to the <handlers> section.  
oHandlersSection.Add "Handlers", oHandler  
  
' Create a native module handler for ISAPI DLLs.  
' The required properties are Name, Modules, and Path.  
oHandler.Name = "ISAPI-dll"   
oHandler.Path="*.dll"   
oHandler.Verb="*"   
oHandler.Modules="ISAPIModule"  
oHandler.ResourceType=0  
oHandler.RequireAccess=4  
oHandler.AllowPathInfo=True  
  
' Add the handler to the <handlers> section.  
oHandlersSection.Add "Handlers", oHandler  
  
' Add a managed handler.  
' The required properties are Name, Path, and Type.   
Set oHandler = oWebAdmin.Get("HandlerAction").SpawnInstance_  
oHandler.Name = "TraceHandler-Integrated"   
oHandler.Path="trace.axd"   
oHandler.Verb="GET,HEAD,POST"   
oHandler.Type="System.Web.Handlers.TraceHandler"  
oHandler.PreCondition="integratedMode"  
  
' Add the handler to the <handlers> section.  
oHandlersSection.Add "Handlers", oHandler  
  
' Call the WMI Refresh_ method to update the oHandlersSection object variable.  
oHandlersSection.Refresh_  
  
' Display the new list of handler names.   
WScript.Echo "---[New Handler List]---"  
Call DisplayHandlers  
  
' Provide a sub to display the handler names.  
Sub DisplayHandlers  
    For Each oHandler In oHandlersSection.Handlers  
         WScript.Echo "Name: " & oHandler.Name  
    Next  
    WScript.Echo  
End Sub  
  
```  
  
## Inheritance Hierarchy  
 [CollectionElement](../wmi-provider/collectionelement-class.md)  
  
 `HandlerAction`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [AccessSection Class](../wmi-provider/accesssection-class.md)   
 [CollectionElement Class](../wmi-provider/collectionelement-class.md)   
 [HandlersSection Class](../wmi-provider/handlerssection-class.md)   
 [IScriptMapInfo::GetAllowPathInfoForScriptMappings Method](../web-development-reference/native-code-api-reference/iscriptmapinfo-getallowpathinfoforscriptmappings-method.md)
