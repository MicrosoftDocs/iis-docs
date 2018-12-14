---
title: DeploymentSkipRule Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentSkipRule Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipRule.#ctor(System.String,System.String,System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskiprule.deploymentskiprule(v=VS.90)
ms:contentKeyID: 22753906
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipRule.DeploymentSkipRule
- Microsoft.Web.Deployment.DeploymentSkipRule.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipRule..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSkipRule Constructor

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    skipActionAsString, _
    objectNameAsString, _
    absolutePathAsString, _
    xpathAsString _
)
'Usage
DimnameAsStringDimskipActionAsStringDimobjectNameAsStringDimabsolutePathAsStringDimxpathAsStringDiminstanceAs NewDeploymentSkipRule(name, skipAction, _
    objectName, absolutePath, xpath)
```

``` csharp
publicDeploymentSkipRule(
    stringname,
    stringskipAction,
    stringobjectName,
    stringabsolutePath,
    stringxpath
)
```

``` c++
public:
DeploymentSkipRule(
    String^ name, 
    String^ skipAction, 
    String^ objectName, 
    String^ absolutePath, 
    String^ xpath
)
```

``` jscript
publicfunctionDeploymentSkipRule(
    name : String, 
    skipAction : String, 
    objectName : String, 
    absolutePath : String, 
    xpath : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - skipAction  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - objectName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - absolutePath  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - xpath  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipRule Class](deploymentskiprule-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

