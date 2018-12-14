---
title: DeploymentTraceEventArgs.CollectEventData Method  (Microsoft.Web.Deployment)
TOCTitle: CollectEventData Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentTraceEventArgs.CollectEventData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.collecteventdata(v=VS.90)
ms:contentKeyID: 20209259
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.CollectEventData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.CollectEventData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CollectEventData Method

Collects the event data for the current trace event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedOverridableSubCollectEventData
'Usage
Me.CollectEventData()
```

``` csharp
protectedvirtualvoidCollectEventData()
```

``` c++
protected:
virtualvoidCollectEventData()
```

``` jscript
protectedfunctionCollectEventData()
```

## Remarks

Implementers can override this method to fill default data for a particular event. This method is called the first time that the [EventData](deploymenttraceeventargs-eventdata-property-microsoft-web-deployment.md) property is accessed.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

