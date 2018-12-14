---
title: Installer.Language Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Language Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Installer.Language
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installer.language(v=VS.90)
ms:contentKeyID: 22049759
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Installer.Language
- Microsoft.Web.PlatformInstaller.Installer.get_Language
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Installer.get_Language
- Microsoft.Web.PlatformInstaller.Installer.Language
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Language Property

Gets the language associated with the current installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLanguageAsLanguageGet
'Usage
DiminstanceAsInstallerDimvalueAsLanguagevalue = instance.Language
```

``` csharp
publicLanguageLanguage { get; }
```

``` c++
public:
propertyLanguage^ Language {
    Language^ get ();
}
```

``` jscript
function getLanguage () : Language
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Language](language-class-microsoft-web-platforminstaller.md)  
A [Language](language-class-microsoft-web-platforminstaller.md) instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Installer Class](installer-class-microsoft-web-platforminstaller.md)

[Installer Members](installer-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

