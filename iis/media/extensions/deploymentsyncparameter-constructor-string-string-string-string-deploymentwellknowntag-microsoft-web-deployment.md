---
title: DeploymentSyncParameter Constructor (String, String, String, String, DeploymentWellKnownTag) (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameter Constructor (String, String, String, String, DeploymentWellKnownTag)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameter.#ctor(System.String,System.String,System.String,System.String,Microsoft.Web.Deployment.DeploymentWellKnownTag)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.deploymentsyncparameter(v=VS.90)
ms:contentKeyID: 22753985
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
- Microsoft.Web.Deployment.DeploymentSyncParameter..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSyncParameter Constructor (String, String, String, String, DeploymentWellKnownTag)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    friendlyNameAsString, _
    descriptionAsString, _
    defaultValueAsString, _
    tagsAsDeploymentWellKnownTag _
)
'Usage
DimnameAsStringDimfriendlyNameAsStringDimdescriptionAsStringDimdefaultValueAsStringDimtagsAsDeploymentWellKnownTagDiminstanceAs NewDeploymentSyncParameter(name, friendlyName, _
    description, defaultValue, tags)
```

``` csharp
publicDeploymentSyncParameter(
    stringname,
    stringfriendlyName,
    stringdescription,
    stringdefaultValue,
    DeploymentWellKnownTagtags
)
```

``` c++
public:
DeploymentSyncParameter(
    String^ name, 
    String^ friendlyName, 
    String^ description, 
    String^ defaultValue, 
    DeploymentWellKnownTagtags
)
```

``` jscript
publicfunctionDeploymentSyncParameter(
    name : String, 
    friendlyName : String, 
    description : String, 
    defaultValue : String, 
    tags : DeploymentWellKnownTag
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - friendlyName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - description  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - defaultValue  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - tags  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentWellKnownTag](deploymentwellknowntag-enumeration-microsoft-web-deployment.md)  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[DeploymentSyncParameter Overload](deploymentsyncparameter-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

