---
title: JobScheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobScheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobScheduler
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobscheduler(v=VS.90)
ms:contentKeyID: 35521071
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobScheduler Class

Provides scheduling capabilities for incoming jobs.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..JobScheduler  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
PublicClassJobScheduler _
    InheritsConfigurationBase
'Usage
DiminstanceAsJobScheduler
```

``` csharp
[SerializableAttribute]
[DataContractAttribute]
publicclassJobScheduler : ConfigurationBase
```

``` c++
[SerializableAttribute]
[DataContractAttribute]
publicref classJobScheduler : publicConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
typeJobScheduler =  
    classinheritConfigurationBaseend
```

``` jscript
publicclass JobScheduler extendsConfigurationBase
```

The JobScheduler type exposes the following members.

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
<td><a href="jobscheduler-constructor-microsoft-web-media-transformmanager_1.md">JobScheduler() () () ()</a></td>
<td>Initializes a new instance of the JobScheduler class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobscheduler-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md">JobScheduler(FileInfo, XElement)</a></td>
<td>Initializes a new instance of the JobScheduler class using the specified file information and job scheduler XML element.</td>
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
<td><a href="configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md">BaseNamespace</a></td>
<td>Gets or sets the XML namespace for the configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobscheduler-concurrentjobs-property-microsoft-web-media-transformmanager.md">ConcurrentJobs</a></td>
<td>Gets or sets the number of concurrent jobs that this scheduler can run.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobscheduler-configurationdirectory-property-microsoft-web-media-transformmanager.md">ConfigurationDirectory</a></td>
<td>Gets the path of the configuration file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md">ConfigurationMessages</a></td>
<td>Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md">ConfigurationMessagesElement</a></td>
<td>Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md">ConfigurationStatus</a></td>
<td>Gets or sets the IIS Transform Manager configuration status. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobscheduler-connectionstring-property-microsoft-web-media-transformmanager.md">ConnectionString</a></td>
<td>Gets or sets the connection string that is used by this scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-description-property-microsoft-web-media-transformmanager.md">Description</a></td>
<td>Gets or sets a description of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md">DescriptionElement</a></td>
<td>Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobscheduler-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the name of this configuration file.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-id-property-microsoft-web-media-transformmanager.md">Id</a></td>
<td>Gets or sets the XML element ID of a configuration object. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-idelement-property-microsoft-web-media-transformmanager.md">IdElement</a></td>
<td>Gets or sets the XML ID element of a configuration object. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobscheduler-jobschedulerelement-property-microsoft-web-media-transformmanager.md">JobSchedulerElement</a></td>
<td>Gets the XML element that contains the scheduler definition.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md">LastModified</a></td>
<td>Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobscheduler-localschedulerfolder-property-microsoft-web-media-transformmanager.md">LocalSchedulerFolder</a></td>
<td>Gets the local scheduler folder name.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobscheduler-localschedulerid-property-microsoft-web-media-transformmanager.md">LocalSchedulerId</a></td>
<td>Gets the local scheduler ID.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevel-property-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md">LogLevelElement</a></td>
<td>Gets or sets an XML element that contains log level details. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets or sets the XML element name of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-nameelement-property-microsoft-web-media-transformmanager.md">NameElement</a></td>
<td>Gets or sets an XML element that contains name details. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobscheduler-schedulertype-property-microsoft-web-media-transformmanager.md">SchedulerType</a></td>
<td>Gets or sets the string token that represents the scheduler type.</td>
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
<td><a href="configurationbase-addconfigurationmessage-method-string-microsoft-web-media-transformmanager.md">AddConfigurationMessage(String)</a></td>
<td>Adds the specified message to the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationbase-addconfigurationmessage-method-string-configurationmessageseverity-microsoft-web-media-transformmanager.md">AddConfigurationMessage(String, ConfigurationMessageSeverity)</a></td>
<td>Adds the specified message to the IIS Transform Manager configuration using the specified severity value. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
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
<td><a href="https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90)">GetHashCode</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90)">GetType</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.protmethod(en-us,VS.90).gif" title="Protected method" alt="Protected method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90)">MemberwiseClone</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationbase-removerestartwarningmessage-method-microsoft-web-media-transformmanager.md">RemoveRestartWarningMessage</a></td>
<td>Removes the restart warning message from the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobscheduler-save-method-microsoft-web-media-transformmanager.md">Save</a></td>
<td>Saves job scheduler details to a file as XML.</td>
</tr>
<tr class="even">
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

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

