---
title: DeploymentFatalException Constructor (String, Exception) (Microsoft.Web.Deployment)
TOCTitle: DeploymentFatalException Constructor (String, Exception)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentFatalException.#ctor(System.String,System.Exception)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentfatalexception.deploymentfatalexception(v=VS.90)
ms:contentKeyID: 20208720
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

# DeploymentFatalException Constructor (String, Exception)

Creates an instance of a [DeploymentFatalException](deploymentfatalexception-class-microsoft-web-deployment.md) object by using the message and inner exception specified.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    messageAsString, _
    innerAsException _
)
'Usage
DimmessageAsStringDiminnerAsExceptionDiminstanceAs NewDeploymentFatalException(message, _
    inner)
```

``` csharp
publicDeploymentFatalException(
    stringmessage,
    Exceptioninner
)
```

``` c++
public:
DeploymentFatalException(
    String^ message, 
    Exception^ inner
)
```

``` jscript
publicfunctionDeploymentFatalException(
    message : String, 
    inner : Exception
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string that contains detailed information about current exception.  

<!-- end list -->

  - inner  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The inner exception that caused the current exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentFatalException Class](deploymentfatalexception-class-microsoft-web-deployment.md)

[DeploymentFatalException Overload](deploymentfatalexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

