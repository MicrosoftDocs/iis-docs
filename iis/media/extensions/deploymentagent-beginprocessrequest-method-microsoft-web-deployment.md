---
title: DeploymentAgent.BeginProcessRequest Method  (Microsoft.Web.Deployment)
TOCTitle: BeginProcessRequest Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgent.BeginProcessRequest(Microsoft.Web.Deployment.DeploymentAgentWorkerRequest,System.AsyncCallback,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagent.beginprocessrequest(v=VS.90)
ms:contentKeyID: 22754018
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgent.BeginProcessRequest
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgent.BeginProcessRequest
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# BeginProcessRequest Method

Executes an asynchronous [DeploymentAgentWorkerRequest](deploymentagentworkerrequest-class-microsoft-web-deployment.md).

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSharedFunctionBeginProcessRequest ( _
    workerRequestAsDeploymentAgentWorkerRequest, _
    callbackAsAsyncCallback, _
    extraDataAsObject _
) AsIAsyncResult
'Usage
DimworkerRequestAsDeploymentAgentWorkerRequestDimcallbackAsAsyncCallbackDimextraDataAsObjectDimreturnValueAsIAsyncResultreturnValue = DeploymentAgent.BeginProcessRequest(workerRequest, _
    callback, extraData)
```

``` csharp
publicstaticIAsyncResultBeginProcessRequest(
    DeploymentAgentWorkerRequestworkerRequest,
    AsyncCallbackcallback,
    ObjectextraData
)
```

``` c++
public:
staticIAsyncResult^ BeginProcessRequest(
    DeploymentAgentWorkerRequest^ workerRequest, 
    AsyncCallback^ callback, 
    Object^ extraData
)
```

``` jscript
publicstaticfunctionBeginProcessRequest(
    workerRequest : DeploymentAgentWorkerRequest, 
    callback : AsyncCallback, 
    extraData : Object
) : IAsyncResult
```

#### Parameters

  - workerRequest  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentAgentWorkerRequest](deploymentagentworkerrequest-class-microsoft-web-deployment.md)  
    The current request.  

<!-- end list -->

  - callback  
    Type: [System. . :: . .AsyncCallback](https://msdn.microsoft.com/en-us/library/ckbe7yh5\(v=vs.90\))  
    The AsyncCallback delegate to call when the asynchronous operation completes.  

<!-- end list -->

  - extraData  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    An object that contains any additional data for the request.  

#### Return Value

Type: [System. . :: . .IAsyncResult](https://msdn.microsoft.com/en-us/library/ft8a6455\(v=vs.90\))  
An IAsyncResult interface that contains the status for the asynchronous operation.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgent Class](deploymentagent-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

