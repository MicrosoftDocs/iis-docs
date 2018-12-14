---
title: DeploymentAgentHandler.IsReusable Property  (Microsoft.Web.Deployment)
TOCTitle: IsReusable Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentAgentHandler.IsReusable
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagenthandler.isreusable(v=VS.90)
ms:contentKeyID: 20209072
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentHandler.IsReusable
- Microsoft.Web.Deployment.DeploymentAgentHandler.get_IsReusable
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentHandler.get_IsReusable
- Microsoft.Web.Deployment.DeploymentAgentHandler.IsReusable
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# IsReusable Property

Gets a value indicating whether another request can use the current [DeploymentAgentHandler](deploymentagenthandler-class-microsoft-web-deployment.md) instance.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyPropertyIsReusableAsBoolean
'Usage
DiminstanceAsDeploymentAgentHandlerDimvalueAsBooleanvalue = instance.IsReusable
```

``` csharp
publicboolIsReusable { get; }
```

``` c++
public:
virtualpropertyboolIsReusable {
    boolget () sealed;
}
```

``` jscript
finalfunction getIsReusable () : boolean
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if another request can use the current [DeploymentAgentHandler](deploymentagenthandler-class-microsoft-web-deployment.md) instance, otherwise false.  

#### Implements

[IHttpHandler. . :: . .IsReusable](https://msdn.microsoft.com/en-us/library/s9kb3fws\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentHandler Class](deploymentagenthandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

