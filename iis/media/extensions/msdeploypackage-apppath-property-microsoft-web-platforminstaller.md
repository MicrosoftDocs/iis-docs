---
title: MSDeployPackage.AppPath Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: AppPath Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.AppPath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.apppath(v=VS.90)
ms:contentKeyID: 22049750
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.AppPath
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_AppPath
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_AppPath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.AppPath
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_AppPath
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_AppPath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AppPath Property

Gets or sets the path to the application deployed by a deployment package.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyAppPathAsStringGetSet
'Usage
DiminstanceAsMSDeployPackageDimvalueAsStringvalue = instance.AppPath

instance.AppPath = value
```

``` csharp
publicstringAppPath { get; set; }
```

``` c++
public:
propertyString^ AppPath {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getAppPath () : Stringfunction setAppPath (value : String)
```

#### Property Value

Type: String  
A string value that contains the application path.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

