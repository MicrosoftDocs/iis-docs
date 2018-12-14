---
title: DeploymentProviderFactory.ExamplePath Property  (Microsoft.Web.Deployment)
TOCTitle: ExamplePath Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderFactory.ExamplePath
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentproviderfactory.examplepath(v=VS.90)
ms:contentKeyID: 20208809
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderFactory.ExamplePath
- Microsoft.Web.Deployment.DeploymentProviderFactory.get_ExamplePath
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderFactory.ExamplePath
- Microsoft.Web.Deployment.DeploymentProviderFactory.get_ExamplePath
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ExamplePath Property

Gets the example path of the current deployment provider factory.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyExamplePathAsString
'Usage
DiminstanceAsDeploymentProviderFactoryDimvalueAsStringvalue = instance.ExamplePath
```

``` csharp
publicabstractstringExamplePath { get; }
```

``` c++
public:
virtualpropertyString^ ExamplePath {
    String^ get () abstract;
}
```

``` jscript
abstractfunction getExamplePath () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the example path of the current deployment provider factory.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderFactory Class](deploymentproviderfactory-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

