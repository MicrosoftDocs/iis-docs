---
title: "Application.Create Method1"
ms.date: "10/07/2016"
ms.assetid: 872a0adb-04f5-4d48-a53d-4abd951ac8c3
---
# Application.Create Method1

Creates a Web application.  
  
## Syntax  
  
```vbs  
oWebAdmin.Get("Application").Create(  
   ApplicationPath,  
   SiteName,  
   PhysicalPath  
)  
```  
  
```jscript#  
var app = webAdmin.Get("Application").Create(  
   ApplicationPath,  
   SiteName,  
   PhysicalPath  
);  
```  
  
### Parameters  
  
|Name|Description|  
|----------|-----------------|  
|`ApplicationPath`|A required `string` value that contains the virtual path for the new application. The path cannot be changed after the application is created.|  
|`PhysicalPath`|An optional `string` value that contains the physical path for the application's root virtual directory.|  
|`SiteName`|A required `string` value that contains the name of the Web site on which the application will be created.|  
  
## Return Value  

 This method does not return a value.  
  
## Remarks  

 If the `PhysicalPath` parameter contains a nonexistent directory, the `Create` method will not automatically create the directory specified by `PhysicalPath`.  
  
 `Create` replaces previous methods of creating IIS applications. To create an application in IIS 6.0, you first created a new virtual directory by calling `SpawnInstance_` on [IIsWebVirtualDir](https://msdn.microsoft.com/58d536c2-28dc-4507-8157-0f3615e463d6) and then called the [IIsWebVirtualDir.AppCreate2](https://msdn.microsoft.com/a149487d-0146-4130-9d8b-2cc7ea1cc280), [IIsWebVirtualDir.AppCreate](https://msdn.microsoft.com/338e574b-6e1f-491b-b9bd-5604e0f4e197), or [IIsWebVirtualDir.AppCreate3](https://msdn.microsoft.com/e7826ec2-eb52-473c-a926-2c8d6cb431ec) method.  
  
> [!NOTE]
>  You cannot use `Application.SpawnInstance_` and `Application.Put_` to create a new application. A new application must have at least an application path and site name, and you can specify these only through the `Create` method's `ApplicationPath` and `SiteName` parameters.  
  
## Example  

 The following example creates a new Web application.  
  
> [!NOTE]
> Because the `Create` method is static, it must be called on the application class.  
  
```  
' Connect to the WMI WebAdministration namespace.  
Set oWebAdmin = GetObject("winmgmts:root\WebAdministration")  
  
' Define the Path, SiteName, and PhysicalPath parameters.  
strAppPath = "/NewApp"  
strSiteName = "Default Web Site"  
strPhysPath = "D:\inetpub\NewApp"  
  
' Create the new application.  
oWebAdmin.Get("Application").Create strAppPath, strSiteName, strPhysPath  
```  
  
## Requirements  
  
|Type|Description|  
|----------|-----------------|  
|Client|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winvista](../wmi-provider/includes/winvista-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[win7](../wmi-provider/includes/win7-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[win8](../wmi-provider/includes/win8-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[win10](../wmi-provider/includes/win10-md.md)]|  
|Server|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)] on [!INCLUDE[winsrv2008](../wmi-provider/includes/winsrv2008-md.md)]<br />-   [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)] on [!INCLUDE[winsrv2008r2](../wmi-provider/includes/winsrv2008r2-md.md)]<br />-   [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)] on [!INCLUDE[winsrv2012](../wmi-provider/includes/winsrv2012-md.md)]<br />-   [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)] on [!INCLUDE[winsrv2012r2](../wmi-provider/includes/winsrv2012r2-md.md)]<br />-   [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)] on [!INCLUDE[winsrv2016](../wmi-provider/includes/winsrv2016-md.md)]|  
|Product|-   [!INCLUDE[iis70](../wmi-provider/includes/iis70-md.md)], [!INCLUDE[iis75](../wmi-provider/includes/iis75-md.md)], [!INCLUDE[iis80](../wmi-provider/includes/iis80-md.md)], [!INCLUDE[iis85](../wmi-provider/includes/iis85-md.md)], [!INCLUDE[iis100](../wmi-provider/includes/iis100-md.md)]|  
|MOF file|WebAdministration.mof|  
  
## See Also  

 [Application Class](../wmi-provider/application-class.md)
