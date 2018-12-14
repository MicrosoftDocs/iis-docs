---
title: DeploymentObjectResolver.GetAttributeFriendlyName Method  (Microsoft.Web.Deployment)
TOCTitle: GetAttributeFriendlyName Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeFriendlyName(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectresolver.getattributefriendlyname(v=VS.90)
ms:contentKeyID: 22753875
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeFriendlyName
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectResolver.GetAttributeFriendlyName
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetAttributeFriendlyName Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetAttributeFriendlyName ( _
    deploymentObjectNameAsString, _
    attributeNameAsString _
) AsString
'Usage
DiminstanceAsDeploymentObjectResolverDimdeploymentObjectNameAsStringDimattributeNameAsStringDimreturnValueAsStringreturnValue = instance.GetAttributeFriendlyName(deploymentObjectName, _
    attributeName)
```

``` csharp
publicvirtualstringGetAttributeFriendlyName(
    stringdeploymentObjectName,
    stringattributeName
)
```

``` c++
public:
virtualString^ GetAttributeFriendlyName(
    String^ deploymentObjectName, 
    String^ attributeName
)
```

``` jscript
publicfunctionGetAttributeFriendlyName(
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

