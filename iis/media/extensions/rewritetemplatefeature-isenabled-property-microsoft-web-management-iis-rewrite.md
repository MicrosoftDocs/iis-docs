---
title: RewriteTemplateFeature.IsEnabled Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: IsEnabled Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.IsEnabled
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.isenabled(v=VS.90)
ms:contentKeyID: 22049455
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.IsEnabled
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_IsEnabled
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_IsEnabled
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.IsEnabled
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsEnabled Property

Gets a Boolean value that indicates whether the [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) is enabled.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicOverridableReadOnlyPropertyIsEnabledAsBoolean
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsBooleanvalue = instance.IsEnabled
```

``` csharp
publicvirtualboolIsEnabled { get; }
```

``` c++
public:
virtualpropertyboolIsEnabled {
    boolget ();
}
```

``` jscript
function getIsEnabled () : boolean
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
A Boolean value that indicates whether the [RewriteTemplateFeature](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md) is enabled, true if enabled, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

