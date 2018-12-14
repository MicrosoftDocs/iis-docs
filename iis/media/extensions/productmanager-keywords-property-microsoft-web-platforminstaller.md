---
title: ProductManager.Keywords Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Keywords Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.Keywords
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.keywords(v=VS.90)
ms:contentKeyID: 22049518
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.Keywords
- Microsoft.Web.PlatformInstaller.ProductManager.get_Keywords
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_Keywords
- Microsoft.Web.PlatformInstaller.ProductManager.Keywords
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Keywords Property

Gets a read-only collection that contains the keywords for this instance of the [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) object.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKeywordsAsReadOnlyCollection(OfKeyword)
    Get
'Usage
DiminstanceAsProductManagerDimvalueAsReadOnlyCollection(OfKeyword)

value = instance.Keywords
```

``` csharp
publicReadOnlyCollection<Keyword> Keywords { get; }
```

``` c++
public:
propertyReadOnlyCollection<Keyword^>^ Keywords {
    ReadOnlyCollection<Keyword^>^ get ();
}
```

``` jscript
function getKeywords () : ReadOnlyCollection<Keyword>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Keyword](keyword-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Keyword](keyword-class-microsoft-web-platforminstaller.md) objects.  

## Remarks

The [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) contains a list of keywords that can be displayed by a [KeywordTab](keywordtab-class-microsoft-web-platforminstaller.md) in the Web Platform Installer user interface. This property returns a read-only copy of those keywords associated with the current installation operation.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Keyword](keyword-class-microsoft-web-platforminstaller.md)

