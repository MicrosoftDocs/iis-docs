---
title: Product.GetMissingDependencies Method ((Product), Product) (Microsoft.Web.PlatformInstaller)
TOCTitle: GetMissingDependencies Method ((Product), Product)
ms:assetid: M:Microsoft.Web.PlatformInstaller.Product.GetMissingDependencies(System.Collections.Generic.IEnumerable{Microsoft.Web.PlatformInstaller.Product},Microsoft.Web.PlatformInstaller.Product)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.getmissingdependencies(v=VS.90)
ms:contentKeyID: 46408530
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
- Microsoft.Web.PlatformInstaller.Product.GetMissingDependencies
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetMissingDependencies Method ((Product), Product)

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetMissingDependencies ( _
    productsToBeInstalledAsIEnumerable(OfProduct), _
    preferredDependencyAsProduct _
) AsReadOnlyCollection(OfProduct)
'Usage
DiminstanceAsProductDimproductsToBeInstalledAsIEnumerable(OfProduct)
DimpreferredDependencyAsProductDimreturnValueAsReadOnlyCollection(OfProduct)

returnValue = instance.GetMissingDependencies(productsToBeInstalled, _
    preferredDependency)
```

``` csharp
publicReadOnlyCollection<Product> GetMissingDependencies(
    IEnumerable<Product> productsToBeInstalled,
    ProductpreferredDependency
)
```

``` c++
public:
ReadOnlyCollection<Product^>^ GetMissingDependencies(
    IEnumerable<Product^>^ productsToBeInstalled, 
    Product^ preferredDependency
)
```

``` jscript
publicfunctionGetMissingDependencies(
    productsToBeInstalled : IEnumerable<Product>, 
    preferredDependency : Product
) : ReadOnlyCollection<Product>
```

#### Parameters

  - productsToBeInstalled  
    Type: IEnumerable\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  

<!-- end list -->

  - preferredDependency  
    Type: [Microsoft.Web.PlatformInstaller. . :: . .Product](product-class-microsoft-web-platforminstaller.md)  

#### Return Value

Type: ReadOnlyCollection\< (Of \< ( \<'[Product](product-class-microsoft-web-platforminstaller.md)\> ) \> ) \>  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[GetMissingDependencies Overload](product-getmissingdependencies-method-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

