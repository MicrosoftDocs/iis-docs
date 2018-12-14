---
title: DeploymentObjectProvider.GetChildProviders Method  (Microsoft.Web.Deployment)
TOCTitle: GetChildProviders Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentObjectProvider.GetChildProviders
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectprovider.getchildproviders(v=VS.90)
ms:contentKeyID: 20208916
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectProvider.GetChildProviders
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectProvider.GetChildProviders
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetChildProviders Method

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableFunctionGetChildProvidersAsIEnumerable(OfDeploymentObjectProvider)
'Usage
DiminstanceAsDeploymentObjectProviderDimreturnValueAsIEnumerable(OfDeploymentObjectProvider)

returnValue = instance.GetChildProviders()
```

``` csharp
publicvirtualIEnumerable<DeploymentObjectProvider> GetChildProviders()
```

``` c++
public:
virtualIEnumerable<DeploymentObjectProvider^>^ GetChildProviders()
```

``` jscript
publicfunctionGetChildProviders() : IEnumerable<DeploymentObjectProvider>
```

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)\> ) \> ) \>  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentObjectProvider Class](deploymentobjectprovider-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

