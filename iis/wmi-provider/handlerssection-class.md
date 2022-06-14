---
title: "HandlersSection Class"
description: "HandlersSection Class stores the handlers for a URL. This article describes its syntax, methods, properties, remarks, examples, and requirements."
ms.date: "10/07/2016"
ms.assetid: 861ed70d-87e7-7f0e-791e-ed4bd13e7234
---
# HandlersSection Class
Stores the handlers for a URL.  
  
## Syntax  
  
```vbs  
class HandlersSection : ConfigurationSectionWithCollection  
```  
  
## Methods  
 The following table lists the methods exposed by the `HandlersSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Add](../wmi-provider/configurationsectionwithcollection-add-method.md)|(Inherited from [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md).)|  
|[Clear](../wmi-provider/configurationsectionwithcollection-clear-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[Get](../wmi-provider/configurationsectionwithcollection-get-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[GetAllowDefinition](../wmi-provider/configurationsection-getallowdefinition-method.md)|(Inherited from [ConfigurationSection](../wmi-provider/configurationsection-class.md).)|  
|[GetAllowLocation](../wmi-provider/configurationsection-getallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
|[Remove](../wmi-provider/configurationsectionwithcollection-remove-method.md)|(Inherited from `ConfigurationSectionWithCollection`.)|  
|[RevertToParent](../wmi-provider/configurationsection-reverttoparent-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowDefinition](../wmi-provider/configurationsection-setallowdefinition-method.md)|(Inherited from `ConfigurationSection`.)|  
|[SetAllowLocation](../wmi-provider/configurationsection-setallowlocation-method.md)|(Inherited from `ConfigurationSection`.)|  
  
## Properties  
 The following table lists the properties exposed by the `HandlersSection` class.  
  
|Name|Description|  
|----------|-----------------|  
|`AccessPolicy`|A `sint32` that specifies the access policy for handlers. The possible values are listed later in the Remarks section.|  
|`Handlers`|An array of [HandlerAction](../wmi-provider/handleraction-class.md) objects.|  
|`Location`|(Inherited from `ConfigurationSection`.) A key property.|  
|`Path`|(Inherited from `ConfigurationSection`.) A key property.|  
|`SectionInformation`|(Inherited from `ConfigurationSection`.)|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 This class corresponds to the `<handlers>` section in the ApplicationHost.config file.  
  
 The following table lists the possible values for the `AccessPolicy` property. The default is 1 (`Read`).  
  
|Value|Keyword|Description|  
|-----------|-------------|-----------------|  
|0|`None`|Handlers are allowed no rights.|  
|1|`Read`|Handlers are allowed read permission for files or contents of folders. **Note:**  This flag was named `AccessRead` in IIS 6.0.|  
|2|`Write`|Handlers are allowed to write to enabled directories on the server or to change the content of a write-enabled file. **Note:**  This flag was named `AccessWrite` in IIS 6.0.|  
|4|`Execute`|Handlers are allowed to execute files or contents of folders, regardless of file type. **Note:**  This flag was named `AccessExecute` in IIS 6.0.|  
|16|`Source`|Handlers are allowed to access script source code if either the `Read` or `Write` flag is also set. If `Read` is set, handlers can read the source code. If `Write` is set, handlers can write to the source code. The `Source` flag is not available if neither `Read` nor `Write` is set. **Note:**  This flag was named `AccessSource` in IIS 6.0.|  
|512|`Script`|The handler is allowed to execute scripts. **Note:**  This flag was named `AccessScript` in IIS 6.0.|  
|1024|`NoRemoteWrite`|The handler is not allowed to write remotely. Remote requests to create or change files are denied. If the `Write` flag is also set, requests from only the computer that is running the IIS Web server will succeed. **Note:**  This flag was named `AccessNoRemoteWrite` in IIS 6.0.|  
|4096|`NoRemoteRead`|The handler is not allowed to read remotely. Remote requests to view files are denied. If the `Read` flag is also set, requests from only the computer that is running the IIS Web server will succeed. **Note:**  This flag was named `AccessNoRemoteRead` in IIS 6.0.|  
|8192|`NoRemoteExecute`|The handler is not allowed to execute remotely. Remote requests to execute applications are denied. If the `Execute` flag is also set, requests from only the computer that is running the IIS Web server will succeed. **Note:**  This flag was named `AccessNoRemoteExecute` in IIS 6.0.|  
|16384|`NoRemoteScript`|The handler is not allowed to execute scripts remotely. Remote requests to execute dynamic content are denied. If the `Script` flag is also set, requests from only the computer that is running the IIS Web server will succeed. **Note:**  This flag was named `AccessNoRemoteScript` in IIS 6.0.|  
  
## Example  
 The following examples add and remove a handler from the `<handlers>` section.  
  
> [!NOTE]
>  Adding or removing a configuration element changes the underlying configuration section, but not the object variable in script that represents the configuration section. In order for the change to appear in your scripts, you must call the WMI `Refresh_` method on the object variable after you make the change.  This will update the object variable with the latest data from the configuration store.  
  
```  
' ----------------------------------------------------------  
' The first example adds a handler to the <handlers> section.  
' ----------------------------------------------------------  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the <handlers> section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HandlersSection", oHandlersSection  
  
' Display the old handler names.  
WScript.Echo "---[Old Handler List]---"  
Call DisplayHandlers  
  
' Create a new handler.  
Set oHandler = oWebAdmin.Get("HandlerAction").SpawnInstance_  
oHandler.Name = "NewHandler"   
oHandler.Path="*.stm"   
oHandler.Verb="GET,POST"   
oHandler.Modules="ServerSideIncludeModule"   
  
' Add the handler to the <handlers> section.  
oHandlersSection.Add "Handlers", oHandler  
  
' Call the WMI Refresh_ method to update the oHandlersSection object.  
oHandlersSection.Refresh_  
  
' Display the new handler names.   
WScript.Echo "---[New Handler List]---"  
Call DisplayHandlers  
  
' ----------------------------------------------------------------  
' The second example removes a handler by using the handler name.  
' ----------------------------------------------------------------  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the <handlers> section.  
Set oSite = oWebAdmin.Get("Site.Name='Default Web Site'")  
oSite.GetSection "HandlersSection", oHandlersSection  
  
' Display the old handler names.  
WScript.Echo "---[Old Handler List]---"  
Call DisplayHandlers  
  
' Remove the CGI-exe handler by name.  
For Each oHandler In oHandlersSection.Handlers  
     If oHandler.Name = "CGI-exe" Then  
        oHandlersSection.Remove "Handlers", oHandler  
    End If   
Next  
  
' Call the WMI Refresh_ method to update the oHandlersSection object.  
oHandlersSection.Refresh_  
  
' Display the new list of handler names.   
WScript.Echo "---[New Handler List]---"  
Call DisplayHandlers  
  
' This is the sub that displays the handler names.  
Sub DisplayHandlers  
    WScript.Echo   
    For Each oHandler In oHandlersSection.Handlers  
        WScript.Echo "Handler Name: " & oHandler.Name  
    Next  
End Sub  
  
```  
  
## Inheritance Hierarchy  
 [ConfigurationSection](../wmi-provider/configurationsection-class.md)  
  
 [ConfigurationSectionWithCollection](../wmi-provider/configurationsectionwithcollection-class.md)  
  
 `HandlersSection`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [ConfigurationSectionWithCollection Class](../wmi-provider/configurationsectionwithcollection-class.md)   
 [HandlerAction Class](../wmi-provider/handleraction-class.md)
