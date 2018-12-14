---
title: DeploymentSyncParameterChangedEventArgs Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentSyncParameterChangedEventArgs Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentSyncParameterChangedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymentsyncparameterchangedeventargs(v=VS.90)
ms:contentKeyID: 20208778
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentSyncParameterChangedEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentSyncParameterChangedEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentSyncParameterChangedEventArgs Class

Provides the properties for an event argument that is raised when a synchronization parameter changes.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    [Microsoft.Web.Deployment. . :: . .DeploymentTraceEventArgs](deploymenttraceeventargs-class-microsoft-web-deployment.md)  
      [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterEventArgs](deploymentsyncparametereventargs-class-microsoft-web-deployment.md)  
        Microsoft.Web.Deployment..::..DeploymentSyncParameterChangedEventArgs  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicClassDeploymentSyncParameterChangedEventArgs _
    InheritsDeploymentSyncParameterEventArgs
'Usage
DiminstanceAsDeploymentSyncParameterChangedEventArgs
```

``` csharp
publicclassDeploymentSyncParameterChangedEventArgs : DeploymentSyncParameterEventArgs
```

``` c++
publicref classDeploymentSyncParameterChangedEventArgs : publicDeploymentSyncParameterEventArgs
```

``` jscript
publicclass DeploymentSyncParameterChangedEventArgs extendsDeploymentSyncParameterEventArgs
```

The DeploymentSyncParameterChangedEventArgs type exposes the following members.

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
<td><a href="deploymenttraceeventargs-eventdata-property-microsoft-web-deployment.md">EventData</a></td>
<td>Gets a dictionary of data associated with the current event argument. (Inherited from <a href="deploymenttraceeventargs-class-microsoft-web-deployment.md">DeploymentTraceEventArgs</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymenttraceeventargs-eventlevel-property-microsoft-web-deployment.md">EventLevel</a></td>
<td>Gets the trace level used by the current event argument. (Inherited from <a href="deploymenttraceeventargs-class-microsoft-web-deployment.md">DeploymentTraceEventArgs</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentsyncparameterchangedeventargs-message-property-microsoft-web-deployment.md">Message</a></td>
<td>Gets the message for the current event argument. (Overrides <a href="deploymenttraceeventargs-message-property-microsoft-web-deployment.md">DeploymentTraceEventArgs. . :: . .Message</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentsyncparametereventargs-name-property-microsoft-web-deployment.md">Name</a></td>
<td>Gets the name associated with the event arguments for a deployment synchronization parameter. (Inherited from <a href="deploymentsyncparametereventargs-class-microsoft-web-deployment.md">DeploymentSyncParameterEventArgs</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymentsyncparametereventargs-operationtype-property-microsoft-web-deployment.md">OperationType</a></td>
<td>Gets the DeploymentOperationKind associated with the event arguments for a deployment synchronization parameter. (Inherited from <a href="deploymentsyncparametereventargs-class-microsoft-web-deployment.md">DeploymentSyncParameterEventArgs</a>.)</td>
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
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymenttraceeventargs-addeventdata-method-microsoft-web-deployment.md">AddEventData</a></td>
<td>Adds data to the current event argument. (Inherited from <a href="deploymenttraceeventargs-class-microsoft-web-deployment.md">DeploymentTraceEventArgs</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymentsyncparametereventargs-collecteventdata-method-microsoft-web-deployment.md">CollectEventData</a></td>
<td>Collects the event data for the current synchronization parameter event argument. (Inherited from <a href="deploymentsyncparametereventargs-class-microsoft-web-deployment.md">DeploymentSyncParameterEventArgs</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymenttraceeventargs-createnavigator-method-microsoft-web-deployment.md">CreateNavigator</a></td>
<td>Creates an XPathNavigator for the current event argument. (Inherited from <a href="deploymenttraceeventargs-class-microsoft-web-deployment.md">DeploymentTraceEventArgs</a>.)</td>
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

