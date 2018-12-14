---
title: DeploymentSyncParameterEventArgs.CollectEventData Method  (Microsoft.Web.Deployment)
TOCTitle: CollectEventData Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.CollectEventData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametereventargs.collecteventdata(v=VS.90)
ms:contentKeyID: 22754031
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.CollectEventData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterEventArgs.CollectEventData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CollectEventData Method

Collects the event data for the current synchronization parameter event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedOverridesSubCollectEventData
'Usage
Me.CollectEventData()
```

``` csharp
protectedoverridevoidCollectEventData()
```

``` c++
protected:
virtualvoidCollectEventData() override
```

``` jscript
protectedoverridefunctionCollectEventData()
```

## Remarks

Implementers can override this method to fill default data for a particular event.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterEventArgs Class](deploymentsyncparametereventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

