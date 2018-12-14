---
title: RewriteTemplateFeature.Navigate Method (Type, Object) (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Navigate Method (Type, Object)
ms:assetid: M:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Navigate(System.Type,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.navigate(v=VS.90)
ms:contentKeyID: 20476359
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

# Navigate Method (Type, Object)

Directs the client to navigate to the specified page type.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
ProtectedFunctionNavigate ( _
    pageTypeAsType, _
    navigationDataAsObject _
) AsBoolean
'Usage
DimpageTypeAsTypeDimnavigationDataAsObjectDimreturnValueAsBooleanreturnValue = Me.Navigate(pageType, _
    navigationData)
```

``` csharp
protectedboolNavigate(
    TypepageType,
    ObjectnavigationData
)
```

``` c++
protected:
boolNavigate(
    Type^ pageType, 
    Object^ navigationData
)
```

``` jscript
protectedfunctionNavigate(
    pageType : Type, 
    navigationData : Object
) : boolean
```

#### Parameters

  - pageType  
    Type: [System. . :: . .Type](https://msdn.microsoft.com/en-us/library/42892f65\(v=vs.90\))  
    The page type for the navigation target.  

<!-- end list -->

  - navigationData  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The navigation data for the navigation target.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if navigation was successful; otherwise, false.  

## Remarks

The navigationData specified is used to initialize the page type.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Navigate Overload](rewritetemplatefeature-navigate-method-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

