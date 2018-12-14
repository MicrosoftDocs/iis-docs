---
title: RewriteTemplateFeature.LargeImage Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: LargeImage Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.LargeImage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.largeimage(v=VS.90)
ms:contentKeyID: 20476326
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.LargeImage
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_LargeImage
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_LargeImage
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.LargeImage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LargeImage Property

Gets the large icon displayed on the client-side user interface for this feature.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLargeImageAsObject
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsObjectvalue = instance.LargeImage
```

``` csharp
publicObjectLargeImage { get; }
```

``` c++
public:
propertyObject^ LargeImage {
    Object^ get ();
}
```

``` jscript
function getLargeImage () : Object
```

#### Property Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An object that represents the large icon displayed on the client-side user interface for this feature.  

## Remarks

The value of this property is passed to the current instance in the constructor.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

