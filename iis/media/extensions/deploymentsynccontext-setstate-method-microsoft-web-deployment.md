---
title: DeploymentSyncContext.SetState Method  (Microsoft.Web.Deployment)
TOCTitle: SetState Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncContext.SetState(System.String,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.setstate(v=VS.90)
ms:contentKeyID: 20209201
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.SetState
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.SetState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetState Method

Sets or adds the name and value to the underlying state table of the current deployment synchronization context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubSetState ( _
    nameAsString, _
    valueAsObject _
)
'Usage
DiminstanceAsDeploymentSyncContextDimnameAsStringDimvalueAsObject

instance.SetState(name, value)
```

``` csharp
publicvoidSetState(
    stringname,
    Objectvalue
)
```

``` c++
public:
voidSetState(
    String^ name, 
    Object^ value
)
```

``` jscript
publicfunctionSetState(
    name : String, 
    value : Object
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the value to set or add.  

<!-- end list -->

  - value  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    The value to set or add.  

## Remarks

If a value with the specified name already exists, the new value will replace the old value, otherwise, the new value will be added.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

