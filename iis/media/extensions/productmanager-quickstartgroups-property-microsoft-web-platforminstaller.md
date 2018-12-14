---
title: ProductManager.QuickStartGroups Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: QuickStartGroups Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.QuickStartGroups
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.quickstartgroups(v=VS.90)
ms:contentKeyID: 22753929
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.QuickStartGroups
- Microsoft.Web.PlatformInstaller.ProductManager.get_QuickStartGroups
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_QuickStartGroups
- Microsoft.Web.PlatformInstaller.ProductManager.QuickStartGroups
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# QuickStartGroups Property

Gets a collection of quick start groups.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyQuickStartGroupsAsReadOnlyCollection(OfQuickStartGroup)
    Get
'Usage
DiminstanceAsProductManagerDimvalueAsReadOnlyCollection(OfQuickStartGroup)

value = instance.QuickStartGroups
```

``` csharp
publicReadOnlyCollection<QuickStartGroup> QuickStartGroups { get; }
```

``` c++
public:
propertyReadOnlyCollection<QuickStartGroup^>^ QuickStartGroups {
    ReadOnlyCollection<QuickStartGroup^>^ get ();
}
```

``` jscript
function getQuickStartGroups () : ReadOnlyCollection<QuickStartGroup>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'[QuickStartGroup](quickstartgroup-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
A read only collection of [QuickStartGroup](quickstartgroup-class-microsoft-web-platforminstaller.md) objects.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

