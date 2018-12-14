---
title: Product.Summary Property  (Microsoft.Web.PlatformInstaller)
TOCTitle: Summary Property
ms:assetid: P:Microsoft.Web.PlatformInstaller.Product.Summary
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.summary(v=VS.90)
ms:contentKeyID: 22049671
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.Summary
- Microsoft.Web.PlatformInstaller.Product.get_Summary
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.get_Summary
- Microsoft.Web.PlatformInstaller.Product.Summary
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Summary Property

Gets a string that contains a summary for the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertySummaryAsStringGet
'Usage
DiminstanceAsProductDimvalueAsStringvalue = instance.Summary
```

``` csharp
publicstringSummary { get; }
```

``` c++
public:
propertyString^ Summary {
    String^ get ();
}
```

``` jscript
function getSummary () : String
```

#### Property Value

Type: String  
A string that contains a summary for the current product.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

