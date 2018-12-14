---
title: DeploymentBaseContext.GetState Method  (Microsoft.Web.Deployment)
TOCTitle: GetState Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentBaseContext.GetState(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.getstate(v=VS.90)
ms:contentKeyID: 20209147
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.GetState
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.GetState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetState Method

Gets the value of data from the internal state table.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetState ( _
    nameAsString _
) AsObject
'Usage
DiminstanceAsDeploymentBaseContextDimnameAsStringDimreturnValueAsObjectreturnValue = instance.GetState(name)
```

``` csharp
publicObjectGetState(
    stringname
)
```

``` c++
public:
Object^ GetState(
    String^ name
)
```

``` jscript
publicfunctionGetState(
    name : String
) : Object
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The key name of the value to get from the state table.  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

