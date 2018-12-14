---
title: ProductManager.GetLanguage Method  (Microsoft.Web.PlatformInstaller)
TOCTitle: GetLanguage Method
ms:assetid: M:Microsoft.Web.PlatformInstaller.ProductManager.GetLanguage(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.platforminstaller.productmanager.getlanguage(v=VS.90)
ms:contentKeyID: 22049717
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.PlatformInstaller.ProductManager.GetLanguage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.PlatformInstaller.dll
api_name:
- Microsoft.Web.PlatformInstaller.ProductManager.GetLanguage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetLanguage Method

Returns the specified language.

**Namespace:**  [Microsoft.Web.PlatformInstaller](microsoft-web-platforminstaller-namespace.md)  
**Assembly:**  Microsoft.Web.PlatformInstaller (in Microsoft.Web.PlatformInstaller.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetLanguage ( _
    languageIdAsString _
) AsLanguage
'Usage
DiminstanceAsProductManagerDimlanguageIdAsStringDimreturnValueAsLanguagereturnValue = instance.GetLanguage(languageId)
```

``` csharp
publicLanguageGetLanguage(
    stringlanguageId
)
```

``` c++
public:
Language^ GetLanguage(
    String^ languageId
)
```

``` jscript
publicfunctionGetLanguage(
    languageId : String
) : Language
```

#### Parameters

  - languageId  
    Type: String  
    The unique identifier of the language to return.  

#### Return Value

Type: [Microsoft.Web.PlatformInstaller. . :: . .Language](language-class-microsoft-web-platforminstaller.md)  
A [Language](language-class-microsoft-web-platforminstaller.md) object that represents the requested language.  

## Remarks

A [Language](language-class-microsoft-web-platforminstaller.md) object provides access to the collection of [Product](product-class-microsoft-web-platforminstaller.md) objects available for the specified language.

If the requested language is not found, this method returns null Nothing nullptr unit a null reference (Nothing in Visual Basic) (Nothing in Visual Basic).


> [!NOTE]
> <P>No exceptions are explicitly thrown by this method.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see <https://msdn.microsoft.com/en-us/library/8skskf63(v=vs.90)>.

## See Also

#### Reference

[ProductManager Class](productmanager-class-microsoft-web-platforminstaller.md)

[ProductManager Members](productmanager-members-microsoft-web-platforminstaller.md)

[Microsoft.Web.PlatformInstaller Namespace](microsoft-web-platforminstaller-namespace.md)

[Language](language-class-microsoft-web-platforminstaller.md)

