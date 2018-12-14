---
title: MSDeployPackage.Site Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Site Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.Site
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.site(v=VS.90)
ms:contentKeyID: 22049752
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.Site
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_Site
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_Site
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_Site
- Microsoft.Web.PlatformInstaller.MSDeployPackage.set_Site
- Microsoft.Web.PlatformInstaller.MSDeployPackage.Site
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Site Property

Gets or sets a string that contains the site of the package.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertySiteAsStringGetSet
'Usage
DiminstanceAsMSDeployPackageDimvalueAsStringvalue = instance.Site

instance.Site = value
```

``` csharp
publicstringSite { get; set; }
```

``` c++
public:
propertyString^ Site {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getSite () : Stringfunction setSite (value : String)
```

#### Property Value

Type: String  
A string that contains the site of the package.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

