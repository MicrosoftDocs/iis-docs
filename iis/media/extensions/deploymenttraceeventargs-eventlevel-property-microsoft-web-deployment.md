---
title: DeploymentTraceEventArgs.EventLevel Property  (Microsoft.Web.Deployment)
TOCTitle: EventLevel Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventLevel
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.eventlevel(v=VS.90)
ms:contentKeyID: 20208706
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventLevel
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_EventLevel
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.EventLevel
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_EventLevel
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EventLevel Property

Gets the trace level used by the current event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyEventLevelAsTraceLevel
'Usage
DiminstanceAsDeploymentTraceEventArgsDimvalueAsTraceLevelvalue = instance.EventLevel
```

``` csharp
publicTraceLevelEventLevel { get; }
```

``` c++
public:
propertyTraceLevelEventLevel {
    TraceLevelget ();
}
```

``` jscript
function getEventLevel () : TraceLevel
```

#### Property Value

Type: [System.Diagnostics. . :: . .TraceLevel](https://msdn.microsoft.com/en-us/library/20aafb76\(v=vs.90\))  
The trace level used by the current event argument.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

