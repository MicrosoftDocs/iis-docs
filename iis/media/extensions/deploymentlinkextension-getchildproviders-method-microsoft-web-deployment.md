---
title: DeploymentLinkExtension.GetChildProviders Method  (Microsoft.Web.Deployment)
TOCTitle: GetChildProviders Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentLinkExtension.GetChildProviders(Microsoft.Web.Deployment.DeploymentObject,Microsoft.Web.Deployment.DeploymentAddLinkContext)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentlinkextension.getchildproviders(v=VS.90)
ms:contentKeyID: 20208971
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentLinkExtension.GetChildProviders
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentLinkExtension.GetChildProviders
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# GetChildProviders Method

Gets child providers associated with the current link extension

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustOverrideFunctionGetChildProviders ( _
    objectToExtendAsDeploymentObject, _
    linkContextAsDeploymentAddLinkContext _
) AsIEnumerable(OfDeploymentObjectProvider)
'Usage
DiminstanceAsDeploymentLinkExtensionDimobjectToExtendAsDeploymentObjectDimlinkContextAsDeploymentAddLinkContextDimreturnValueAsIEnumerable(OfDeploymentObjectProvider)

returnValue = instance.GetChildProviders(objectToExtend, _
    linkContext)
```

``` csharp
publicabstractIEnumerable<DeploymentObjectProvider> GetChildProviders(
    DeploymentObjectobjectToExtend,
    DeploymentAddLinkContextlinkContext
)
```

``` c++
public:
virtualIEnumerable<DeploymentObjectProvider^>^ GetChildProviders(
    DeploymentObject^ objectToExtend, 
    DeploymentAddLinkContext^ linkContext
) abstract
```

``` jscript
publicabstractfunctionGetChildProviders(
    objectToExtend : DeploymentObject, 
    linkContext : DeploymentAddLinkContext
) : IEnumerable<DeploymentObjectProvider>
```

#### Parameters

  - objectToExtend  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentObject](deploymentobject-class-microsoft-web-deployment.md)  
    The parent object to extend with child link objects.  

<!-- end list -->

  - linkContext  
    Type: [Microsoft.Web.Deployment. . :: . .DeploymentAddLinkContext](deploymentaddlinkcontext-class-microsoft-web-deployment.md)  
    A [DeploymentAddLinkContext](deploymentaddlinkcontext-class-microsoft-web-deployment.md) used to link child objects to the parent.  

#### Return Value

Type: [System.Collections.Generic. . :: . .IEnumerable](https://msdn.microsoft.com/en-us/library/9eekhta0\(v=vs.90\))\< (Of \< ( \<'[DeploymentObjectProvider](deploymentobjectprovider-class-microsoft-web-deployment.md)\> ) \> ) \>  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentLinkExtension Class](deploymentlinkextension-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

