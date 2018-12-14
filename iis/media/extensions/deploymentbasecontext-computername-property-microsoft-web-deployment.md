---
title: DeploymentBaseContext.ComputerName Property  (Microsoft.Web.Deployment)
TOCTitle: ComputerName Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentBaseContext.ComputerName
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.computername(v=VS.90)
ms:contentKeyID: 20208868
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.ComputerName
- Microsoft.Web.Deployment.DeploymentBaseContext.get_ComputerName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.ComputerName
- Microsoft.Web.Deployment.DeploymentBaseContext.get_ComputerName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ComputerName Property

Gets the name of the computer.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyComputerNameAsString
'Usage
DiminstanceAsDeploymentBaseContextDimvalueAsStringvalue = instance.ComputerName
```

``` csharp
publicstringComputerName { get; }
```

``` c++
public:
propertyString^ ComputerName {
    String^ get ();
}
```

``` jscript
function getComputerName () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the name of the computer.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

