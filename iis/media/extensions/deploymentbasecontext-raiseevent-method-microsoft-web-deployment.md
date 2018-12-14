---
title: DeploymentBaseContext.RaiseEvent Method  (Microsoft.Web.Deployment)
TOCTitle: RaiseEvent Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentBaseContext.RaiseEvent(Microsoft.Web.Deployment.DeploymentTraceEventArgs)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext.raiseevent(v=VS.90)
ms:contentKeyID: 20209012
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext.RaiseEvent
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext.RaiseEvent
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# RaiseEvent Method

Raises a deployment trace event with the specified arguments.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubRaiseEvent ( _
    traceEventAsDeploymentTraceEventArgs _
)
'Usage
DiminstanceAsDeploymentBaseContextDimtraceEventAsDeploymentTraceEventArgs

instance.RaiseEvent(traceEvent)
```

``` csharp
publicvoidRaiseEvent(
    DeploymentTraceEventArgstraceEvent
)
```

``` c++
public:
voidRaiseEvent(
    DeploymentTraceEventArgs^ traceEvent
)
```

``` jscript
publicfunctionRaiseEvent(
    traceEvent : DeploymentTraceEventArgs
)
```

#### Parameters

  - traceEvent  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentTraceEventArgs](deploymenttraceeventargs-class-microsoft-web-deployment.md)  
    The event arguments to pass to the trace event this method raises.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseContext Class](deploymentbasecontext-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

