---
title: ProductManager.GetProduct Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetProduct Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.GetProduct(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.getproduct(v=VS.90)
ms:contentKeyID: 22049517
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.GetProduct
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.GetProduct
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetProduct Method

Returns the requested product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetProduct ( _
    productIdAsString _
) AsProduct
'Usage
DiminstanceAsProductManagerDimproductIdAsStringDimreturnValueAsProductreturnValue = instance.GetProduct(productId)
```

``` csharp
publicProductGetProduct(
    stringproductId
)
```

``` c++
public:
Product^ GetProduct(
    String^ productId
)
```

``` jscript
publicfunctionGetProduct(
    productId : String
) : Product
```

#### Parameters

  - productId  
    Type: String  
    The unique identifier of the product to return.  

#### Return Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Product](product-class-microsoft-web-platforminstaller.md)  
A [Product](product-class-microsoft-web-platforminstaller.md) object that represents the requested product.  

## Remarks


> [!NOTE]
> <P>No exceptions are explicitly thrown by this method.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Product](product-class-microsoft-web-platforminstaller.md)

