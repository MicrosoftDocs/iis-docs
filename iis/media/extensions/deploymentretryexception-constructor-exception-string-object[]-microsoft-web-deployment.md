---
title: DeploymentRetryException Constructor (Exception, String, Object[]) (Microsoft.Web.Deployment)
TOCTitle: DeploymentRetryException Constructor (Exception, String, Object[])
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRetryException.#ctor(System.Exception,System.String,System.Object[])
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentretryexception.deploymentretryexception(v=VS.90)
ms:contentKeyID: 20209247
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

# DeploymentRetryException Constructor (Exception, String, Object\[\])

Creates an instance of a [DeploymentRetryException](deploymentretryexception-class-microsoft-web-deployment.md) object with the specified inner exception, message and an array of parameters related to the exception

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    innerExceptionAsException, _
    messageAsString, _
    ParamArrayparametersAsObject() _
)
'Usage
DiminnerExceptionAsExceptionDimmessageAsStringDimparametersAsObject()

DiminstanceAs NewDeploymentRetryException(innerException, _
    message, parameters)
```

``` csharp
publicDeploymentRetryException(
    ExceptioninnerException,
    stringmessage,
    paramsObject[] parameters
)
```

``` c++
public:
DeploymentRetryException(
    Exception^ innerException, 
    String^ message, 
    ... array<Object^>^ parameters
)
```

``` jscript
publicfunctionDeploymentRetryException(
    innerException : Exception, 
    message : String, 
    ... parameters : Object[]
)
```

#### Parameters

  - innerException  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The exception that is the cause of the current exception, or a nullNothingnullptrunita null reference (Nothing in Visual Basic) reference (Nothing in Visual Basic) if no inner exception is specified.  

<!-- end list -->

  - message  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A message that describes the current exception.  

<!-- end list -->

  - parameters  
    Type: array\<[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))\> \[\] () \[\] \[\]  
    An array of parameters related to the exception.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRetryException Class](deploymentretryexception-class-microsoft-web-deployment.md)

[DeploymentRetryException Overload](deploymentretryexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

