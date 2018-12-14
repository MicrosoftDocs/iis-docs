---
title: DeploymentAgentWorkerRequest.SetResponseHeader Method  (Microsoft.Web.Deployment)
TOCTitle: SetResponseHeader Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseHeader(System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagentworkerrequest.setresponseheader(v=VS.90)
ms:contentKeyID: 20209114
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseHeader
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseHeader
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetResponseHeader Method

Sets the specified header in response to the current request.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubSetResponseHeader ( _
    headerNameAsString, _
    headerValueAsString _
)
'Usage
DiminstanceAsDeploymentAgentWorkerRequestDimheaderNameAsStringDimheaderValueAsString

instance.SetResponseHeader(headerName, _
    headerValue)
```

``` csharp
publicabstractvoidSetResponseHeader(
    stringheaderName,
    stringheaderValue
)
```

``` c++
public:
virtualvoidSetResponseHeader(
    String^ headerName, 
    String^ headerValue
) abstract
```

``` jscript
publicabstractfunctionSetResponseHeader(
    headerName : String, 
    headerValue : String
)
```

#### Parameters

  - headerName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the header to set.  

<!-- end list -->

  - headerValue  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The value of the header to set.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentWorkerRequest Class](deploymentagentworkerrequest-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

