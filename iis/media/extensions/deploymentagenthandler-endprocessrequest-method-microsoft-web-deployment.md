---
title: DeploymentAgentHandler.EndProcessRequest Method  (Microsoft.Web.Deployment)
TOCTitle: EndProcessRequest Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentHandler.EndProcessRequest(System.IAsyncResult)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagenthandler.endprocessrequest(v=VS.90)
ms:contentKeyID: 22754057
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentHandler.EndProcessRequest
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentHandler.EndProcessRequest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# EndProcessRequest Method

Returns the result for an asynchronous process.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubEndProcessRequest ( _
    resultAsIAsyncResult _
)
'Usage
DiminstanceAsDeploymentAgentHandlerDimresultAsIAsyncResult

instance.EndProcessRequest(result)
```

``` csharp
publicvoidEndProcessRequest(
    IAsyncResultresult
)
```

``` c++
public:
virtualvoidEndProcessRequest(
    IAsyncResult^ result
) sealed
```

``` jscript
publicfinalfunctionEndProcessRequest(
    result : IAsyncResult
)
```

#### Parameters

  - result  
    Type: [System. . :: . .IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.90\))  
    An IAsyncResult interface that contains the status for the asynchronous operation.  

#### Implements

[IHttpAsyncHandler. . :: . .EndProcessRequest(IAsyncResult)](https://msdn.microsoft.com/en-us/library/2x108swe\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentHandler Class](deploymentagenthandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

