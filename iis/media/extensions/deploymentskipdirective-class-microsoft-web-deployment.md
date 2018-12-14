---
title: DeploymentSkipDirective Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentSkipDirective Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentSkipDirective
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirective(v=VS.90)
ms:contentKeyID: 20209124
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirective
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirective
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSkipDirective Class

Defines a skip directive for a deployment, which specifies data that should be ignored during a deployment.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentSkipDirective  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentSkipDirective _
    ImplementsIEnumerable(OfDeploymentSkipDirectiveEntry), IEnumerable,  _
    IDeploymentNameDescription
'Usage
DiminstanceAsDeploymentSkipDirective
```

``` csharp
publicclassDeploymentSkipDirective : IEnumerable<DeploymentSkipDirectiveEntry>, 
    IEnumerable, IDeploymentNameDescription
```

``` c++
publicref classDeploymentSkipDirective : IEnumerable<DeploymentSkipDirectiveEntry^>, 
    IEnumerable, IDeploymentNameDescription
```

``` jscript
publicclass DeploymentSkipDirective implementsIEnumerable<DeploymentSkipDirectiveEntry>, IEnumerable, IDeploymentNameDescription
```

The DeploymentSkipDirective type exposes the following members.

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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymentskipdirective-constructor-string-microsoft-web-deployment.md">DeploymentSkipDirective(String)</a></td>
<td>Creates an instance of a DeploymentSkipDirective object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirective-constructor-string-string-microsoft-web-deployment.md">DeploymentSkipDirective(String, String)</a></td>
<td>Creates an instance of a DeploymentSkipDirective object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirective-constructor-string-string-boolean-microsoft-web-deployment.md">DeploymentSkipDirective(String, String, Boolean)</a></td>
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
<td><a href="deploymentskipdirective-count-property-microsoft-web-deployment.md">Count</a></td>
<td>Gets the number of <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> objects in the current DeploymentSkipDirective object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-description-property-microsoft-web-deployment.md">Description</a></td>
<td>Gets the description of the current DeploymentSkipDirective object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-enabled-property-microsoft-web-deployment.md">Enabled</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-exampleordetail-property-microsoft-web-deployment.md">ExampleOrDetail</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-friendlyname-property-microsoft-web-deployment.md">FriendlyName</a></td>
<td>Gets the friendly name of the current DeploymentSkipDirective object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-item-property-microsoft-web-deployment.md">Item</a></td>
<td>Gets a single <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> from the current object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirective-name-property-microsoft-web-deployment.md">Name</a></td>
<td>The name of the current deployment skip directive.</td>
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
<td><a href="deploymentskipdirective-add-method-microsoft-web-deployment.md">Add</a></td>
<td>Adds a <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> to the current object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirective-clear-method-microsoft-web-deployment.md">Clear</a></td>
<td>Removes all <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> objects from the current instance.</td>
</tr>
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
<td><a href="deploymentskipdirective-getenumerator-method-microsoft-web-deployment.md">GetEnumerator</a></td>
<td>Gets an enumerator that can be used to iterate through the <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> objects in the current instance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
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
<td><a href="deploymentskipdirective-remove-method-microsoft-web-deployment.md">Remove</a></td>
<td>Removes a <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> object with the specified name from the current instance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirective-trygetvalue-method-microsoft-web-deployment.md">TryGetValue</a></td>
<td>Attempts to get the value of the <a href="deploymentskipdirectiveentry-class-microsoft-web-deployment.md">DeploymentSkipDirectiveEntry</a> with the specified name from the current object instance.</td>
</tr>
</tbody>
</table>


Top

## Explicit Interface Implementations

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
<td><img src="images/Dd566080.pubinterface(en-us,VS.90).gif" title="Explicit interface implemetation" alt="Explicit interface implemetation" /><img src="images/Ff728198.privmethod(en-us,VS.90).gif" title="Private method" alt="Private method" /></td>
<td><a href="deploymentskipdirective-ienumerable-getenumerator-method-microsoft-web-deployment.md">IEnumerable. . :: . .GetEnumerator</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## Remarks

Skip directives include objectName, keyAttribute, xpath, absolutePath, or any attribute. All of the elements of the skip directives for an object must be true for that object to be skipped in a dump or synchronization operation.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

