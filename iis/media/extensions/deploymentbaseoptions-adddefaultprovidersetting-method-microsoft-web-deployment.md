---
title: DeploymentBaseOptions.AddDefaultProviderSetting Method  (Microsoft.Web.Deployment)
TOCTitle: AddDefaultProviderSetting Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentBaseOptions.AddDefaultProviderSetting(System.String,System.String,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbaseoptions.adddefaultprovidersetting(v=VS.90)
ms:contentKeyID: 20579892
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseOptions.AddDefaultProviderSetting
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseOptions.AddDefaultProviderSetting
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# AddDefaultProviderSetting Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubAddDefaultProviderSetting ( _
    providerNameAsString, _
    settingNameAsString, _
    settingValueAsObject _
)
'Usage
DiminstanceAsDeploymentBaseOptionsDimproviderNameAsStringDimsettingNameAsStringDimsettingValueAsObject

instance.AddDefaultProviderSetting(providerName, _
    settingName, settingValue)
```

``` csharp
publicvoidAddDefaultProviderSetting(
    stringproviderName,
    stringsettingName,
    ObjectsettingValue
)
```

``` c++
public:
voidAddDefaultProviderSetting(
    String^ providerName, 
    String^ settingName, 
    Object^ settingValue
)
```

``` jscript
publicfunctionAddDefaultProviderSetting(
    providerName : String, 
    settingName : String, 
    settingValue : Object
)
```

#### Parameters

  - providerName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - settingName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

<!-- end list -->

  - settingValue  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentBaseOptions Class](deploymentbaseoptions-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

