---
title: DeploymentBaseContext.SetState Method  (Microsoft.Web.Deployment)
TOCTitle: SetState Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentBaseContext.SetState(System.String,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.setstate(v=VS.90)
ms:contentKeyID: 20209136
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.SetState
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.SetState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetState Method

Sets a value in the internal state table.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubSetState ( _
    nameAsString, _
    stateAsObject _
)
'Usage
DiminstanceAsDeploymentBaseContextDimnameAsStringDimstateAsObject

instance.SetState(name, state)
```

``` csharp
publicvoidSetState(
    stringname,
    Objectstate
)
```

``` c++
public:
voidSetState(
    String^ name, 
    Object^ state
)
```

``` jscript
publicfunctionSetState(
    name : String, 
    state : Object
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The key name of the value to set in the state table.  

<!-- end list -->

  - state  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The value to set in the state table.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

