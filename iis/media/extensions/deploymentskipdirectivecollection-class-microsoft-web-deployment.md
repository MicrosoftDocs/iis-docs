---
title: DeploymentSkipDirectiveCollection Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentSkipDirectiveCollection Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentskipdirectivecollection(v=VS.90)
ms:contentKeyID: 20208823
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSkipDirectiveCollection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSkipDirectiveCollection Class

Provides a collection of [DeploymentSkipDirective](deploymentskipdirective-class-microsoft-web-deployment.md) objects.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentSkipDirectiveCollection  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
PublicClassDeploymentSkipDirectiveCollection _
    ImplementsICollection(OfDeploymentSkipDirective), IEnumerable(OfDeploymentSkipDirective),  _
    IEnumerable, ISerializable
'Usage
DiminstanceAsDeploymentSkipDirectiveCollection
```

``` csharp
[SerializableAttribute]
publicclassDeploymentSkipDirectiveCollection : ICollection<DeploymentSkipDirective>, 
    IEnumerable<DeploymentSkipDirective>, IEnumerable, ISerializable
```

``` c++
[SerializableAttribute]
publicref classDeploymentSkipDirectiveCollection : ICollection<DeploymentSkipDirective^>, 
    IEnumerable<DeploymentSkipDirective^>, IEnumerable, ISerializable
```

``` jscript
publicclass DeploymentSkipDirectiveCollection implementsICollection<DeploymentSkipDirective>, IEnumerable<DeploymentSkipDirective>, IEnumerable, ISerializable
```

The DeploymentSkipDirectiveCollection type exposes the following members.

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
<td><a href="deploymentskipdirectivecollection-constructor-microsoft-web-deployment.md">DeploymentSkipDirectiveCollection</a></td>
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
<td><a href="deploymentskipdirectivecollection-count-property-microsoft-web-deployment.md">Count</a></td>
<td>Gets the number of <a href="deploymentskipdirective-class-microsoft-web-deployment.md">DeploymentSkipDirective</a> objects in the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentskipdirectivecollection-isreadonly-property-microsoft-web-deployment.md">IsReadOnly</a></td>
<td>Gets a value indicating whether the collection is read-only.</td>
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
<td><a href="deploymentskipdirectivecollection-add-method-deploymentskipdirective-microsoft-web-deployment.md">Add(DeploymentSkipDirective)</a></td>
<td>Adds the specified <a href="deploymentskipdirective-class-microsoft-web-deployment.md">DeploymentSkipDirective</a> instance to the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-add-method-string-string-microsoft-web-deployment.md">Add(String, String)</a></td>
<td>Adds a <a href="deploymentskipdirective-class-microsoft-web-deployment.md">DeploymentSkipDirective</a> object to the current collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-clear-method-microsoft-web-deployment.md">Clear</a></td>
<td>Removes all <a href="deploymentskipdirective-class-microsoft-web-deployment.md">DeploymentSkipDirective</a> objects</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-contains-method-microsoft-web-deployment.md">Contains</a></td>
<td>Gets a value indicating whether the collection contains the specified skip directive.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-copyto-method-microsoft-web-deployment.md">CopyTo</a></td>
<td>Copies the skip directives from the current collection into the specified array, starting at the specified index.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Equals</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-getenumerator-method-microsoft-web-deployment.md">GetEnumerator</a></td>
<td>Gets an enumerator that can be used to iterate through the current collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentskipdirectivecollection-getobjectdata-method-microsoft-web-deployment.md">GetObjectData</a></td>
<td>Fills the current collection with data from the supplied serialization information and context.</td>
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
<td><a href="deploymentskipdirectivecollection-remove-method-microsoft-web-deployment.md">Remove</a></td>
<td>Removes the specified skip directive from the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
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
<td><a href="deploymentskipdirectivecollection-ienumerable-getenumerator-method-microsoft-web-deployment.md">IEnumerable. . :: . .GetEnumerator</a></td>
<td></td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

