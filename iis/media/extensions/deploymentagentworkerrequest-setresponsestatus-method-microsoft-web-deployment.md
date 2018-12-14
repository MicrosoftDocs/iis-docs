---
title: DeploymentAgentWorkerRequest.SetResponseStatus Method  (Microsoft.Web.Deployment)
TOCTitle: SetResponseStatus Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseStatus(System.Int32,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentagentworkerrequest.setresponsestatus(v=VS.90)
ms:contentKeyID: 20209084
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseStatus
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentAgentWorkerRequest.SetResponseStatus
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SetResponseStatus Method

Sets the response status code and description.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideSubSetResponseStatus ( _
    codeAsInteger, _
    descriptionAsString _
)
'Usage
DiminstanceAsDeploymentAgentWorkerRequestDimcodeAsIntegerDimdescriptionAsString

instance.SetResponseStatus(code, description)
```

``` csharp
publicabstractvoidSetResponseStatus(
    intcode,
    stringdescription
)
```

``` c++
public:
virtualvoidSetResponseStatus(
    intcode, 
    String^ description
) abstract
```

``` jscript
publicabstractfunctionSetResponseStatus(
    code : int, 
    description : String
)
```

#### Parameters

  - code  
    Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
    The integer response code  

<!-- end list -->

  - description  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The description of the response type.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentAgentWorkerRequest Class](deploymentagentworkerrequest-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

