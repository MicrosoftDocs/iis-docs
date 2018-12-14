---
title: DeploymentRuleCollection Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentRuleCollection Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentRuleCollection
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentrulecollection(v=VS.90)
ms:contentKeyID: 20208997
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentRuleCollection
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentRuleCollection
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentRuleCollection Class

Represents a collection of [DeploymentRule](deploymentrule-class-microsoft-web-deployment.md) objects.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentRuleCollection  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentRuleCollection _
    ImplementsIEnumerable(OfDeploymentRule), IEnumerable
'Usage
DiminstanceAsDeploymentRuleCollection
```

``` csharp
publicclassDeploymentRuleCollection : IEnumerable<DeploymentRule>, 
    IEnumerable
```

``` c++
publicref classDeploymentRuleCollection : IEnumerable<DeploymentRule^>, 
    IEnumerable
```

``` jscript
publicclass DeploymentRuleCollection implementsIEnumerable<DeploymentRule>, IEnumerable
```

The DeploymentRuleCollection type exposes the following members.

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
<td><a href="deploymentrulecollection-count-property-microsoft-web-deployment.md">Count</a></td>
<td>Gets the number of <a href="deploymentrule-class-microsoft-web-deployment.md">DeploymentRule</a> objects in the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentrulecollection-item-property-int32-microsoft-web-deployment.md">Item[ ( [ ( Int32] ) ] )</a></td>
<td>Gets the <a href="deploymentrule-class-microsoft-web-deployment.md">DeploymentRule</a> at the specified index from the current collection.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentrulecollection-item-property-string-microsoft-web-deployment.md">Item[ ( [ ( String] ) ] )</a></td>
<td>Gets the DeploymentRule with the specified name from the current collection.</td>
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
<td><a href="deploymentrulecollection-add-method-microsoft-web-deployment.md">Add</a></td>
<td>Adds the specified <a href="deploymentrule-class-microsoft-web-deployment.md">DeploymentRule</a> to the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentrulecollection-clear-method-microsoft-web-deployment.md">Clear</a></td>
<td>Removes all objects from the current collection.</td>
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
<td><a href="deploymentrulecollection-getenumerator-method-microsoft-web-deployment.md">GetEnumerator</a></td>
<td>Gets an enumerator that can be used to iterate through the current collection.</td>
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
<td><a href="deploymentrulecollection-remove-method-microsoft-web-deployment.md">Remove</a></td>
<td>Removes the <a href="deploymentrule-class-microsoft-web-deployment.md">DeploymentRule</a> with the specified name from the current collection.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentrulecollection-trygetvalue-method-microsoft-web-deployment.md">TryGetValue</a></td>
<td>Gets a value indicating whether a <a href="deploymentrule-class-microsoft-web-deployment.md">DeploymentRule</a> with the specified name exists in the current collection, and returns the rule in the specified out parameter.</td>
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
<td><a href="deploymentrulecollection-ienumerable-getenumerator-method-microsoft-web-deployment.md">IEnumerable. . :: . .GetEnumerator</a></td>
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

