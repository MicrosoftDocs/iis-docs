---
title: DeploymentXmlException Constructor (XPathNavigator, String, Exception) (Microsoft.Web.Deployment)
TOCTitle: DeploymentXmlException Constructor (XPathNavigator, String, Exception)
ms:assetid: M:Microsoft.Web.Deployment.DeploymentXmlException.#ctor(System.Xml.XPath.XPathNavigator,System.String,System.Exception)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentxmlexception.deploymentxmlexception(v=VS.90)
ms:contentKeyID: 20209197
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
- Microsoft.Web.Deployment.DeploymentXmlException..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentXmlException Constructor (XPathNavigator, String, Exception)

Creates an instance of a [DeploymentXmlException](deploymentxmlexception-class-microsoft-web-deployment.md) object with an XPathNavigator, the XML file the exception was caused by and a reference to the inner exception that is the cause of this exception.

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicSubNew ( _
    navigatorAsXPathNavigator, _
    fileNameAsString, _
    innerAsException _
)
'Usage
DimnavigatorAsXPathNavigatorDimfileNameAsStringDiminnerAsExceptionDiminstanceAs NewDeploymentXmlException(navigator, _
    fileName, inner)
```

``` csharp
publicDeploymentXmlException(
    XPathNavigatornavigator,
    stringfileName,
    Exceptioninner
)
```

``` c++
public:
DeploymentXmlException(
    XPathNavigator^ navigator, 
    String^ fileName, 
    Exception^ inner
)
```

``` jscript
publicfunctionDeploymentXmlException(
    navigator : XPathNavigator, 
    fileName : String, 
    inner : Exception
)
```

#### Parameters

  - navigator  
    Type: [System.Xml.XPath. . :: . .XPathNavigator](https://msdn.microsoft.com/en-us/library/9x81sf5a\(v=vs.90\))  
    An XPathNavigator for the XML document being evaluated when the exception was thrown.  

<!-- end list -->

  - fileName  
    Type: [System. . :: . .String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))  
    The name of the file that was being evaluated when the exception was thrown.  

<!-- end list -->

  - inner  
    Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    The exception that is the cause of the current exception, or a nullNothingnullptrunita null reference (Nothing in Visual Basic) reference (Nothing in Visual Basic) if no inner exception is specified.  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[DeploymentXmlException Class](deploymentxmlexception-class-microsoft-web-deployment.md)

[DeploymentXmlException Overload](deploymentxmlexception-constructor-microsoft-web-deployment.md)

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

