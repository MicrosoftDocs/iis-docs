---
title: Product.SelectedInstaller Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: SelectedInstaller Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.SelectedInstaller
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.selectedinstaller(v=VS.90)
ms:contentKeyID: 22195871
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.SelectedInstaller
- Microsoft.Web.PlatformInstaller.Product.get_SelectedInstaller
- Microsoft.Web.PlatformInstaller.Product.set_SelectedInstaller
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_SelectedInstaller
- Microsoft.Web.PlatformInstaller.Product.SelectedInstaller
- Microsoft.Web.PlatformInstaller.Product.set_SelectedInstaller
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SelectedInstaller Property

Gets or sets the selected installer.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicPropertySelectedInstallerAsInstallerGetSet
'Usage
DiminstanceAsProductDimvalueAsInstallervalue = instance.SelectedInstaller

instance.SelectedInstaller = value
```

``` csharp
publicInstallerSelectedInstaller { get; set; }
```

``` c++
public:
propertyInstaller^ SelectedInstaller {
    Installer^ get ();
    voidset (Installer^ value);
}
```

``` jscript
function getSelectedInstaller () : Installerfunction setSelectedInstaller (value : Installer)
```

#### Property Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Installer](installer-class-microsoft-web-platforminstaller.md)  
A PlatformInstaller object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

