---
title: DeploymentEncryptionException Constructor (String, Exception) (Microsoft.Web.Deployment)
TOCTitle: DeploymentEncryptionException Constructor (String, Exception)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentEncryptionException.#ctor(System.String,System.Exception)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentencryptionexception.deploymentencryptionexception(v=VS.90)
ms:contentKeyID: 20208818
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
- Microsoft.Web.Deployment.DeploymentEncryptionException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentEncryptionException Constructor (String, Exception)

Creates an instance of a [DeploymentEncryptionException](deploymentencryptionexception-class-microsoft-web-deployment.md) object by using the specified message and inner exception.

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
DimmessageAsStringDiminnerAsExceptionDiminstanceAs NewDeploymentEncryptionException(message, _
    inner)
```

``` csharp
publicDeploymentEncryptionException(
    stringmessage,
    Exceptioninner
)
```

``` c++
public:
DeploymentEncryptionException(
    String^ message, 
    Exception^ inner
)
```

``` jscript
publicfunctionDeploymentEncryptionException(
    message : String, 
    inner : Exception
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string that contains detailed information about the current exception.  

<!-- end list -->

  - inner  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The inner exception that caused the current exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentEncryptionException Class](deploymentencryptionexception-class-microsoft-web-deployment.md)

[DeploymentEncryptionException Overload](deploymentencryptionexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

