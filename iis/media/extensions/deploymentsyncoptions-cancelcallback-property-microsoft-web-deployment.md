---
title: DeploymentSyncOptions.CancelCallback Property  (Microsoft.Web.Deployment)
TOCTitle: CancelCallback Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentSyncOptions.CancelCallback
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncoptions.cancelcallback(v=VS.90)
ms:contentKeyID: 20209067
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncOptions.CancelCallback
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_CancelCallback
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_CancelCallback
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncOptions.CancelCallback
- Microsoft.Web.Deployment.DeploymentSyncOptions.get_CancelCallback
- Microsoft.Web.Deployment.DeploymentSyncOptions.set_CancelCallback
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CancelCallback Property

Gets or sets the CancelCallback delegate that will be called to determine if a sync operation should continue.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicPropertyCancelCallbackAsDeploymentCancelCallback
'Usage
DiminstanceAsDeploymentSyncOptionsDimvalueAsDeploymentCancelCallbackvalue = instance.CancelCallback

instance.CancelCallback = value
```

``` csharp
publicDeploymentCancelCallbackCancelCallback { get; set; }
```

``` c++
public:
propertyDeploymentCancelCallback^ CancelCallback {
    DeploymentCancelCallback^ get ();
    voidset (DeploymentCancelCallback^ value);
}
```

``` jscript
function getCancelCallback () : DeploymentCancelCallbackfunction setCancelCallback (value : DeploymentCancelCallback)
```

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentCancelCallback](deploymentcancelcallback-delegate-microsoft-web-deployment.md)  
The CancelCallback delegate that will be called to determine if a sync operation should continue.  

## Remarks

The delegate should return true to cancel the current operation.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncOptions Class](deploymentsyncoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

