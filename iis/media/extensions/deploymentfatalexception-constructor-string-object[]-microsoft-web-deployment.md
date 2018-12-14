---
title: DeploymentFatalException Constructor (String, Object[]) (Microsoft.Web.Deployment)
TOCTitle: DeploymentFatalException Constructor (String, Object[])
ms:assetid: M:Microsoft.Web.Deployment.DeploymentFatalException.#ctor(System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentfatalexception.deploymentfatalexception(v=VS.90)
ms:contentKeyID: 20209232
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

# DeploymentFatalException Constructor (String, Object\[\])

Creates an instance of a [DeploymentFatalException](deploymentfatalexception-class-microsoft-web-deployment.md) object with the specified message and array of parameters.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    messageAsString, _
    ParamArrayparametersAsObject() _
)
'Usage
DimmessageAsStringDimparametersAsObject()

DiminstanceAs NewDeploymentFatalException(message, _
    parameters)
```

``` csharp
publicDeploymentFatalException(
    stringmessage,
    paramsObject[] parameters
)
```

``` c++
public:
DeploymentFatalException(
    String^ message, 
    ... array<Object^>^ parameters
)
```

``` jscript
publicfunctionDeploymentFatalException(
    message : String, 
    ... parameters : Object[]
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string that contains detailed information about current exception.  

<!-- end list -->

  - parameters  
    Type: array\<[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> \[\] () \[\] \[\]  
    An array of parameters that provides additional information about the current exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentFatalException Class](deploymentfatalexception-class-microsoft-web-deployment.md)

[DeploymentFatalException Overload](deploymentfatalexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

