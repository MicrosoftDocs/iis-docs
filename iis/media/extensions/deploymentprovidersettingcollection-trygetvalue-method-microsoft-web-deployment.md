---
title: DeploymentProviderSettingCollection.TryGetValue Method  (Microsoft.Web.Deployment)
TOCTitle: TryGetValue Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderSettingCollection.TryGetValue(System.String,Microsoft.Web.Deployment.DeploymentProviderSetting@)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettingcollection.trygetvalue(v=VS.90)
ms:contentKeyID: 20208746
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.TryGetValue
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.TryGetValue
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TryGetValue Method

Gets the setting value associated with the specified name.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionTryGetValue ( _
    nameAsString, _
    <OutAttribute> ByRefproviderSettingAsDeploymentProviderSetting _
) AsBoolean
'Usage
DiminstanceAsDeploymentProviderSettingCollectionDimnameAsStringDimproviderSettingAsDeploymentProviderSettingDimreturnValueAsBooleanreturnValue = instance.TryGetValue(name, _
    providerSetting)
```

``` csharp
publicboolTryGetValue(
    stringname,
    outDeploymentProviderSettingproviderSetting
)
```

``` c++
public:
boolTryGetValue(
    String^ name, 
    [OutAttribute] DeploymentProviderSetting^% providerSetting
)
```

``` jscript
publicfunctionTryGetValue(
    name : String, 
    providerSetting : DeploymentProviderSetting
) : boolean
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the value to get.  

<!-- end list -->

  - providerSetting  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md)%  
    When this method returns, contains the value associated with the specified name, if the name is found; otherwise, the default value for the type of the providerSetting parameter. This parameter is passed uninitialized.  

#### Return Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the collection contains an element with the specified name; otherwise, false.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingCollection Class](deploymentprovidersettingcollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

