---
title: DeploymentFatalException Constructor (SerializationInfo, StreamingContext) (Microsoft.Web.Deployment)
TOCTitle: DeploymentFatalException Constructor (SerializationInfo, StreamingContext)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentFatalException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentfatalexception.deploymentfatalexception(v=VS.90)
ms:contentKeyID: 20208755
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
- Microsoft.Web.Deployment.DeploymentFatalException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentFatalException Constructor (SerializationInfo, StreamingContext)

Creates an instance of a [DeploymentFatalException](deploymentfatalexception-class-microsoft-web-deployment.md) object by using serialization data.

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
DiminfoAsSerializationInfoDimcontextAsStreamingContextDiminstanceAs NewDeploymentFatalException(info, context)
```

``` csharp
protectedDeploymentFatalException(
    SerializationInfoinfo,
    StreamingContextcontext
)
```

``` c++
protected:
DeploymentFatalException(
    SerializationInfo^ info, 
    StreamingContextcontext
)
```

``` jscript
protectedfunctionDeploymentFatalException(
    info : SerializationInfo, 
    context : StreamingContext
)
```

#### Parameters

  - info  
    Type: [System.Runtime.Serialization. . :: . .SerializationInfo](https://msdn.microsoft.com/en-us/library/a9b6042e\(v=vs.90\))  
    The SerializationInfo that contains information needed to construct the current object instance.  

<!-- end list -->

  - context  
    Type: [System.Runtime.Serialization. . :: . .StreamingContext](https://msdn.microsoft.com/en-us/library/t16abws5\(v=vs.90\))  
    The SerializationContext used to construct the current object instance.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentFatalException Class](deploymentfatalexception-class-microsoft-web-deployment.md)

[DeploymentFatalException Overload](deploymentfatalexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

