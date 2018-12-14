---
title: RewriteTemplateFeature.Navigate Method (Type) (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Navigate Method (Type)
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Navigate(System.Type)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.navigate(v=VS.90)
ms:contentKeyID: 20476354
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Navigate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Navigate Method (Type)

Directs the client to navigate to the specified page type.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionNavigate ( _
    pageTypeAsType _
) AsBoolean
'Usage
DimpageTypeAsTypeDimreturnValueAsBooleanreturnValue = Me.Navigate(pageType)
```

``` csharp
protectedboolNavigate(
    TypepageType
)
```

``` c++
protected:
boolNavigate(
    Type^ pageType
)
```

``` jscript
protectedfunctionNavigate(
    pageType : Type
) : boolean
```

#### Parameters

  - pageType  
    Type: [System. . :: . .Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  
    The page type for the navigation target.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if navigation was successful; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Navigate Overload](rewritetemplatefeature-navigate-method-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

