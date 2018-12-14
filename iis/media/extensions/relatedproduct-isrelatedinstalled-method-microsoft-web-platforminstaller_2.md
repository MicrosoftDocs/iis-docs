---
title: RelatedProduct.IsRelatedInstalled Method () (Microsoft.Web.PlatformInstaller)
TOCTitle: IsRelatedInstalled Method ()
ms:assetid: M:Microsoft.Web.PlatformInstaller.RelatedProduct.IsRelatedInstalled(System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.relatedproduct.isrelatedinstalled(v=VS.90)
ms:contentKeyID: 22049743
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.RelatedProduct.IsRelatedInstalled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsRelatedInstalled Method ()

Determines if the related product is installed.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionIsRelatedInstalled ( _
    useCachedValueAsBoolean _
) AsBoolean
'Usage
DiminstanceAsRelatedProductDimuseCachedValueAsBooleanDimreturnValueAsBooleanreturnValue = instance.IsRelatedInstalled(useCachedValue)
```

``` csharp
publicboolIsRelatedInstalled(
    booluseCachedValue
)
```

``` c++
public:
boolIsRelatedInstalled(
    booluseCachedValue
)
```

``` jscript
publicfunctionIsRelatedInstalled(
    useCachedValue : boolean
) : boolean
```

#### Parameters

  - useCachedValue  
    Type: Boolean  
    Determines if the method should use the cached value or not. true if the method should use cached values, otherwise false.  

#### Return Value

Type: Boolean  
true if the related product is installed, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[RelatedProduct Class](relatedproduct-class-microsoft-web-platforminstaller.md)

[RelatedProduct Members](relatedproduct-members-microsoft-web-platforminstaller.md)

[IsRelatedInstalled Overload](relatedproduct-isrelatedinstalled-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

