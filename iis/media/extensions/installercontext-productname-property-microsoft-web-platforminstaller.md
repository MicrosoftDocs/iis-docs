---
title: InstallerContext.ProductName Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: ProductName Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.InstallerContext.ProductName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.installercontext.productname(v=VS.90)
ms:contentKeyID: 22049587
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.InstallerContext.ProductName
- Microsoft.Web.PlatformInstaller.InstallerContext.get_ProductName
- Microsoft.Web.PlatformInstaller.InstallerContext.set_ProductName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.InstallerContext.get_ProductName
- Microsoft.Web.PlatformInstaller.InstallerContext.ProductName
- Microsoft.Web.PlatformInstaller.InstallerContext.set_ProductName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProductName Property

Gets or sets the product name.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertyProductNameAsStringGetSet
'Usage
DiminstanceAsInstallerContextDimvalueAsStringvalue = instance.ProductName

instance.ProductName = value
```

``` csharp
publicstringProductName { get; set; }
```

``` c++
public:
propertyString^ ProductName {
    String^ get ();
    voidset (String^ value);
}
```

``` jscript
function getProductName () : Stringfunction setProductName (value : String)
```

#### Property Value

Type: String  
A string that contains the product name.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[InstallerContext Class](installercontext-class-microsoft-web-platforminstaller.md)

[InstallerContext Members](installercontext-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

