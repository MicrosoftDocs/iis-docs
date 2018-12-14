---
title: DeploymentEncryptionException Constructor (String) (Microsoft.Web.Deployment)
TOCTitle: DeploymentEncryptionException Constructor (String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentEncryptionException.#ctor(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentencryptionexception.deploymentencryptionexception(v=VS.90)
ms:contentKeyID: 20209216
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

# DeploymentEncryptionException Constructor (String)

Creates an instance of a [DeploymentEncryptionException](deploymentencryptionexception-class-microsoft-web-deployment.md) object with the specified message.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    messageAsString _
)
'Usage
DimmessageAsStringDiminstanceAs NewDeploymentEncryptionException(message)
```

``` csharp
publicDeploymentEncryptionException(
    stringmessage
)
```

``` c++
public:
DeploymentEncryptionException(
    String^ message
)
```

``` jscript
publicfunctionDeploymentEncryptionException(
    message : String
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A string that contains detailed information about the current exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentEncryptionException Class](deploymentencryptionexception-class-microsoft-web-deployment.md)

[DeploymentEncryptionException Overload](deploymentencryptionexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

