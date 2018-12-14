---
title: DeploymentProviderSettingCollection.GetEnumerator Method  (Microsoft.Web.Deployment)
TOCTitle: GetEnumerator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetEnumerator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentprovidersettingcollection.getenumerator(v=VS.90)
ms:contentKeyID: 20209208
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetEnumerator
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentProviderSettingCollection.GetEnumerator
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetEnumerator Method

Gets an enumerator that iterates through the collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionGetEnumeratorAsIEnumerator(OfDeploymentProviderSetting)
'Usage
DiminstanceAsDeploymentProviderSettingCollectionDimreturnValueAsIEnumerator(OfDeploymentProviderSetting)

returnValue = instance.GetEnumerator()
```

``` csharp
publicIEnumerator<DeploymentProviderSetting> GetEnumerator()
```

``` c++
public:
virtualIEnumerator<DeploymentProviderSetting^>^ GetEnumerator() sealed
```

``` jscript
publicfinalfunctionGetEnumerator() : IEnumerator<DeploymentProviderSetting>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerator](https://msdn.microsoft.com/en-us/library/78dfe2yb\(v=vs.90\))\< (Of \< ( \<'[DeploymentProviderSetting](deploymentprovidersetting-class-microsoft-web-deployment.md)\> ) \> ) \>  
Returns an enumerator that iterates through the collection.  

#### Implements

[IEnumerable\< (Of \< ( \<'T\> ) \> ) \>. . :: . .GetEnumerator() () () ()](https://msdn.microsoft.com/en-us/library/s793z9y2\(v=vs.90\))  

## Remarks


> [!NOTE]
> <P>Enumerators can be used to read the data in the collection, but they cannot be used to modify the underlying collection.</P>



## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentProviderSettingCollection Class](deploymentprovidersettingcollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

