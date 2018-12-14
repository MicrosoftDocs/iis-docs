---
title: DeploymentXmlException Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentXmlException Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentXmlException
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentxmlexception(v=VS.90)
ms:contentKeyID: 20209004
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentXmlException
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentXmlException
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentXmlException Class

Provides exceptions that are thrown when errors are found in XML configuration.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    DeploymentException  
      Microsoft.Web.Deployment..::..DeploymentXmlException  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
PublicClassDeploymentXmlException _
    InheritsDeploymentException
'Usage
DiminstanceAsDeploymentXmlException
```

``` csharp
[SerializableAttribute]
publicclassDeploymentXmlException : DeploymentException
```

``` c++
[SerializableAttribute]
publicref classDeploymentXmlException : publicDeploymentException
```

``` jscript
publicclass DeploymentXmlException extendsDeploymentException
```

The DeploymentXmlException type exposes the following members.

## Constructors

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentxmlexception-constructor-microsoft-web-deployment_1.md">DeploymentXmlException() () () ()</a></td>
<td>Creates an instance of a DeploymentXmlException object without setting underlying member values.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentxmlexception-constructor-string-microsoft-web-deployment.md">DeploymentXmlException(String)</a></td>
<td>Creates an instance of a DeploymentXmlException object and sets the message specified.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymentxmlexception-constructor-serializationinfo-streamingcontext-microsoft-web-deployment.md">DeploymentXmlException(SerializationInfo, StreamingContext)</a></td>
<td>Creates an instance of a DeploymentXmlException object from serialized data..</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentxmlexception-constructor-string-exception-microsoft-web-deployment.md">DeploymentXmlException(String, Exception)</a></td>
<td>Creates an instance of a DeploymentXmlException object with the specified message and a reference to the inner exception that is the cause of this exception.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentxmlexception-constructor-xpathnavigator-string-exception-microsoft-web-deployment.md">DeploymentXmlException(XPathNavigator, String, Exception)</a></td>
<td>Creates an instance of a DeploymentXmlException object with an XPathNavigator, the XML file the exception was caused by and a reference to the inner exception that is the cause of this exception.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentxmlexception-constructor-xpathnavigator-string-string-object-microsoft-web-deployment.md">DeploymentXmlException(XPathNavigator, String, String, Object)</a></td>
<td>Creates an instance of a DeploymentXmlException object with an XPathNavigator, the XML file the exception was caused by, the message format, and the value that caused the exception.</td>
</tr>
</tbody>
</table>


Top

## Properties

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/2wyfbc48(v=vs.90)">Data</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/71tawy4s(v=vs.90)">HelpLink</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Ee230846.protproperty(en-us,VS.90).gif" title="Protected property" alt="Protected property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/sh5cw61c(v=vs.90)">HResult</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/902sca80(v=vs.90)">InnerException</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/9btwf6wk(v=vs.90)">Message</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/85weac5w(v=vs.90)">Source</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dxzhy005(v=vs.90)">StackTrace</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/2wchw354(v=vs.90)">TargetSite</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
</tbody>
</table>


Top

## Methods

<table>
<thead>
<tr class="header">
<th> </th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/49kcee3b(v=vs.90)">GetBaseException</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/fwb1489e(v=vs.90)">GetObjectData</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/44zb316t(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/es4y6f7e(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/c18k6c59(v=vs.90)">Exception</a>.)</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

