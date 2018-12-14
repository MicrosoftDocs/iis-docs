---
title: ProductManager.Tabs Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Tabs Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.Tabs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.tabs(v=VS.90)
ms:contentKeyID: 22049739
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.Tabs
- Microsoft.Web.PlatformInstaller.ProductManager.get_Tabs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_Tabs
- Microsoft.Web.PlatformInstaller.ProductManager.Tabs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Tabs Property

Gets a read-only list of tabs available through the current [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) instance.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyTabsAsReadOnlyCollection(OfTab)
    Get
'Usage
DiminstanceAsProductManagerDimvalueAsReadOnlyCollection(OfTab)

value = instance.Tabs
```

``` csharp
publicReadOnlyCollection<Tab> Tabs { get; }
```

``` c++
public:
propertyReadOnlyCollection<Tab^>^ Tabs {
    ReadOnlyCollection<Tab^>^ get ();
}
```

``` jscript
function getTabs () : ReadOnlyCollection<Tab>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Tab](tab-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A generic ReadOnlyCollection of [Tab](tab-class-microsoft-web-platforminstaller.md) instances.  

## Remarks

The [Tab](tab-class-microsoft-web-platforminstaller.md) object serves as the base class for three native tab types: [GroupTab](grouptab-class-microsoft-web-platforminstaller.md), [PillarTab](pillartab-class-microsoft-web-platforminstaller.md) and [KeywordTab](keywordtab-class-microsoft-web-platforminstaller.md). See [Tab](tab-class-microsoft-web-platforminstaller.md) for additional information about these UI elements.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Tab](tab-class-microsoft-web-platforminstaller.md)

[GroupTab](grouptab-class-microsoft-web-platforminstaller.md)

[KeywordTab](keywordtab-class-microsoft-web-platforminstaller.md)

[PillarTab](pillartab-class-microsoft-web-platforminstaller.md)

