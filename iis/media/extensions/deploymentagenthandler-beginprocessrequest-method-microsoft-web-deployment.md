---
title: DeploymentAgentHandler.BeginProcessRequest Method  (Microsoft.Web.Deployment)
TOCTitle: BeginProcessRequest Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentHandler.BeginProcessRequest(System.Web.HttpContext,System.AsyncCallback,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagenthandler.beginprocessrequest(v=VS.90)
ms:contentKeyID: 22753885
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentHandler.BeginProcessRequest
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentHandler.BeginProcessRequest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# BeginProcessRequest Method

Executes an asynchronous process request for the current HttpContext.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionBeginProcessRequest ( _
    contextAsHttpContext, _
    cbAsAsyncCallback, _
    extraDataAsObject _
) AsIAsyncResult
'Usage
DiminstanceAsDeploymentAgentHandlerDimcontextAsHttpContextDimcbAsAsyncCallbackDimextraDataAsObjectDimreturnValueAsIAsyncResultreturnValue = instance.BeginProcessRequest(context, _
    cb, extraData)
```

``` csharp
publicIAsyncResultBeginProcessRequest(
    HttpContextcontext,
    AsyncCallbackcb,
    ObjectextraData
)
```

``` c++
public:
virtualIAsyncResult^ BeginProcessRequest(
    HttpContext^ context, 
    AsyncCallback^ cb, 
    Object^ extraData
) sealed
```

``` jscript
publicfinalfunctionBeginProcessRequest(
    context : HttpContext, 
    cb : AsyncCallback, 
    extraData : Object
) : IAsyncResult
```

#### Parameters

  - context  
    Type: [System.Web. . :: . .HttpContext](https://msdn.microsoft.com/en-us/library/x08ey989\(v=vs.90\))  
    An HttpContext class that represents the current HTTP context.  

<!-- end list -->

  - cb  
    Type: [System. . :: . .AsyncCallback](https://msdn.microsoft.com/en-us/library/ckbe7yh5\(v=vs.90\))  
    An AsyncCallback delegate to be called when the asynchronous operation completes.  

<!-- end list -->

  - extraData  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    An object that contains any additional data for the request.  

#### Return Value

Type: [System. . :: . .IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.90\))  
An IAsyncResult interface that contains the status for the asynchronous operation.  

#### Implements

[IHttpAsyncHandler. . :: . .BeginProcessRequest(HttpContext, AsyncCallback, Object)](https://msdn.microsoft.com/en-us/library/k9be58k0\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentHandler Class](deploymentagenthandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

