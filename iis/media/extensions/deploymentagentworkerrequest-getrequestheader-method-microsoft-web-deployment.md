---
title: DeploymentAgentWorkerRequest.GetRequestHeader Method  (Microsoft.Web.Deployment)
TOCTitle: GetRequestHeader Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestHeader(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagentworkerrequest.getrequestheader(v=VS.90)
ms:contentKeyID: 20209280
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestHeader
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.GetRequestHeader
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetRequestHeader Method

Gets a string that contains the specified header from the current request.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionGetRequestHeader ( _
    headerNameAsString _
) AsString
'Usage
DiminstanceAsDeploymentAgentWorkerRequestDimheaderNameAsStringDimreturnValueAsStringreturnValue = instance.GetRequestHeader(headerName)
```

``` csharp
publicabstractstringGetRequestHeader(
    stringheaderName
)
```

``` c++
public:
virtualString^ GetRequestHeader(
    String^ headerName
) abstract
```

``` jscript
publicabstractfunctionGetRequestHeader(
    headerName : String
) : String
```

#### Parameters

  - headerName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the header to read.  

#### Return Value

Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
A string that contains the specified header from the current request.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentWorkerRequest Class](deploymentagentworkerrequest-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

