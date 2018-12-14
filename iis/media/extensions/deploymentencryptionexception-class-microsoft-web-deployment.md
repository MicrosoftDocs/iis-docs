---
title: DeploymentEncryptionException Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentEncryptionException Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentEncryptionException
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentencryptionexception(v=VS.90)
ms:contentKeyID: 20208659
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentEncryptionException
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentEncryptionException
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentEncryptionException Class

Provides an exception that is thrown due to an encryption error in a deployment operation.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
    [Microsoft.Web.Deployment. . :: . .DeploymentFatalException](deploymentfatalexception-class-microsoft-web-deployment.md)  
      Microsoft.Web.Deployment..::..DeploymentEncryptionException  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
PublicClassDeploymentEncryptionException _
    InheritsDeploymentFatalException
'Usage
DiminstanceAsDeploymentEncryptionException
```

``` csharp
[SerializableAttribute]
publicclassDeploymentEncryptionException : DeploymentFatalException
```

``` c++
[SerializableAttribute]
publicref classDeploymentEncryptionException : publicDeploymentFatalException
```

``` jscript
publicclass DeploymentEncryptionException extendsDeploymentFatalException
```

The DeploymentEncryptionException type exposes the following members.

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
<td><a href="deploymentencryptionexception-constructor-microsoft-web-deployment_1.md">DeploymentEncryptionException() () () ()</a></td>
<td>Creates an instance of a DeploymentEncryptionException object with default values.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentencryptionexception-constructor-string-microsoft-web-deployment.md">DeploymentEncryptionException(String)</a></td>
<td>Creates an instance of a DeploymentEncryptionException object with the specified message.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymentencryptionexception-constructor-serializationinfo-streamingcontext-microsoft-web-deployment.md">DeploymentEncryptionException(SerializationInfo, StreamingContext)</a></td>
<td>Creates an instance of a DeploymentEncryptionException object from serialization data.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentencryptionexception-constructor-string-exception-microsoft-web-deployment.md">DeploymentEncryptionException(String, Exception)</a></td>
<td>Creates an instance of a DeploymentEncryptionException object by using the specified message and inner exception.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentencryptionexception-constructor-string-object%5B%5D-microsoft-web-deployment.md">DeploymentEncryptionException(String, array&lt;Object&gt; [] () [] [])</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentencryptionexception-constructor-exception-string-object%5B%5D-microsoft-web-deployment.md">DeploymentEncryptionException(Exception, String, array&lt;Object&gt; [] () [] [])</a></td>
<td></td>
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

