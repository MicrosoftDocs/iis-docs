---
title: DeploymentReplaceRule Constructor  (Microsoft.Web.Deployment)
TOCTitle: DeploymentReplaceRule Constructor
ms:assetid: M:Microsoft.Web.Deployment.DeploymentReplaceRule.#ctor(System.String,System.String,System.String,System.String,System.String,System.String,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentreplacerule.deploymentreplacerule(v=VS.90)
ms:contentKeyID: 20209035
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentReplaceRule.DeploymentReplaceRule
- Microsoft.Web.Deployment.DeploymentReplaceRule.#ctor
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentReplaceRule..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentReplaceRule Constructor

Creates an instance of a deployment replace rule with the specified parameters.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    nameAsString, _
    objectNameAsString, _
    scopeAttributeNameAsString, _
    scopeAttributeValueAsString, _
    targetAttributeNameAsString, _
    matchAsString, _
    replaceAsString _
)
'Usage
DimnameAsStringDimobjectNameAsStringDimscopeAttributeNameAsStringDimscopeAttributeValueAsStringDimtargetAttributeNameAsStringDimmatchAsStringDimreplaceAsStringDiminstanceAs NewDeploymentReplaceRule(name, objectName, _
    scopeAttributeName, scopeAttributeValue, _
    targetAttributeName, match, replace)
```

``` csharp
publicDeploymentReplaceRule(
    stringname,
    stringobjectName,
    stringscopeAttributeName,
    stringscopeAttributeValue,
    stringtargetAttributeName,
    stringmatch,
    stringreplace
)
```

``` c++
public:
DeploymentReplaceRule(
    String^ name, 
    String^ objectName, 
    String^ scopeAttributeName, 
    String^ scopeAttributeValue, 
    String^ targetAttributeName, 
    String^ match, 
    String^ replace
)
```

``` jscript
publicfunctionDeploymentReplaceRule(
    name : String, 
    objectName : String, 
    scopeAttributeName : String, 
    scopeAttributeValue : String, 
    targetAttributeName : String, 
    match : String, 
    replace : String
)
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the rule.  

<!-- end list -->

  - objectName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the object.  

<!-- end list -->

  - scopeAttributeName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The scope attribute name.  

<!-- end list -->

  - scopeAttributeValue  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The scope attribute value.  

<!-- end list -->

  - targetAttributeName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the attribute on the target.  

<!-- end list -->

  - match  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    A regular expression used to perform a case-insensitive match.  

<!-- end list -->

  - replace  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The value used in the replace operation if a match is found.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentReplaceRule Class](deploymentreplacerule-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

