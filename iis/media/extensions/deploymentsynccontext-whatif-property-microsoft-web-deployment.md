---
title: DeploymentSyncContext.WhatIf Property  (Microsoft.Web.Deployment)
TOCTitle: WhatIf Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncContext.WhatIf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsynccontext.whatif(v=VS.90)
ms:contentKeyID: 20209244
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncContext.WhatIf
- Microsoft.Web.Deployment.DeploymentSyncContext.get_WhatIf
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncContext.get_WhatIf
- Microsoft.Web.Deployment.DeploymentSyncContext.WhatIf
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# WhatIf Property

Gets a value that determines whether operations should be performed.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyWhatIfAsBoolean
'Usage
DiminstanceAsDeploymentSyncContextDimvalueAsBooleanvalue = instance.WhatIf
```

``` csharp
publicboolWhatIf { get; }
```

``` c++
public:
propertyboolWhatIf {
    boolget ();
}
```

``` jscript
function getWhatIf () : boolean
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the operation should not be performed, otherwise false.  

## Remarks

If set to true, operations will not be executed but events will still be fired specifying what would have happened. If set to false, the synchronization events actually fire.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncContext Class](deploymentsynccontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

