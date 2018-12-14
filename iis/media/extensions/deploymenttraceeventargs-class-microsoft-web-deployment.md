---
title: DeploymentTraceEventArgs Class (Microsoft.Web.Deployment)
TOCTitle: DeploymentTraceEventArgs Class
ms:assetid: T:Microsoft.Web.Deployment.DeploymentTraceEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.deployment.deploymenttraceeventargs(v=VS.90)
ms:contentKeyID: 20208972
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Deployment.dll
api_name:
- Microsoft.Web.Deployment.DeploymentTraceEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# DeploymentTraceEventArgs Class

Provides the base class for arguments that are used in deployment trace events.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [System. . :: . .EventArgs](https://msdn.microsoft.com/en-us/library/118wxtk3\(v=vs.90\))  
    Microsoft.Web.Deployment..::..DeploymentTraceEventArgs  
      [Microsoft.Web.Deployment. . :: . .DependencyCheckTraceEventArgs](dependencychecktraceeventargs-class-microsoft-web-deployment.md)  
      [Microsoft.Web.Deployment. . :: . .DeploymentObjectChangedEventArgs](deploymentobjectchangedeventargs-class-microsoft-web-deployment.md)  
      [Microsoft.Web.Deployment. . :: . .DeploymentSerializationEventArgs](deploymentserializationeventargs-class-microsoft-web-deployment.md)  
      [Microsoft.Web.Deployment. . :: . .DeploymentSyncParameterEventArgs](deploymentsyncparametereventargs-class-microsoft-web-deployment.md)  

**Namespace:**  [Microsoft.Web.Deployment](microsoft-web-deployment-namespace.md)  
**Assembly:**  Microsoft.Web.Deployment (in Microsoft.Web.Deployment.dll)

## Syntax

``` vb
'Declaration
PublicMustInheritClassDeploymentTraceEventArgs _
    InheritsEventArgs _
    ImplementsIXPathNavigable
'Usage
DiminstanceAsDeploymentTraceEventArgs
```

``` csharp
publicabstractclassDeploymentTraceEventArgs : EventArgs, 
    IXPathNavigable
```

``` c++
publicref classDeploymentTraceEventArgsabstract : publicEventArgs, 
    IXPathNavigable
```

``` jscript
publicabstractclass DeploymentTraceEventArgs extendsEventArgsimplementsIXPathNavigable
```

The DeploymentTraceEventArgs type exposes the following members.

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
<td><a href="deploymenttraceeventargs-constructor-microsoft-web-deployment.md">DeploymentTraceEventArgs</a></td>
<td>Creates an instance of event arguments with the specified trace level.</td>
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
<td><a href="deploymenttraceeventargs-eventdata-property-microsoft-web-deployment.md">EventData</a></td>
<td>Gets a dictionary of data associated with the current event argument.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymenttraceeventargs-eventlevel-property-microsoft-web-deployment.md">EventLevel</a></td>
<td>Gets the trace level used by the current event argument.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="deploymenttraceeventargs-message-property-microsoft-web-deployment.md">Message</a></td>
<td>Gets the message associated with the current event argument.</td>
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
<td>Adds data to the current event argument.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="deploymenttraceeventargs-collecteventdata-method-microsoft-web-deployment.md">CollectEventData</a></td>
<td>Collects the event data for the current trace event argument.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="deploymenttraceeventargs-createnavigator-method-microsoft-web-deployment.md">CreateNavigator</a></td>
<td>Creates an XPathNavigator for the current event argument.</td>
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

