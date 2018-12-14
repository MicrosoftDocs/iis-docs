---
title: DeploymentObjectAttribute Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentObjectAttribute Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentObjectAttribute
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentobjectattribute(v=VS.90)
ms:contentKeyID: 22753922
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentObjectAttribute
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentObjectAttribute
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentObjectAttribute Class

Provides the properties and operator overloads that define an attribute for a DeploymentObjectAttribute class.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Deployment..::..DeploymentObjectAttribute  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentObjectAttribute _
    ImplementsIComparable(OfDeploymentObjectAttribute), IDeploymentNameDescription
'Usage
DiminstanceAsDeploymentObjectAttribute
```

``` csharp
publicclassDeploymentObjectAttribute : IComparable<DeploymentObjectAttribute>, 
    IDeploymentNameDescription
```

``` c++
publicref classDeploymentObjectAttribute : IComparable<DeploymentObjectAttribute^>, 
    IDeploymentNameDescription
```

``` jscript
publicclass DeploymentObjectAttribute implementsIComparable<DeploymentObjectAttribute>, IDeploymentNameDescription
```

The DeploymentObjectAttribute type exposes the following members.

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
<td><a href="deploymentobjectattribute-description-property-microsoft-web-deployment.md">Description</a></td>
<td>Gets the description of the deployment attribute</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentobjectattribute-exampleordetail-property-microsoft-web-deployment.md">ExampleOrDetail</a></td>
<td>BUGBUG</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentobjectattribute-friendlyname-property-microsoft-web-deployment.md">FriendlyName</a></td>
<td>Gets the friendly name of the deployment attribute.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentobjectattribute-kind-property-microsoft-web-deployment.md">Kind</a></td>
<td>Gets the <a href="deploymentobjectattributekind-enumeration-microsoft-web-deployment.md">DeploymentObjectAttributeKind</a> of the deployment attribute.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentobjectattribute-name-property-microsoft-web-deployment.md">Name</a></td>
<td>Gets the name of the deployment attribute.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentobjectattribute-value-property-microsoft-web-deployment.md">Value</a></td>
<td>Gets the value of the deployment attribute.</td>
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
<td><a href="deploymentobjectattribute-compareto-method-microsoft-web-deployment.md">CompareTo</a></td>
<td>Compares a DeploymentObjectAttribute against the current DeploymentObjectAttribute instance to determine if they are equal.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentobjectattribute-equals-method-microsoft-web-deployment.md">Equals</a></td>
<td>Compares a generic object against the current DeploymentObjectAttribute instance to determine if they are equal. (Overrides <a href="https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90)">Object. . :: . .Equals(Object)</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90)">Finalize</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentobjectattribute-gethashcode-method-microsoft-web-deployment.md">GetHashCode</a></td>
<td>Returns the hash code for this DeploymentObjectAttribute. (Overrides <a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">Object. . :: . .GetHashCode() () () ()</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymentobjectattribute-getvalue-t-method-microsoft-web-deployment.md">GetValue&lt; (Of &lt; &lt;' (T&gt; ) &gt; &gt; )</a></td>
<td>BUGBUG</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Operators

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
<td><img src="images/Ee402733.puboperator(en-us,VS.90).gif" title="Public operator" alt="Public operator" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="deploymentobjectattribute-equality-operator-microsoft-web-deployment.md">Equality</a></td>
<td>Determines whether two specified instances of DeploymentObjectAttribute are equal.</td>
</tr>
<tr class="even">
<td><img src="images/Ee402733.puboperator(en-us,VS.90).gif" title="Public operator" alt="Public operator" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="deploymentobjectattribute-greaterthan-operator-microsoft-web-deployment.md">GreaterThan</a></td>
<td>Indicates whether a specified DeploymentObjectAttribute is greater than another specified DeploymentObjectAttribute.</td>
</tr>
<tr class="odd">
<td><img src="images/Ee402733.puboperator(en-us,VS.90).gif" title="Public operator" alt="Public operator" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="deploymentobjectattribute-inequality-operator-microsoft-web-deployment.md">Inequality</a></td>
<td>Indicates whether two DeploymentObjectAttribute instances are not equal.</td>
</tr>
<tr class="even">
<td><img src="images/Ee402733.puboperator(en-us,VS.90).gif" title="Public operator" alt="Public operator" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="deploymentobjectattribute-lessthan-operator-microsoft-web-deployment.md">LessThan</a></td>
<td>Indicates whether a specified DeploymentObjectAttribute is less than another specified DeploymentObjectAttribute.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Deployment Namespace](microsoft-web-deployment-namespace.md)

