---
title: DeploymentXmlException Constructor (String, Exception) (Microsoft.Web.Deployment)
TOCTitle: DeploymentXmlException Constructor (String, Exception)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentXmlException.#ctor(System.String,System.Exception)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentxmlexception.deploymentxmlexception(v=VS.90)
ms:contentKeyID: 20209236
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
- Microsoft.Web.Deployment.DeploymentXmlException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentXmlException Constructor (String, Exception)

Creates an instance of a [DeploymentXmlException](deploymentxmlexception-class-microsoft-web-deployment.md) object with the specified message and a reference to the inner exception that is the cause of this exception.

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
DimmessageAsStringDiminnerAsExceptionDiminstanceAs NewDeploymentXmlException(message, _
    inner)
```

``` csharp
publicDeploymentXmlException(
    stringmessage,
    Exceptioninner
)
```

``` c++
public:
DeploymentXmlException(
    String^ message, 
    Exception^ inner
)
```

``` jscript
publicfunctionDeploymentXmlException(
    message : String, 
    inner : Exception
)
```

#### Parameters

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A message that describes the current exception.  

<!-- end list -->

  - inner  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The exception that is the cause of the current exception, or a nullNothingnullptrunita null reference (Nothing in Visual Basic) reference (Nothing in Visual Basic) if no inner exception is specified.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentXmlException Class](deploymentxmlexception-class-microsoft-web-deployment.md)

[DeploymentXmlException Overload](deploymentxmlexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

