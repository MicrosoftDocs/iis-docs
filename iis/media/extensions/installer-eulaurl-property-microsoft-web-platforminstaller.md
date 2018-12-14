---
title: Installer.EulaUrl Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: EulaUrl Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.EulaUrl
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.eulaurl(v=VS.90)
ms:contentKeyID: 22049575
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.EulaUrl
- Microsoft.Web.PlatformInstaller.Installer.get_EulaUrl
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.EulaUrl
- Microsoft.Web.PlatformInstaller.Installer.get_EulaUrl
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EulaUrl Property

Gets the location of the end user license agreement.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEulaUrlAsUriGet
'Usage
DiminstanceAsInstallerDimvalueAsUrivalue = instance.EulaUrl
```

``` csharp
publicUriEulaUrl { get; }
```

``` c++
public:
propertyUri^ EulaUrl {
    Uri^ get ();
}
```

``` jscript
function getEulaUrl () : Uri
```

#### Property Value

Type: Uri  
A Uri instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

