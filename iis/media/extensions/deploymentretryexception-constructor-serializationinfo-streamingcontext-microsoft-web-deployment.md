---
title: DeploymentRetryException Constructor (SerializationInfo, StreamingContext) (Microsoft.Web.Deployment)
TOCTitle: DeploymentRetryException Constructor (SerializationInfo, StreamingContext)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRetryException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentretryexception.deploymentretryexception(v=VS.90)
ms:contentKeyID: 20208698
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
- Microsoft.Web.Deployment.DeploymentRetryException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentRetryException Constructor (SerializationInfo, StreamingContext)

Creates an instance of a [DeploymentRetryException](deploymentretryexception-class-microsoft-web-deployment.md) object from serialized data.

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
DiminfoAsSerializationInfoDimcontextAsStreamingContextDiminstanceAs NewDeploymentRetryException(info, context)
```

``` csharp
protectedDeploymentRetryException(
    SerializationInfoinfo,
    StreamingContextcontext
)
```

``` c++
protected:
DeploymentRetryException(
    SerializationInfo^ info, 
    StreamingContextcontext
)
```

``` jscript
protectedfunctionDeploymentRetryException(
    info : SerializationInfo, 
    context : StreamingContext
)
```

#### Parameters

  - info  
    Type: [System.Runtime.Serialization. . :: . .SerializationInfo](https://msdn.microsoft.com/en-us/library/a9b6042e\(v=vs.90\))  
    The SerializationInfo that holds the serialized object data about the exception being thrown.  

<!-- end list -->

  - context  
    Type: [System.Runtime.Serialization. . :: . .StreamingContext](https://msdn.microsoft.com/en-us/library/t16abws5\(v=vs.90\))  
    The StreamingContext that contains contextual information about the source or destination.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRetryException Class](deploymentretryexception-class-microsoft-web-deployment.md)

[DeploymentRetryException Overload](deploymentretryexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

