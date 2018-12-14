---
title: DeploymentBaseOptions.LinkExtensions Property  (Microsoft.Web.Deployment)
TOCTitle: LinkExtensions Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.LinkExtensions
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.linkextensions(v=VS.90)
ms:contentKeyID: 20208840
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.LinkExtensions
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_LinkExtensions
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_LinkExtensions
- Microsoft.Web.Deployment.DeploymentBaseOptions.LinkExtensions
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# LinkExtensions Property

Get an enumerable collection of [DeploymentLinkExtension](deploymentlinkextension-class-microsoft-web-deployment.md) objects.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyLinkExtensionsAsIEnumerable(OfDeploymentLinkExtension)
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsIEnumerable(OfDeploymentLinkExtension)

value = instance.LinkExtensions
```

``` csharp
publicIEnumerable<DeploymentLinkExtension> LinkExtensions { get; }
```

``` c++
public:
propertyIEnumerable<DeploymentLinkExtension^>^ LinkExtensions {
    IEnumerable<DeploymentLinkExtension^>^ get ();
}
```

``` jscript
function getLinkExtensions () : IEnumerable<DeploymentLinkExtension>
```

#### Property Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentLinkExtension](deploymentlinkextension-class-microsoft-web-deployment.md)\> ) \> ) \>  
A valid IEnumerable\<[DeploymentLinkExtension](deploymentlinkextension-class-microsoft-web-deployment.md)\> collection interface.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

