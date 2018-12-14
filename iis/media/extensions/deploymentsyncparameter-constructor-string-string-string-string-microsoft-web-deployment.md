---
title: DeploymentSyncParameter Constructor (String, String, String, String) (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameter Constructor (String, String, String, String)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameter.#ctor(System.String,System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameter.deploymentsyncparameter(v=VS.90)
ms:contentKeyID: 20208705
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

# DeploymentSyncParameter Constructor (String, String, String, String)

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    descriptionAsString, _
    defaultValueAsString, _
    tagsAsString _
)
'Usage
DimnameAsStringDimdescriptionAsStringDimdefaultValueAsStringDimtagsAsStringDiminstanceAs NewDeploymentSyncParameter(name, description, _
    defaultValue, tags)
```

``` csharp
publicDeploymentSyncParameter(
    stringname,
    stringdescription,
    stringdefaultValue,
    stringtags
)
```

``` c++
public:
DeploymentSyncParameter(
    String^ name, 
    String^ description, 
    String^ defaultValue, 
    String^ tags
)
```

``` jscript
publicfunctionDeploymentSyncParameter(
    name : String, 
    description : String, 
    defaultValue : String, 
    tags : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - description  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - defaultValue  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - tags  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameter Class](deploymentsyncparameter-class-microsoft-web-deployment.md)

[DeploymentSyncParameter Overload](deploymentsyncparameter-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

