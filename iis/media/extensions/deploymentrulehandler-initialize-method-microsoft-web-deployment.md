---
title: DeploymentRuleHandler.Initialize Method  (Microsoft.Web.Deployment)
TOCTitle: Initialize Method
ms:assetid: M:Microsoft.Web.Deployment.DeploymentRuleHandler.Initialize(System.Xml.XPath.XPathNavigator,System.String)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulehandler.initialize(v=VS.90)
ms:contentKeyID: 20209203
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Initialize
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleHandler.Initialize
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Initialize Method

Initializes the current [DeploymentRuleHandler](deploymentrulehandler-class-microsoft-web-deployment.md) object.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicOverridableSubInitialize ( _
    navigatorAsXPathNavigator, _
    fileNameAsString _
)
'Usage
DiminstanceAsDeploymentRuleHandlerDimnavigatorAsXPathNavigatorDimfileNameAsString

instance.Initialize(navigator, fileName)
```

``` csharp
publicvirtualvoidInitialize(
    XPathNavigatornavigator,
    stringfileName
)
```

``` c++
public:
virtualvoidInitialize(
    XPathNavigator^ navigator, 
    String^ fileName
)
```

``` jscript
publicfunctionInitialize(
    navigator : XPathNavigator, 
    fileName : String
)
```

#### Parameters

  - navigator  
    Type: [System.Xml.XPath. . :: . .XPathNavigator](https://msdn.microsoft.com/en-us/library/9x81sf5a\(v=vs.90\))  
    An XPath navigator that contains the XML data used to initialize this object.  

<!-- end list -->

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentRuleHandler Class](deploymentrulehandler-class-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

