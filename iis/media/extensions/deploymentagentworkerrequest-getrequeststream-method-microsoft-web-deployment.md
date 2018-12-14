---
title: DeploymentAgentWorkerRequest.GetRequestStream Method  (Microsoft.Web.Deployment)
TOCTitle: GetRequestStream Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestStream
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagentworkerrequest.getrequeststream(v=VS.90)
ms:contentKeyID: 22754069
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestStream
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestStream
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetRequestStream Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionGetRequestStreamAsStream
'Usage
DiminstanceAsDeploymentAgentWorkerRequestDimreturnValueAsStreamreturnValue = instance.GetRequestStream()
```

``` csharp
publicabstractStreamGetRequestStream()
```

``` c++
public:
virtualStream^ GetRequestStream() abstract
```

``` jscript
publicabstractfunctionGetRequestStream() : Stream
```

#### Return Value

Type: [System.IO. . :: . .Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentWorkerRequest Class](deploymentagentworkerrequest-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

