---
title: DeploymentSyncParameterCollection Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameterCollection Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentSyncParameterCollection
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparametercollection(v=VS.90)
ms:contentKeyID: 20209293
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterCollection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSyncParameterCollection Class

Provides a collection of [DeploymentSyncParameter](deploymentsyncparameter-class-microsoft-web-deployment.md) objects.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentSyncParameterCollection  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentSyncParameterCollection _
    ImplementsIEnumerable(OfDeploymentSyncParameter), IEnumerable,  _
    IXPathNavigable
'Usage
DiminstanceAsDeploymentSyncParameterCollection
```

``` csharp
publicclassDeploymentSyncParameterCollection : IEnumerable<DeploymentSyncParameter>, 
    IEnumerable, IXPathNavigable
```

``` c++
publicref classDeploymentSyncParameterCollection : IEnumerable<DeploymentSyncParameter^>, 
    IEnumerable, IXPathNavigable
```

``` jscript
publicclass DeploymentSyncParameterCollection implementsIEnumerable<DeploymentSyncParameter>, IEnumerable, IXPathNavigable
```

The DeploymentSyncParameterCollection type exposes the following members.

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
<td><a href="deploymentsyncparametercollection-count-property-microsoft-web-deployment.md">Count</a></td>
<td>Gets the number of <a href="deploymentsyncparameter-class-microsoft-web-deployment.md">DeploymentSyncParameter</a> objects in the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentsyncparametercollection-item-property-int32-microsoft-web-deployment.md">Item[ ( [ ( Int32] ) ] )</a></td>
<td>Gets the <a href="deploymentsyncparameter-class-microsoft-web-deployment.md">DeploymentSyncParameter</a> at the specified index.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentsyncparametercollection-item-property-string-microsoft-web-deployment.md">Item[ ( [ ( String] ) ] )</a></td>
<td>Gets the <a href="deploymentsyncparameter-class-microsoft-web-deployment.md">DeploymentSyncParameter</a> with the specified name.</td>
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
<td><a href="deploymentsyncparametercollection-add-method-microsoft-web-deployment.md">Add</a></td>
<td>Adds a <a href="deploymentsyncparameter-class-microsoft-web-deployment.md">DeploymentSyncParameter</a> to the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-clear-method-microsoft-web-deployment.md">Clear</a></td>
<td>Removes all objects from the current collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-contains-method-microsoft-web-deployment.md">Contains</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-createnavigator-method-microsoft-web-deployment.md">CreateNavigator</a></td>
<td>Creates and returns an XPathNavigator for navigating the current collection.</td>
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
<td><a href="deploymentsyncparametercollection-getenumerator-method-microsoft-web-deployment.md">GetEnumerator</a></td>
<td>Returns an enumerator that iterates through the collection.</td>
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
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-load-method-stream-microsoft-web-deployment.md">Load(Stream)</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-load-method-string-microsoft-web-deployment.md">Load(String)</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-remove-method-microsoft-web-deployment.md">Remove</a></td>
<td>Removes a parameter with the specified name from the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentsyncparametercollection-trygetvalue-method-microsoft-web-deployment.md">TryGetValue</a></td>
<td>Attempts to find the DeploymentSyncParameter with the specified name in the current collection and returns a value indicating whether the operation was successful.</td>
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
<td><a href="deploymentsyncparametercollection-ienumerable-getenumerator-method-microsoft-web-deployment.md">IEnumerable. . :: . .GetEnumerator</a></td>
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

