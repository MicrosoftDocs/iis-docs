---
title: ProductManager.Languages Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Languages Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.Languages
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.languages(v=VS.90)
ms:contentKeyID: 22049605
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.Languages
- Microsoft.Web.PlatformInstaller.ProductManager.get_Languages
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_Languages
- Microsoft.Web.PlatformInstaller.ProductManager.Languages
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Languages Property

Gets a read-only collection that contains the languages for this instance of the [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) object.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLanguagesAsReadOnlyCollection(OfLanguage)
    Get
'Usage
DiminstanceAsProductManagerDimvalueAsReadOnlyCollection(OfLanguage)

value = instance.Languages
```

``` csharp
publicReadOnlyCollection<Language> Languages { get; }
```

``` c++
public:
propertyReadOnlyCollection<Language^>^ Languages {
    ReadOnlyCollection<Language^>^ get ();
}
```

``` jscript
function getLanguages () : ReadOnlyCollection<Language>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Language](language-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Language](language-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Language](language-class-microsoft-web-platforminstaller.md)

