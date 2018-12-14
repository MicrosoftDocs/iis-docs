---
title: DeploymentBaseContext Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentBaseContext Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentBaseContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentbasecontext(v=VS.90)
ms:contentKeyID: 20209172
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentBaseContext
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentBaseContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentBaseContext Class

Contains properties and methods that define the base context of a deployment operation.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentBaseContext  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentBaseContext
'Usage
DiminstanceAsDeploymentBaseContext
```

``` csharp
publicclassDeploymentBaseContext
```

``` c++
publicref classDeploymentBaseContext
```

``` jscript
publicclass DeploymentBaseContext
```

The DeploymentBaseContext type exposes the following members.

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
<td><a href="deploymentbasecontext-authenticationtype-property-microsoft-web-deployment.md">AuthenticationType</a></td>
<td>Gets or sets a string that determines the type of authentication to use in the deployment operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-commitcontext-property-microsoft-web-deployment.md">CommitContext</a></td>
<td>Gets the context of a deployment commit operation.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-computername-property-microsoft-web-deployment.md">ComputerName</a></td>
<td>Gets the name of the computer.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-encryptpassword-property-microsoft-web-deployment.md">EncryptPassword</a></td>
<td>Gets the encrypted password.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-includeacls-property-microsoft-web-deployment.md">IncludeAcls</a></td>
<td>Gets a value that indicates whether security descriptors will be added to the deployment context.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-isdestinationobject-property-microsoft-web-deployment.md">IsDestinationObject</a></td>
<td>Gets a value that determines if the current instance is a destination object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-password-property-microsoft-web-deployment.md">Password</a></td>
<td>Gets the password used to access the deployment location.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-prefetchpayload-property-microsoft-web-deployment.md">PrefetchPayload</a></td>
<td>Gets a value that indicates whether a deployment request contains a prefetch payload.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-retryattempts-property-microsoft-web-deployment.md">RetryAttempts</a></td>
<td>Gets the number of times to attempt a deployment operation.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-retryinterval-property-microsoft-web-deployment.md">RetryInterval</a></td>
<td>Gets the interval, in milliseconds, to wait between retry attempts.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-username-property-microsoft-web-deployment.md">UserName</a></td>
<td>Gets the username used to access the deployment location.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentbasecontext-webserverconfiguration-property-microsoft-web-deployment.md">WebServerConfiguration</a></td>
<td></td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbasecontext-getstate-method-microsoft-web-deployment.md">GetState</a></td>
<td>Gets the value of data from the internal state table.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbasecontext-raiseevent-method-microsoft-web-deployment.md">RaiseEvent</a></td>
<td>Raises a deployment trace event with the specified arguments.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentbasecontext-setstate-method-microsoft-web-deployment.md">SetState</a></td>
<td>Sets a value in the internal state table.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

