---
title: Product.GetInstaller Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetInstaller Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.Product.GetInstaller(Microsoft.Web.PlatformInstaller.Language)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.getinstaller(v=VS.90)
ms:contentKeyID: 22049749
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.GetInstaller
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.GetInstaller
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetInstaller Method

Gets the installer for the current product given a specified language.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetInstaller ( _
    languageAsLanguage _
) AsInstaller
'Usage
DiminstanceAsProductDimlanguageAsLanguageDimreturnValueAsInstallerreturnValue = instance.GetInstaller(language)
```

``` csharp
publicInstallerGetInstaller(
    Languagelanguage
)
```

``` c++
public:
Installer^ GetInstaller(
    Language^ language
)
```

``` jscript
publicfunctionGetInstaller(
    language : Language
) : Installer
```

#### Parameters

  - language  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .Language](language-class-microsoft-web-platforminstaller.md)  
    A [Language](language-class-microsoft-web-platforminstaller.md) object that specifies the language to use for the installer.  

#### Return Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Installer](installer-class-microsoft-web-platforminstaller.md)  
A PlatformInstaller instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

