---
title: DeploymentAgentHandler.ProcessRequest Method  (Microsoft.Web.Deployment)
TOCTitle: ProcessRequest Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentHandler.ProcessRequest(System.Web.HttpContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagenthandler.processrequest(v=VS.90)
ms:contentKeyID: 20208647
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentHandler.ProcessRequest
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentHandler.ProcessRequest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ProcessRequest Method

Processes the HTTP Web requests.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubProcessRequest ( _
    contextAsHttpContext _
)
'Usage
DiminstanceAsDeploymentAgentHandlerDimcontextAsHttpContext

instance.ProcessRequest(context)
```

``` csharp
publicvoidProcessRequest(
    HttpContextcontext
)
```

``` c++
public:
virtualvoidProcessRequest(
    HttpContext^ context
) sealed
```

``` jscript
publicfinalfunctionProcessRequest(
    context : HttpContext
)
```

#### Parameters

  - context  
    Type: [System.Web. . :: . .HttpContext](https://msdn.microsoft.com/en-us/library/x08ey989\(v=vs.90\))  
    An [HttpContext](https://msdn.microsoft.com/en-us/library/x08ey989\(v=vs.90\)) object that provides references to the intrinsic server objects (for example, Request, Response, Session, and Server) used to service HTTP requests.  

#### Implements

[IHttpHandler. . :: . .ProcessRequest(HttpContext)](https://msdn.microsoft.com/en-us/library/6hc0fh6a\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentHandler Class](deploymentagenthandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

