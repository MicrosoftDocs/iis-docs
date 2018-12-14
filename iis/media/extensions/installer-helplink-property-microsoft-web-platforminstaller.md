---
title: Installer.HelpLink Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: HelpLink Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.HelpLink
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.helplink(v=VS.90)
ms:contentKeyID: 22049748
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.HelpLink
- Microsoft.Web.PlatformInstaller.Installer.get_HelpLink
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_HelpLink
- Microsoft.Web.PlatformInstaller.Installer.HelpLink
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# HelpLink Property

Gets a string that contains the location of help for the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyHelpLinkAsStringGet
'Usage
DiminstanceAsInstallerDimvalueAsStringvalue = instance.HelpLink
```

``` csharp
publicstringHelpLink { get; }
```

``` c++
public:
propertyString^ HelpLink {
    String^ get ();
}
```

``` jscript
function getHelpLink () : String
```

#### Property Value

Type: String  
A string that contains the location of help for the current installer.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

