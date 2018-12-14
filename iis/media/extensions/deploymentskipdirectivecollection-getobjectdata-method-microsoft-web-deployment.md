---
title: DeploymentSkipDirectiveCollection.GetObjectData Method  (Microsoft.Web.Deployment)
TOCTitle: GetObjectData Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection.getobjectdata(v=VS.90)
ms:contentKeyID: 20208898
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.GetObjectData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection.GetObjectData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetObjectData Method

Fills the current collection with data from the supplied serialization information and context.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags := SecurityPermissionFlag.SerializationFormatter)> _
PublicOverridableSubGetObjectData ( _
    infoAsSerializationInfo, _
    contextAsStreamingContext _
)
'Usage
DiminstanceAsDeploymentSkipDirectiveCollectionDiminfoAsSerializationInfoDimcontextAsStreamingContext

instance.GetObjectData(info, context)
```

``` csharp
[SecurityPermissionAttribute(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
publicvirtualvoidGetObjectData(
    SerializationInfoinfo,
    StreamingContextcontext
)
```

``` c++
[SecurityPermissionAttribute(SecurityAction::LinkDemand, Flags = SecurityPermissionFlag::SerializationFormatter)]
public:
virtualvoidGetObjectData(
    SerializationInfo^ info, 
    StreamingContextcontext
)
```

``` jscript
publicfunctionGetObjectData(
    info : SerializationInfo, 
    context : StreamingContext
)
```

#### Parameters

  - info  
    Type: [System.Runtime.Serialization. . :: . .SerializationInfo](https://msdn.microsoft.com/en-us/library/a9b6042e\(v=vs.90\))  
    The serializationinfo used to deserialize the current collection.  

<!-- end list -->

  - context  
    Type: [System.Runtime.Serialization. . :: . .StreamingContext](https://msdn.microsoft.com/en-us/library/t16abws5\(v=vs.90\))  
    The serializationdata used to deserialize the current collection.  

#### Implements

[ISerializable. . :: . .GetObjectData(SerializationInfo, StreamingContext)](https://msdn.microsoft.com/en-us/library/27cxsdk6\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSkipDirectiveCollection Class](deploymentskipdirectivecollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

