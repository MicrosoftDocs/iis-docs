---
title: DeploymentTraceEventArgs Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentTraceEventArgs Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentTraceEventArgs.#ctor(System.Diagnostics.TraceLevel)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.deploymenttraceeventargs(v=VS.90)
ms:contentKeyID: 20209303
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.DeploymentTraceEventArgs
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentTraceEventArgs Constructor

Creates an instance of event arguments with the specified trace level.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    eventLevelAsTraceLevel _
)
'Usage
DimeventLevelAsTraceLevelDiminstanceAs NewDeploymentTraceEventArgs(eventLevel)
```

``` csharp
protectedDeploymentTraceEventArgs(
    TraceLeveleventLevel
)
```

``` c++
protected:
DeploymentTraceEventArgs(
    TraceLeveleventLevel
)
```

``` jscript
protectedfunctionDeploymentTraceEventArgs(
    eventLevel : TraceLevel
)
```

#### Parameters

  - eventLevel  
    Type: [System.Diagnostics. . :: . .TraceLevel](https://msdn.microsoft.com/en-us/library/20aafb76\(v=vs.90\))  
    The trace level of the current argument.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

