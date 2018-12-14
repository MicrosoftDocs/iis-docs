---
title: DeploymentSyncParameterCollection.CreateNavigator Method  (Microsoft.Web.Deployment)
TOCTitle: CreateNavigator Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentSyncParameterCollection.CreateNavigator
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection.createnavigator(v=VS.90)
ms:contentKeyID: 20209282
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.CreateNavigator
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection.CreateNavigator
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CreateNavigator Method

Creates and returns an XPathNavigator for navigating the current collection.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCreateNavigatorAsXPathNavigator
'Usage
DiminstanceAsDeploymentSyncParameterCollectionDimreturnValueAsXPathNavigatorreturnValue = instance.CreateNavigator()
```

``` csharp
publicXPathNavigatorCreateNavigator()
```

``` c++
public:
virtualXPathNavigator^ CreateNavigator() sealed
```

``` jscript
publicfinalfunctionCreateNavigator() : XPathNavigator
```

#### Return Value

Type: [System.Xml.XPath. . :: . .XPathNavigator](https://msdn.microsoft.com/en-us/library/9x81sf5a\(v=vs.90\))  
An XPathNavigator for navigating the current collection.  

#### Implements

[IXPathNavigable. . :: . .CreateNavigator() () () ()](https://msdn.microsoft.com/en-us/library/abtt4by9\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentSyncParameterCollection Class](deploymentsyncparametercollection-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

