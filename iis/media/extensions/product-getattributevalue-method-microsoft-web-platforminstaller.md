---
title: Product.GetAttributeValue Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetAttributeValue Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.Product.GetAttributeValue(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.product.getattributevalue(v=VS.90)
ms:contentKeyID: 22049720
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.Product.GetAttributeValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.Product.GetAttributeValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAttributeValue Method

Gets the specified attribute value of the current product.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetAttributeValue ( _
    attributeAsString _
) AsString
'Usage
DiminstanceAsProductDimattributeAsStringDimreturnValueAsStringreturnValue = instance.GetAttributeValue(attribute)
```

``` csharp
publicstringGetAttributeValue(
    stringattribute
)
```

``` c++
public:
String^ GetAttributeValue(
    String^ attribute
)
```

``` jscript
publicfunctionGetAttributeValue(
    attribute : String
) : String
```

#### Parameters

  - attribute  
    Type: String  
    The name of the attribute to return.  

#### Return Value

Type: String  
A string that contains the value of the specified attribute. Returns nullNothingnullptrunita null reference (Nothing in Visual Basic) (Nothing in Visual Basic) if the specified attribute does not exist.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[Product Class](product-class-microsoft-web-platforminstaller.md)

[Product Members](product-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

