---
title: DeploymentProviderOptions Constructor (String) (Microsoft.Web.Deployment)
TOCTitle: DeploymentProviderOptions Constructor (String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderOptions.#ctor(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovideroptions.deploymentprovideroptions(v=VS.90)
ms:contentKeyID: 20208799
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderOptions..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentProviderOptions Constructor (String)

Creates an instance of a DeploymentProviderOptions object with the specified factory name.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    factoryNameAsString _
)
'Usage
DimfactoryNameAsStringDiminstanceAs NewDeploymentProviderOptions(factoryName)
```

``` csharp
publicDeploymentProviderOptions(
    stringfactoryName
)
```

``` c++
public:
DeploymentProviderOptions(
    String^ factoryName
)
```

``` jscript
publicfunctionDeploymentProviderOptions(
    factoryName : String
)
```

#### Parameters

  - factoryName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the factory used to populate the values of the current object.  

## Remarks

This method searches for the factory name specified by the factoryName. If the factory is not found, this method throws a DeploymentException.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderOptions Class](deploymentprovideroptions-class-microsoft-web-deployment.md)

[DeploymentProviderOptions Overload](deploymentprovideroptions-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

