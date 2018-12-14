---
title: DeploymentAgentWorkerRequest.ResponseStream Property  (Microsoft.Web.Deployment)
TOCTitle: ResponseStream Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.ResponseStream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagentworkerrequest.responsestream(v=VS.90)
ms:contentKeyID: 20208962
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.ResponseStream
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.get_ResponseStream
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.get_ResponseStream
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.ResponseStream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ResponseStream Property

Gets the response stream for the current [DeploymentAgentWorkerRequest](deploymentagentworkerrequest-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideReadOnlyPropertyResponseStreamAsStream
'Usage
DiminstanceAsDeploymentAgentWorkerRequestDimvalueAsStreamvalue = instance.ResponseStream
```

``` csharp
publicabstractStreamResponseStream { get; }
```

``` c++
public:
virtualpropertyStream^ ResponseStream {
    Stream^ get () abstract;
}
```

``` jscript
abstractfunction getResponseStream () : Stream
```

#### Property Value

Type: [System.IO. . :: . .Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.90\))  
The response stream for the current [DeploymentAgentWorkerRequest](deploymentagentworkerrequest-class-microsoft-web-deployment.md) object.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentWorkerRequest Class](deploymentagentworkerrequest-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

