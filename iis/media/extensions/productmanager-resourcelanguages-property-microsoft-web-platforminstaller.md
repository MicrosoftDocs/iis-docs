---
title: ProductManager.ResourceLanguages Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: ResourceLanguages Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.ProductManager.ResourceLanguages
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.resourcelanguages(v=VS.90)
ms:contentKeyID: 22049751
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.ResourceLanguages
- Microsoft.Web.PlatformInstaller.ProductManager.get_ResourceLanguages
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.get_ResourceLanguages
- Microsoft.Web.PlatformInstaller.ProductManager.ResourceLanguages
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ResourceLanguages Property

Gets a read-only collection of supported resource languages.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyResourceLanguagesAsReadOnlyCollection(OfString)
    Get
'Usage
DiminstanceAsProductManagerDimvalueAsReadOnlyCollection(OfString)

value = instance.ResourceLanguages
```

``` csharp
publicReadOnlyCollection<string> ResourceLanguages { get; }
```

``` c++
public:
propertyReadOnlyCollection<String^>^ ResourceLanguages {
    ReadOnlyCollection<String^>^ get ();
}
```

``` jscript
function getResourceLanguages () : ReadOnlyCollection<String>
```

#### Property Value

Type: ReadOnlyCollection\< (Of \< ( \<'String\> ) \> ) \>  
A generic ReadOnlyCollection of strings that represent the supported languages.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

