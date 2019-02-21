---
title: "AppDomain Class"
ms.date: "10/07/2016"
ms.assetid: 946ad294-b5f2-15ee-f980-853d28c89400
---
# AppDomain Class
Represents an IIS application domain.  
  
## Syntax  
  
```vbs  
class AppDomain : Object  
```  
  
## Methods  
 The following table lists the methods exposed by the `AppDomain` class.  
  
|Name|Description|  
|----------|-----------------|  
|[Unload](../wmi-provider/appdomain-unload-method.md)|Unloads an [!INCLUDE[vstecasp](../wmi-provider/includes/vstecasp-md.md)] application domain from a Web server.|  
  
## Properties  
 The following table lists the properties exposed by the `AppDomain` class.  
  
|Name|Description|  
|----------|-----------------|  
|`Id`|A read-only `string` value that contains a unique identifier for the application domain. A key property.|  
|`IsIdle`|A read-only `boolean` value. `true` if the application domain is currently idle; otherwise, `false`.|  
|`PhysicalPath`|A read-only `string` value that contains the physical path of the application.|  
|`ProcessId`|A read-only `uint32` value that contains the ID of the process in which the application domain is loaded.|  
|`SiteName`|A read-only `string` value that contains the name of the Web site to which the application domain belongs. A key property.|  
|`ApplicationPath`|A read-only `string` value that contains the virtual path of the application domain. A key property.|  
  
## Subclasses  
 This class contains no subclasses.  
  
## Remarks  
 When a request first enters managed code (managed modules or handlers), the IIS `ManagedEngine` module creates an application domain. The application domain then performs necessary processing tasks, such as authenticating a user with Forms authentication or other application services provided by managed code.  
  
## Example  
 The following example shows how you can retrieve and enumerate the application domains on Web server. If no application domains are active, the script does not return a result.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Get the currently existing application domains.  
Set oAppDomains = oWebAdmin.ExecQuery("SELECT * FROM AppDomain")  
  
' Loop through each application domain and display its properties.  
For Each oAppDomain In oAppDomains   
    WScript.Echo "--------------------------------------"  
    WScript.Echo "AppDomain Application Path:   " & oAppDomain.ApplicationPath  
    WScript.Echo "AppDomain ID:   " & oAppDomain.ID  
    WScript.Echo "AppDomain IsIdle:   " & oAppDomain.IsIdle  
    WScript.Echo "AppDomain Physical Path:   " & oAppDomain.PhysicalPath  
    WScript.Echo "AppDomain ProcessID:   " & oAppDomain.ProcessID  
    WScript.Echo "AppDomain SiteName:   " & oAppDomain.SiteName  
Next  
```  
  
 The following example output is based on two domains named `Northwind` and `Proseware` located below the default Web site:  
  
```  
--------------------------------------  
AppDomain Application Path:          /Northwind/  
AppDomain ID:          /LM/W3SVC/1/ROOT/Northwind  
AppDomain IsIdle:        False  
AppDomain Physical Path: D:\inetpub\NorthwindApp\  
AppDomain ProcessID:           3800  
AppDomain SiteName:           Default Web Site  
--------------------------------------  
AppDomain Application Path:          /Proseware/  
AppDomain ID:          /LM/W3SVC/1/ROOT/Proseware  
AppDomain IsIdle:        True  
AppDomain Physical Path: D:\inetpub\ProsewareApp\  
AppDomain ProcessID:           3800  
AppDomain SiteName:           Default Web Site  
  
```  
  
## Inheritance Hierarchy  
 [Object](../wmi-provider/object-class.md)  
  
 `AppDomain`  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  
 [HTTP Request Processing in IIS 7.0](http://go.microsoft.com/fwlink/?LinkId=64722)   
 [Object Class](../wmi-provider/object-class.md)