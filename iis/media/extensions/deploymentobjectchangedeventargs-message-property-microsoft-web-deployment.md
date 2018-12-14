---
title: DeploymentObjectChangedEventArgs.Message Property  (Microsoft.Web.Deployment)
TOCTitle: Message Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.Message
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectchangedeventargs.message(v=VS.90)
ms:contentKeyID: 20209243
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.Message
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_Message
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.get_Message
- Microsoft.Web.Deployment.DeploymentObjectChangedEventArgs.Message
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
PublicOverridesReadOnlyPropertyMessageAsString
'Usage
DiminstanceAsDeploymentObjectChangedEventArgsDimvalueAsStringvalue = instance.Message
```

``` csharp
publicoverridestringMessage { get; }
```

``` c++
public:
virtualpropertyString^ Message {
    String^ get () override;
}
```

``` jscript
overridefunction getMessage () : String
```

#### Property Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectChangedEventArgs Class](deploymentobjectchangedeventargs-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

