---
title: DeploymentTraceEventArgs.Message Property  (Microsoft.Web.Deployment)
TOCTitle: Message Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentTraceEventArgs.Message
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs.message(v=VS.90)
ms:contentKeyID: 20208835
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.Message
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_Message
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.get_Message
- Microsoft.Web.Deployment.DeploymentTraceEventArgs.Message
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Message Property

Gets the message associated with the current event argument.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyMessageAsString
'Usage
DiminstanceAsDeploymentTraceEventArgsDimvalueAsStringvalue = instance.Message
```

``` csharp
publicabstractstringMessage { get; }
```

``` c++
public:
virtualpropertyString^ Message {
    String^ get () abstract;
}
```

``` jscript
abstractfunction getMessage () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
The message associated with the current event argument.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentTraceEventArgs Class](deploymenttraceeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

