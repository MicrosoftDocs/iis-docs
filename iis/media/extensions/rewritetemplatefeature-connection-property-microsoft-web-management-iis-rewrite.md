---
title: RewriteTemplateFeature.Connection Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: Connection Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Connection
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.connection(v=VS.90)
ms:contentKeyID: 20476336
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Connection
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Connection
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.Connection
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_Connection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Connection Property

Gets the Connection service that represents the current management unit.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyConnectionAsConnection
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsConnectionvalue = instance.Connection
```

``` csharp
publicConnectionConnection { get; }
```

``` c++
public:
propertyConnection^ Connection {
    Connection^ get ();
}
```

``` jscript
function getConnection () : Connection
```

#### Property Value

Type: [Microsoft.Web.Management.Client. . :: . .Connection](https://msdn.microsoft.com/en-us/library/ms614892\(v=vs.90\))  
A Connection instance that represents the current management unit.  

## Remarks

The connection service is useful for obtaining information about the current IIS 7 management session.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

