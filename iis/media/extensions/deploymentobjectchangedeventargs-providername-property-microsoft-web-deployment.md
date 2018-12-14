---
title: DeploymentObjectChangedEventArgs.ProviderName Property  (Microsoft.Web.Deployment)
TOCTitle: ProviderName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.ProviderName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectchangedeventargs.providername(v=VS.90)
ms:contentKeyID: 20209107
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.ProviderName
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_ProviderName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_ProviderName
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.ProviderName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProviderName Property

Gets the name of the deployment provider associated with the current deployment object changed event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyProviderNameAsString
'Usage
DiminstanceAsDeploymentObjectChangedEventArgsDimvalueAsStringvalue = instance.ProviderName
```

``` csharp
publicstringProviderName { get; }
```

``` c++
public:
propertyString^ ProviderName {
    String^ get ();
}
```

``` jscript
function getProviderName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectChangedEventArgs Class](deploymentobjectchangedeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

