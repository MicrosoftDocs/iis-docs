---
title: JobDefinition Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobDefinition Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobDefinition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobdefinition(v=VS.90)
ms:contentKeyID: 35521054
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobDefinition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobDefinition Class

Defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..JobDefinition  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
PublicClassJobDefinition _
    InheritsConfigurationBase
'Usage
DiminstanceAsJobDefinition
```

``` csharp
[SerializableAttribute]
[DataContractAttribute]
publicclassJobDefinition : ConfigurationBase
```

``` c++
[SerializableAttribute]
[DataContractAttribute]
publicref classJobDefinition : publicConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
typeJobDefinition =  
    classinheritConfigurationBaseend
```

``` jscript
publicclass JobDefinition extendsConfigurationBase
```

The JobDefinition type exposes the following members.

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
<td><a href="jobdefinition-constructor-microsoft-web-media-transformmanager_1.md">JobDefinition() () () ()</a></td>
<td>Initializes a new instance of the JobDefinition class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobdefinition-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md">JobDefinition(FileInfo, XElement)</a></td>
<td>Initializes a new instance of the JobDefinition class using the specified file and job definition information.</td>
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
<td><a href="jobdefinition-assetretentionperioddisplayunit-property-microsoft-web-media-transformmanager.md">AssetRetentionPeriodDisplayUnit</a></td>
<td>Gets or sets a value that indicates how long the assets that are associated with a job are retained.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md">AssetRetentionPeriodMinutes</a></td>
<td>Gets or sets the number of minutes that the asset files that are associated with a job are retained after they are selected for deletion during maintenance.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md">BaseNamespace</a></td>
<td>Gets or sets the XML namespace for the configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-concurrentjobs-property-microsoft-web-media-transformmanager.md">ConcurrentJobs</a></td>
<td>Gets or sets the number of concurrent jobs that the job manager can start when it uses this job definition.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-configurationdirectory-property-microsoft-web-media-transformmanager.md">ConfigurationDirectory</a></td>
<td>Gets the path of the job definition configuration file.</td>
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
<td><a href="jobdefinition-credentialid-property-microsoft-web-media-transformmanager.md">CredentialId</a></td>
<td>Gets or sets a GUID that identifies the credential that is associated with this job definition.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-deletecanceledfiles-property-microsoft-web-media-transformmanager.md">DeleteCanceledFiles</a></td>
<td>Gets or sets a value that indicates whether asset files for canceled jobs should be deleted during the maintenance cycle.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-deletefailedfiles-property-microsoft-web-media-transformmanager.md">DeleteFailedFiles</a></td>
<td>Gets or sets a value that indicates whether asset files for failed jobs should be deleted during the maintenance cycle.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-deletefinishedfiles-property-microsoft-web-media-transformmanager.md">DeleteFinishedFiles</a></td>
<td>Gets or sets a value that indicates whether asset files for finished jobs should be deleted during the maintenance cycle.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-description-property-microsoft-web-media-transformmanager.md">Description</a></td>
<td>Gets or sets a description of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md">DescriptionElement</a></td>
<td>Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-enabled-property-microsoft-web-media-transformmanager.md">Enabled</a></td>
<td>Gets or sets a value that indicates whether the job manager that is associated with this job definition can be started.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-enforcefilenamecase-property-microsoft-web-media-transformmanager.md">EnforceFileNameCase</a></td>
<td>Gets or sets a value that indicates whether the file names referenced in the manifest must match in case.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the name of the configuration file for the current job definition.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-id-property-microsoft-web-media-transformmanager.md">Id</a></td>
<td>Gets or sets the XML element ID of a configuration object. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-idelement-property-microsoft-web-media-transformmanager.md">IdElement</a></td>
<td>Gets or sets the XML ID element of a configuration object. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-inputfolder-property-microsoft-web-media-transformmanager.md">InputFolder</a></td>
<td>Gets or sets the input folder name. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-inputfolderpath-property-microsoft-web-media-transformmanager.md">InputFolderPath</a></td>
<td>Gets or sets the input folder path. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-inputismanifest-property-microsoft-web-media-transformmanager.md">InputIsManifest</a></td>
<td>Gets or sets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-isjobmanagerrunning-property-microsoft-web-media-transformmanager.md">IsJobManagerRunning</a></td>
<td>Gets or sets a value that indicates whether the job manager that is associated with this job definition is running.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-jobmanagerloglevel-property-microsoft-web-media-transformmanager.md">JobManagerLogLevel</a></td>
<td>Gets or sets the threshold value of log entries that are written to the job manager log.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-jobmanagerlogrolloverintervaldisplayunit-property-microsoft-web-media-transformmanager.md">JobManagerLogRolloverIntervalDisplayUnit</a></td>
<td>Gets or sets the unit of time that is used with the <a href="jobdefinition-jobmanagerlogrolloverintervalminutes-property-microsoft-web-media-transformmanager.md">JobDefinition..::..JobManagerLogRolloverIntervalMinutes</a> property to indicate when to create a new log.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-jobmanagerlogrolloverintervalminutes-property-microsoft-web-media-transformmanager.md">JobManagerLogRolloverIntervalMinutes</a></td>
<td>Gets or sets the number of minutes of log data to collect before a new log file is created.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md">LastModified</a></td>
<td>Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-localfilewatcherfilter-property-microsoft-web-media-transformmanager.md">LocalFileWatcherFilter</a></td>
<td>Gets or sets a file filter value that is used to initiate job creation.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-logfolder-property-microsoft-web-media-transformmanager.md">LogFolder</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-logfoldernamejobinstances-property-microsoft-web-media-transformmanager.md">LogFolderNameJobInstances</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-logfolderwatchfoldermanager-property-microsoft-web-media-transformmanager.md">LogFolderWatchFolderManager</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevel-property-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md">LogLevelElement</a></td>
<td>Gets or sets an XML element that contains log level details. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-logretentionperioddisplayunit-property-microsoft-web-media-transformmanager.md">LogRetentionPeriodDisplayUnit</a></td>
<td>Gets or sets the unit of time that is used with the <a href="jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md">LogRetentionPeriodMinutes</a> property to indicate how long the log file that is associated with a job is retained.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md">LogRetentionPeriodMinutes</a></td>
<td>Gets or sets the number of minutes that the log that is associated with a job is retained before being deleted during maintenance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-maintenancecommand-property-microsoft-web-media-transformmanager.md">MaintenanceCommand</a></td>
<td></td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-maintenanceintervaldisplayunit-property-microsoft-web-media-transformmanager.md">MaintenanceIntervalDisplayUnit</a></td>
<td>Gets or sets the unit of time that is used with the <a href="jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md">MaintenanceIntervalMinutes</a> property to indicate how often maintenance is run.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md">MaintenanceIntervalMinutes</a></td>
<td>Gets or sets the number of minutes between maintenance-processing activities.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-maintenancetime-property-microsoft-web-media-transformmanager.md">MaintenanceTime</a></td>
<td>Gets or sets a fixed time during the day to run maintenance.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-maintenanceuseinterval-property-microsoft-web-media-transformmanager.md">MaintenanceUseInterval</a></td>
<td>Gets or sets a value that indicates that maintenance should be run at a specified interval instead of at a fixed time.</td>
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
<td><a href="jobdefinition-nodetaskcodepathx64-property-microsoft-web-media-transformmanager.md">NodeTaskCodePathX64</a></td>
<td>Gets or sets a location for x64 binary files.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-nodetaskcodepathx86-property-microsoft-web-media-transformmanager.md">NodeTaskCodePathX86</a></td>
<td>Gets or sets a location for x86 binary files.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-notificationincludelogforfailedjob-property-microsoft-web-media-transformmanager.md">NotificationIncludeLogForFailedJob</a></td>
<td>Gets or sets a value that specifies that the log that is associated with a failed job will be included in a failure notification POST request.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-notifications-property-microsoft-web-media-transformmanager.md">Notifications</a></td>
<td>Gets or sets a collection of the job notifications that trigger a notification POST request.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-notificationurl-property-microsoft-web-media-transformmanager.md">NotificationUrl</a></td>
<td>Gets or sets a URL to which HTTP POST request notifications are sent.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-outputfolder-property-microsoft-web-media-transformmanager.md">OutputFolder</a></td>
<td>Gets or sets the output folder for a job. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-outputfolderpath-property-microsoft-web-media-transformmanager.md">OutputFolderPath</a></td>
<td>Gets or sets the output folder path for a job. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-priority-property-microsoft-web-media-transformmanager.md">Priority</a></td>
<td>Gets or sets the priority of a job.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-processpriority-property-microsoft-web-media-transformmanager.md">ProcessPriority</a></td>
<td></td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulercpudisplayunit-property-microsoft-web-media-transformmanager.md">SchedulerCpuDisplayUnit</a></td>
<td>Gets or sets an HPC CPU unit value.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md">SchedulerCpus</a></td>
<td>Gets or sets a CPU value based on the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulerid-property-microsoft-web-media-transformmanager.md">SchedulerId</a></td>
<td>Gets or sets the ID of the scheduler that is associated with this job definition.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md">SchedulerMemory</a></td>
<td>Gets or sets a memory value based on the scheduler.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md">SchedulerNodeGroups</a></td>
<td>Gets or sets a list of compute nodes.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulerproperties-property-microsoft-web-media-transformmanager.md">SchedulerProperties</a></td>
<td>Gets a list of additional scheduler properties.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-schedulerusenodeprofile-property-microsoft-web-media-transformmanager.md">SchedulerUseNodeProfile</a></td>
<td>Gets or sets a value that determines whether the HPC scheduler should use the <a href="jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md">SchedulerCpus</a>, <a href="jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md">SchedulerMemory</a>, and <a href="jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md">SchedulerNodeGroups</a> properties when a job is transformed.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-templateid-property-microsoft-web-media-transformmanager.md">TemplateId</a></td>
<td>Gets or sets the ID of the job template that the JobDefinition object uses.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-templatename-property-microsoft-web-media-transformmanager.md">TemplateName</a></td>
<td>Gets or sets the name of the job template that the current JobDefinition object uses.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-watchfolder-property-microsoft-web-media-transformmanager.md">WatchFolder</a></td>
<td>Gets or sets a file system folder that will be watched for files that will instantiate jobs.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobdefinition-workfolder-property-microsoft-web-media-transformmanager.md">WorkFolder</a></td>
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
<td><a href="jobdefinition-save-method-microsoft-web-media-transformmanager.md">Save</a></td>
<td>Saves member variables to an XML file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-setjobtemplates-method-microsoft-web-media-transformmanager.md">SetJobTemplates</a></td>
<td>Sets or refreshes the job template collection. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90)">ToString</a></td>
<td>(Inherited from <a href="https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)">Object</a>.)</td>
</tr>
</tbody>
</table>


Top

## Fields

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
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-credentialidattributename-field-microsoft-web-media-transformmanager.md">CredentialIdAttributeName</a></td>
<td>Represents a constant that is used when the id attribute of the credential element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-jobtemplateidattributename-field-microsoft-web-media-transformmanager.md">JobTemplateIdAttributeName</a></td>
<td>Represents a constant that is used when the job template id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulercpucores-field-microsoft-web-media-transformmanager.md">SchedulerCpuCores</a></td>
<td>Represents a constant that is used when an HPC scheduling cores element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulercpunodes-field-microsoft-web-media-transformmanager.md">SchedulerCpuNodes</a></td>
<td>Represents a constant that is used when an HPC scheduling nodes element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulercpusattributename-field-microsoft-web-media-transformmanager.md">SchedulerCpusAttributeName</a></td>
<td>Represents a constant that is used when the scheduler cpus attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulercpusockets-field-microsoft-web-media-transformmanager.md">SchedulerCpuSockets</a></td>
<td>Represents a constant that is used when an HPC scheduling CPU sockets element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-scheduleridattributename-field-microsoft-web-media-transformmanager.md">SchedulerIdAttributeName</a></td>
<td>Represents a constant that is used when the scheduler id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulermemoryattributename-field-microsoft-web-media-transformmanager.md">SchedulerMemoryAttributeName</a></td>
<td>Represents a constant that is used when the scheduler memory attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulernodegroupsattributename-field-microsoft-web-media-transformmanager.md">SchedulerNodeGroupsAttributeName</a></td>
<td>Represents a constant that is used when the scheduler nodeGroups attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-schedulerusenodeprofileattributename-field-microsoft-web-media-transformmanager.md">SchedulerUseNodeProfileAttributeName</a></td>
<td>Represents a constant that is used when the scheduler useNodeProfile attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobdefinition-taskidattributename-field-microsoft-web-media-transformmanager.md">TaskIdAttributeName</a></td>
<td>Represents a constant that is used when the task id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
</tbody>
</table>


Top

## Remarks

A job definition maps three pieces of data: a job template, a scheduler, and a watch folder. A [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object creates jobs based on the job definition. The JobDefinition object maps [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects to FileSystemWatcher objects. The FileSystemWatcher object monitors a folder for jobs. When a file that matches a filter arrives in the watch folder, the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object uses the job template to create a set of tasks on the job scheduler and then dispatches the job.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

