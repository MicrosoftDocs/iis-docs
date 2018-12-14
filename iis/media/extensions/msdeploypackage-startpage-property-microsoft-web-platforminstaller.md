---
title: MSDeployPackage.StartPage Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: StartPage Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.MSDeployPackage.StartPage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.msdeploypackage.startpage(v=VS.90)
ms:contentKeyID: 22049713
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.StartPage
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_StartPage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.MSDeployPackage.get_StartPage
- Microsoft.Web.PlatformInstaller.MSDeployPackage.StartPage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# StartPage Property

Gets a string that contains the start page for the deployment package.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyStartPageAsStringGet
'Usage
DiminstanceAsMSDeployPackageDimvalueAsStringvalue = instance.StartPage
```

``` csharp
publicstringStartPage { get; }
```

``` c++
public:
propertyString^ StartPage {
    String^ get ();
}
```

``` jscript
function getStartPage () : String
```

#### Property Value

Type: String  
A string that contains the start page for the deployment package.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[MSDeployPackage Class](msdeploypackage-class-microsoft-web-platforminstaller.md)

[MSDeployPackage Members](msdeploypackage-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

