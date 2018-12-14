---
title: DeploymentObjectResolver.GetAttributeDescription Method  (Microsoft.Web.Deployment)
TOCTitle: GetAttributeDescription Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeDescription(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getattributedescription(v=VS.90)
ms:contentKeyID: 22753863
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeDescription
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeDescription
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAttributeDescription Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetAttributeDescription ( _
    deploymentObjectNameAsString, _
    attributeNameAsString _
) AsString
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectNameAsStringDimattributeNameAsStringDimreturnValueAsStringreturnValue = instance.GetAttributeDescription(deploymentObjectName, _
    attributeName)
```

``` csharp
publicvirtualstringGetAttributeDescription(
    stringdeploymentObjectName,
    stringattributeName
)
```

``` c++
public:
virtualString^ GetAttributeDescription(
    String^ deploymentObjectName, 
    String^ attributeName
)
```

``` jscript
publicfunctionGetAttributeDescription(
    deploymentObjectName : String, 
    attributeName : String
) : String
```

#### Parameters

  - deploymentObjectName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - attributeName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectResolver Class](deploymentobjectresolver-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

