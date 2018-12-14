---
title: DeploymentProviderSettingCollection.Item Property  (Microsoft.Web.Deployment)
TOCTitle: Item Property
ms:assetid: P:Microsoft.Web.Deployment.DeploymentProviderSettingCollection.Item(System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettingcollection.item(v=VS.90)
ms:contentKeyID: 20209119
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.Item
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.get_Item
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.get_Item
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.Item
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Item Property

Gets an item with the specified name from the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicReadOnlyDefaultPropertyItem ( _
    nameAsString _
) AsDeploymentProviderSetting
'Usage
DiminstanceAsDeploymentProviderSettingCollectionDimnameAsStringDimvalueAsDeploymentProviderSettingvalue = instance(name)
```

``` csharp
publicDeploymentProviderSettingthis[
    stringname
] { get; }
```

``` c++
public:
propertyDeploymentProviderSetting^ default[String^ name] {
    DeploymentProviderSetting^ get (String^ name);
}
```

``` jscript
JScript does not support indexed properties.
```

#### Parameters

  - name  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the [DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md) to get from the current collection.  

#### Property Value

Type: [Microsoft.Web.Deployment. . :: . .DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md)  
The [DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md) object with the specified name.  

## Remarks

If the collection does not contain an object with the specified name, this method throws a DeploymentException.

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingCollection Class](deploymentprovidersettingcollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

