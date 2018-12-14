---
title: RewriteTemplateFeature.ServiceProvider Property  (Microsoft.Web.Management.Iis.Rewrite)
TOCTitle: ServiceProvider Property
ms:assetid: P:Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ServiceProvider
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.management.iis.rewrite.rewritetemplatefeature.serviceprovider(v=VS.90)
ms:contentKeyID: 20476377
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ServiceProvider
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_ServiceProvider
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Management.Rewrite.Client.dll
api_name:
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.get_ServiceProvider
- Microsoft.Web.Management.Iis.Rewrite.RewriteTemplateFeature.ServiceProvider
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ServiceProvider Property

Gets the service provider.for the current feature.

**Namespace:**  [Microsoft.Web.Management.Iis.Rewrite](microsoft-web-management-iis-rewrite-namespace.md)  
**Assembly:**  Microsoft.Web.Management.Rewrite.Client (in Microsoft.Web.Management.Rewrite.Client.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyServiceProviderAsIServiceProvider
'Usage
DiminstanceAsRewriteTemplateFeatureDimvalueAsIServiceProvidervalue = instance.ServiceProvider
```

``` csharp
publicIServiceProviderServiceProvider { get; }
```

``` c++
public:
propertyIServiceProvider^ ServiceProvider {
    IServiceProvider^ get ();
}
```

``` jscript
function getServiceProvider () : IServiceProvider
```

#### Property Value

Type: [System. . :: . .IServiceProvider](https://msdn.microsoft.com/en-us/library/zbywf1tw\(v=vs.90\))  
An IServiceProvider interface.  

## Remarks

This base class also implements the IServiceProvider interface. The current service provider can be accessed through the GetService(Type) method.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[RewriteTemplateFeature Class](rewritetemplatefeature-class-microsoft-web-management-iis-rewrite.md)

[Microsoft.Web.Management.Iis.Rewrite Namespace](microsoft-web-management-iis-rewrite-namespace.md)

