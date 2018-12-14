---
title: Product.IsInstalled Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: IsInstalled Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.Product.IsInstalled(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.isinstalled(v=VS.90)
ms:contentKeyID: 22049694
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.IsInstalled
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.IsInstalled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsInstalled Method

Gets a value that indicates whether the current product is installed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionIsInstalled ( _
    useCachedValueAsBoolean _
) AsBoolean
'Usage
DiminstanceAsProductDimuseCachedValueAsBooleanDimreturnValueAsBooleanreturnValue = instance.IsInstalled(useCachedValue)
```

``` csharp
publicboolIsInstalled(
    booluseCachedValue
)
```

``` c++
public:
boolIsInstalled(
    booluseCachedValue
)
```

``` jscript
publicfunctionIsInstalled(
    useCachedValue : boolean
) : boolean
```

#### Parameters

  - useCachedValue  
    Type: Boolean  
    Determines whether a cached value should be used.  

#### Return Value

Type: Boolean  
true if the product is installed or the cached value indicates that the product is installed, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

