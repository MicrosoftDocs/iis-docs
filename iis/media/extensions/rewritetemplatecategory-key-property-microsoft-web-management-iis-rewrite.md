---
title: RewriteTemplateCategory.Key Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Key Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory.Key
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatecategory.key(v=VS.90)
ms:contentKeyID: 22049464
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory.Key
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory.get_Key
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory.get_Key
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateCategory.Key
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Key Property

Gets the identity key of a [RewriteTemplateCategory](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md) object.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyKeyAsString
'Usage
DiminstanceAsRewriteTemplateCategoryDimvalueAsStringvalue = instance.Key
```

``` csharp
publicstringKey { get; }
```

``` c++
public:
propertyString^ Key {
    String^ get ();
}
```

``` jscript
function getKey () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string value that contains the key.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateCategory Class](rewritetemplatecategory-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

