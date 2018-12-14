---
title: DeploymentBaseOptions.PrefetchPayload Property  (Microsoft.Web.Deployment)
TOCTitle: PrefetchPayload Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseOptions.PrefetchPayload
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.prefetchpayload(v=VS.90)
ms:contentKeyID: 20209269
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.PrefetchPayload
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_PrefetchPayload
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_PrefetchPayload
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.get_PrefetchPayload
- Microsoft.Web.Deployment.DeploymentBaseOptions.PrefetchPayload
- Microsoft.Web.Deployment.DeploymentBaseOptions.set_PrefetchPayload
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# PrefetchPayload Property

Gets or sets a value that indicates whether a deployment request contains a prefetch payload.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyPrefetchPayloadAsBoolean
'Usage
DiminstanceAsDeploymentBaseOptionsDimvalueAsBooleanvalue = instance.PrefetchPayload

instance.PrefetchPayload = value
```

``` csharp
publicboolPrefetchPayload { get; set; }
```

``` c++
public:
propertyboolPrefetchPayload {
    boolget ();
    voidset (boolvalue);
}
```

``` jscript
function getPrefetchPayload () : booleanfunction setPrefetchPayload (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the request contains a prefetch payload, otherwise false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

