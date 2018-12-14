---
title: Language.Default Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Default Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Language.Default
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.language.default(v=VS.90)
ms:contentKeyID: 22049771
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Language.Default
- Microsoft.Web.PlatformInstaller.Language.get_Default
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Language.Default
- Microsoft.Web.PlatformInstaller.Language.get_Default
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Default Property

Gets or sets a value that indicates whether this is the default language.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyDefaultAsBooleanGet
'Usage
DiminstanceAsLanguageDimvalueAsBooleanvalue = instance.Default
```

``` csharp
publicboolDefault { get; }
```

``` c++
public:
propertyboolDefault {
    boolget ();
}
```

``` jscript
function getDefault () : boolean
```

#### Property Value

Type: Boolean  
true if this is the default language, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Language Class](language-class-microsoft-web-platforminstaller.md)

[Language Members](language-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

