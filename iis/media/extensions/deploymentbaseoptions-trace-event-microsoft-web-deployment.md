---
title: DeploymentBaseOptions.Trace Event (Microsoft.Web.Deployment)
TOCTitle: Trace Event
ms:assetid: E:Microsoft.Web.Deployment.DeploymentBaseOptions.Trace
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.trace(v=VS.90)
ms:contentKeyID: 20208791
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.Trace
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.add_Trace
- Microsoft.Web.Deployment.DeploymentBaseOptions.remove_Trace
- Microsoft.Web.Deployment.DeploymentBaseOptions.Trace
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Trace Event

An event to indicate when a deployment trace event has occurred.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
Public Event TraceAsEventHandler(OfDeploymentTraceEventArgs)
'Usage
DiminstanceAsDeploymentBaseOptionsDimhandlerAsEventHandler(OfDeploymentTraceEventArgs)

AddHandler instance.Trace, handler
```

``` csharp
public event EventHandler<DeploymentTraceEventArgs> Trace
```

``` c++
public:
 eventEventHandler<DeploymentTraceEventArgs^>^ Trace {
    voidadd (EventHandler<DeploymentTraceEventArgs^>^ value);
    voidremove (EventHandler<DeploymentTraceEventArgs^>^ value);
}
```

``` jscript
JScript does not support events.
```

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

