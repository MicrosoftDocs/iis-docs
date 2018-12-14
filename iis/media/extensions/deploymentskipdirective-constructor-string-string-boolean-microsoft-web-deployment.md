---
title: DeploymentSkipDirective Constructor (String, String, Boolean) (Microsoft.Web.Deployment)
TOCTitle: DeploymentSkipDirective Constructor (String, String, Boolean)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirective.#ctor(System.String,System.String,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective.deploymentskipdirective(v=VS.90)
ms:contentKeyID: 22753942
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
- Microsoft.Web.Deployment.DeploymentSkipDirective..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSkipDirective Constructor (String, String, Boolean)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    skipDirectiveAsString, _
    enabledAsBoolean _
)
'Usage
DimnameAsStringDimskipDirectiveAsStringDimenabledAsBooleanDiminstanceAs NewDeploymentSkipDirective(name, skipDirective, _
    enabled)
```

``` csharp
publicDeploymentSkipDirective(
    stringname,
    stringskipDirective,
    boolenabled
)
```

``` c++
public:
DeploymentSkipDirective(
    String^ name, 
    String^ skipDirective, 
    boolenabled
)
```

``` jscript
publicfunctionDeploymentSkipDirective(
    name : String, 
    skipDirective : String, 
    enabled : boolean
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - skipDirective  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - enabled  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirective Class](deploymentskipdirective-class-microsoft-web-deployment.md)

[DeploymentSkipDirective Overload](deploymentskipdirective-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

