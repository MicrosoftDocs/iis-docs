---
title: DeploymentSyncContext.GetState Method  (Microsoft.Web.Deployment)
TOCTitle: GetState Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncContext.GetState(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.getstate(v=VS.90)
ms:contentKeyID: 20209111
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.GetState
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.GetState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetState Method

Gets the value specified from the state table of the current deployment synchronization context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetState ( _
    nameAsString _
) AsObject
'Usage
DiminstanceAsDeploymentSyncContextDimnameAsStringDimreturnValueAsObjectreturnValue = instance.GetState(name)
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
    The name of the value to get from the deployment synchronization state table.  

#### Return Value

Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
An object from the underlying state table that has the specified name.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

