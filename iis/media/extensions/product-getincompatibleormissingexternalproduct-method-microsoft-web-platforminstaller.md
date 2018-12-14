---
title: Product.GetIncompatibleOrMissingExternalProduct Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetIncompatibleOrMissingExternalProduct Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.Product.GetIncompatibleOrMissingExternalProduct(System.Collections.Generic.IEnumerable{Microsoft.Web.PlatformInstaller.Product},System.String@,Microsoft.Web.PlatformInstaller.Product@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.getincompatibleormissingexternalproduct(v=VS.90)
ms:contentKeyID: 22049625
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.GetIncompatibleOrMissingExternalProduct
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.GetIncompatibleOrMissingExternalProduct
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetIncompatibleOrMissingExternalProduct Method

Gets a value that determines whether an external product is missing or incompatible with the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetIncompatibleOrMissingExternalProduct ( _
    cartProductsAsIEnumerable(OfProduct), _
    <OutAttribute> ByRefincompatibilityStringAsString, _
    <OutAttribute> ByRefuninstalledExternalDependencyAsProduct _
) AsBoolean
'Usage
DiminstanceAsProductDimcartProductsAsIEnumerable(OfProduct)
DimincompatibilityStringAsStringDimuninstalledExternalDependencyAsProductDimreturnValueAsBooleanreturnValue = instance.GetIncompatibleOrMissingExternalProduct(cartProducts, _
    incompatibilityString, uninstalledExternalDependency)
```

``` csharp
publicboolGetIncompatibleOrMissingExternalProduct(
    IEnumerable<Product> cartProducts,
    outstringincompatibilityString,
    outProductuninstalledExternalDependency
)
```

``` c++
public:
boolGetIncompatibleOrMissingExternalProduct(
    IEnumerable<Product^>^ cartProducts, 
    [OutAttribute] String^% incompatibilityString, 
    [OutAttribute] Product^% uninstalledExternalDependency
)
```

``` jscript
publicfunctionGetIncompatibleOrMissingExternalProduct(
    cartProducts : IEnumerable<Product>, 
    incompatibilityString : String, 
    uninstalledExternalDependency : Product
) : boolean
```

#### Parameters

  - cartProducts  
    Type: IEnumerable\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  
    The list of products currently selected for installation by the user.  

<!-- end list -->

  - incompatibilityString  
    Type: String%  
    An out parameter that contains the description of the incompatibility issue.  

<!-- end list -->

  - uninstalledExternalDependency  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .Product](product-class-microsoft-web-platforminstaller.md)%  
    An out parameter that contains the description of the uninstalled external dependency.  

#### Return Value

Type: Boolean  
true if the external dependency is incompatible or missing, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

