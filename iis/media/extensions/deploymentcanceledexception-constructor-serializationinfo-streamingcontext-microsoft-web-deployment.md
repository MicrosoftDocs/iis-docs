---
title: DeploymentCanceledException Constructor (SerializationInfo, StreamingContext) (Microsoft.Web.Deployment)
TOCTitle: DeploymentCanceledException Constructor (SerializationInfo, StreamingContext)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentCanceledException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentcanceledexception.deploymentcanceledexception(v=VS.90)
ms:contentKeyID: 20208657
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentCanceledException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentCanceledException Constructor (SerializationInfo, StreamingContext)

Creates an instance of a [DeploymentCanceledException](deploymentcanceledexception-class-microsoft-web-deployment.md) object from serialization information.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
ProtectedSubNew ( _
    infoAsSerializationInfo, _
    contextAsStreamingContext _
)
'Usage
DiminfoAsSerializationInfoDimcontextAsStreamingContextDiminstanceAs NewDeploymentCanceledException(info, context)
```

``` csharp
protectedDeploymentCanceledException(
    SerializationInfoinfo,
    StreamingContextcontext
)
```

``` c++
protected:
DeploymentCanceledException(
    SerializationInfo^ info, 
    StreamingContextcontext
)
```

``` jscript
protectedfunctionDeploymentCanceledException(
    info : SerializationInfo, 
    context : StreamingContext
)
```

#### Parameters

  - info  
    Type: [System.Runtime.Serialization. . :: . .SerializationInfo](https://msdn.microsoft.com/en-us/library/a9b6042e\(v=vs.90\))  
    The SerializationInfo that contains the data used to create the current instance.  

<!-- end list -->

  - context  
    Type: [System.Runtime.Serialization. . :: . .StreamingContext](https://msdn.microsoft.com/en-us/library/t16abws5\(v=vs.90\))  
    The SerializationContext that contains the context used to deserialize the current instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentCanceledException Class](deploymentcanceledexception-class-microsoft-web-deployment.md)

[DeploymentCanceledException Overload](deploymentcanceledexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

