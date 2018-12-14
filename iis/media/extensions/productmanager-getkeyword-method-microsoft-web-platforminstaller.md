---
title: ProductManager.GetKeyword Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetKeyword Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.GetKeyword(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.getkeyword(v=VS.90)
ms:contentKeyID: 22049675
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.GetKeyword
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.GetKeyword
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetKeyword Method

Returns the value of the specified keyword.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetKeyword ( _
    keywordIdAsString _
) AsKeyword
'Usage
DiminstanceAsProductManagerDimkeywordIdAsStringDimreturnValueAsKeywordreturnValue = instance.GetKeyword(keywordId)
```

``` csharp
publicKeywordGetKeyword(
    stringkeywordId
)
```

``` c++
public:
Keyword^ GetKeyword(
    String^ keywordId
)
```

``` jscript
publicfunctionGetKeyword(
    keywordId : String
) : Keyword
```

#### Parameters

  - keywordId  
    Type: String  
    The unique keyword ID to return.  

#### Return Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Keyword](keyword-class-microsoft-web-platforminstaller.md)  
A [Keyword](keyword-class-microsoft-web-platforminstaller.md) object that represents the requested keyword.  

## Remarks

A [Keyword](keyword-class-microsoft-web-platforminstaller.md) object provides access to the collection of [Product](product-class-microsoft-web-platforminstaller.md) objects associated with the keyword as well as a return reference to the [ProductManager](productmanager-class-microsoft-web-platforminstaller.md) associated with the keyword.

If the requested keyword is not found, this method returns null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).


> [!NOTE]
> <P>No exceptions are explicitly thrown by this method.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Keyword](keyword-class-microsoft-web-platforminstaller.md)

