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
- csharp
- jscript
- vb
- FSharp
- cpp
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
---

# JobDefinition Class

Defines how IIS Transform Manager monitors, creates, schedules, and maintains jobs.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [Microsoft.Web.Media.TransformManager.ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..JobDefinition  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
Public Class JobDefinition _
    Inherits ConfigurationBase
'Usage

  Dim instance As JobDefinition
```

```csharp
[SerializableAttribute]
[DataContractAttribute]
public class JobDefinition : ConfigurationBase
```

```cpp
[SerializableAttribute]
[DataContractAttribute]
public ref class JobDefinition : public ConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
type JobDefinition =  
    class
        inherit ConfigurationBase
    end
```

```jscript
  public class JobDefinition extends ConfigurationBase
```

The JobDefinition type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobDefinition() () () ()](jobdefinition-constructor-microsoft-web-media-transformmanager_1.md)|Initializes a new instance of the JobDefinition class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobDefinition(FileInfo, XElement)](jobdefinition-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the JobDefinition class using the specified file and job definition information.|


## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[AssetRetentionPeriodDisplayUnit](jobdefinition-assetretentionperioddisplayunit-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates how long the assets that are associated with a job are retained.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[AssetRetentionPeriodMinutes](jobdefinition-assetretentionperiodminutes-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of minutes that the asset files that are associated with a job are retained after they are selected for deletion during maintenance.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[BaseNamespace](configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML namespace for the configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConcurrentJobs](jobdefinition-concurrentjobs-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of concurrent jobs that the job manager can start when it uses this job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationDirectory](jobdefinition-configurationdirectory-property-microsoft-web-media-transformmanager.md)|Gets the path of the job definition configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessages](configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessagesElement](configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationStatus](configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md)|Gets or sets the IIS Transform Manager configuration status. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CredentialId](jobdefinition-credentialid-property-microsoft-web-media-transformmanager.md)|Gets or sets a GUID that identifies the credential that is associated with this job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DeleteCanceledFiles](jobdefinition-deletecanceledfiles-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether asset files for canceled jobs should be deleted during the maintenance cycle.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DeleteFailedFiles](jobdefinition-deletefailedfiles-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether asset files for failed jobs should be deleted during the maintenance cycle.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DeleteFinishedFiles](jobdefinition-deletefinishedfiles-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether asset files for finished jobs should be deleted during the maintenance cycle.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](configurationbase-description-property-microsoft-web-media-transformmanager.md)|Gets or sets a description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DescriptionElement](configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md)|Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Enabled](jobdefinition-enabled-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether the job manager that is associated with this job definition can be started.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[EnforceFileNameCase](jobdefinition-enforcefilenamecase-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether the file names referenced in the manifest must match in case.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](jobdefinition-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the configuration file for the current job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](configurationbase-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element ID of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IdElement](configurationbase-idelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML ID element of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolder](jobdefinition-inputfolder-property-microsoft-web-media-transformmanager.md)|Gets or sets the input folder name. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolderPath](jobdefinition-inputfolderpath-property-microsoft-web-media-transformmanager.md)|Gets or sets the input folder path. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputIsManifest](jobdefinition-inputismanifest-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether the file that initiates job creation is a SMIL 2.0-compliant manifest.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IsJobManagerRunning](jobdefinition-isjobmanagerrunning-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates whether the job manager that is associated with this job definition is running.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobManagerLogLevel](jobdefinition-jobmanagerloglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets the threshold value of log entries that are written to the job manager log.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobManagerLogRolloverIntervalDisplayUnit](jobdefinition-jobmanagerlogrolloverintervaldisplayunit-property-microsoft-web-media-transformmanager.md)|Gets or sets the unit of time that is used with the [JobDefinition..::..JobManagerLogRolloverIntervalMinutes](jobdefinition-jobmanagerlogrolloverintervalminutes-property-microsoft-web-media-transformmanager.md) property to indicate when to create a new log.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobManagerLogRolloverIntervalMinutes](jobdefinition-jobmanagerlogrolloverintervalminutes-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of minutes of log data to collect before a new log file is created.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LocalFileWatcherFilter](jobdefinition-localfilewatcherfilter-property-microsoft-web-media-transformmanager.md)|Gets or sets a file filter value that is used to initiate job creation.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFolder](jobdefinition-logfolder-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFolderNameJobInstances](jobdefinition-logfoldernamejobinstances-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogFolderWatchFolderManager](jobdefinition-logfolderwatchfoldermanager-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](configurationbase-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevelElement](configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains log level details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogRetentionPeriodDisplayUnit](jobdefinition-logretentionperioddisplayunit-property-microsoft-web-media-transformmanager.md)|Gets or sets the unit of time that is used with the [LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md) property to indicate how long the log file that is associated with a job is retained.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogRetentionPeriodMinutes](jobdefinition-logretentionperiodminutes-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of minutes that the log that is associated with a job is retained before being deleted during maintenance.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[MaintenanceCommand](jobdefinition-maintenancecommand-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[MaintenanceIntervalDisplayUnit](jobdefinition-maintenanceintervaldisplayunit-property-microsoft-web-media-transformmanager.md)|Gets or sets the unit of time that is used with the [MaintenanceIntervalMinutes](jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md) property to indicate how often maintenance is run.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[MaintenanceIntervalMinutes](jobdefinition-maintenanceintervalminutes-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of minutes between maintenance-processing activities.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[MaintenanceTime](jobdefinition-maintenancetime-property-microsoft-web-media-transformmanager.md)|Gets or sets a fixed time during the day to run maintenance.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[MaintenanceUseInterval](jobdefinition-maintenanceuseinterval-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that indicates that maintenance should be run at a specified interval instead of at a fixed time.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationbase-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element name of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NameElement](configurationbase-nameelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains name details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NodeTaskCodePathX64](jobdefinition-nodetaskcodepathx64-property-microsoft-web-media-transformmanager.md)|Gets or sets a location for x64 binary files.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NodeTaskCodePathX86](jobdefinition-nodetaskcodepathx86-property-microsoft-web-media-transformmanager.md)|Gets or sets a location for x86 binary files.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NotificationIncludeLogForFailedJob](jobdefinition-notificationincludelogforfailedjob-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that specifies that the log that is associated with a failed job will be included in a failure notification POST request.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Notifications](jobdefinition-notifications-property-microsoft-web-media-transformmanager.md)|Gets or sets a collection of the job notifications that trigger a notification POST request.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NotificationUrl](jobdefinition-notificationurl-property-microsoft-web-media-transformmanager.md)|Gets or sets a URL to which HTTP POST request notifications are sent.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolder](jobdefinition-outputfolder-property-microsoft-web-media-transformmanager.md)|Gets or sets the output folder for a job. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolderPath](jobdefinition-outputfolderpath-property-microsoft-web-media-transformmanager.md)|Gets or sets the output folder path for a job. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Priority](jobdefinition-priority-property-microsoft-web-media-transformmanager.md)|Gets or sets the priority of a job.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ProcessPriority](jobdefinition-processpriority-property-microsoft-web-media-transformmanager.md)||
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerCpuDisplayUnit](jobdefinition-schedulercpudisplayunit-property-microsoft-web-media-transformmanager.md)|Gets or sets an HPC CPU unit value.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerCpus](jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md)|Gets or sets a CPU value based on the scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerId](jobdefinition-schedulerid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the scheduler that is associated with this job definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerMemory](jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md)|Gets or sets a memory value based on the scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerNodeGroups](jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of compute nodes.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerProperties](jobdefinition-schedulerproperties-property-microsoft-web-media-transformmanager.md)|Gets a list of additional scheduler properties.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerUseNodeProfile](jobdefinition-schedulerusenodeprofile-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that determines whether the HPC scheduler should use the [SchedulerCpus](jobdefinition-schedulercpus-property-microsoft-web-media-transformmanager.md), [SchedulerMemory](jobdefinition-schedulermemory-property-microsoft-web-media-transformmanager.md), and [SchedulerNodeGroups](jobdefinition-schedulernodegroups-property-microsoft-web-media-transformmanager.md) properties when a job is transformed.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TemplateId](jobdefinition-templateid-property-microsoft-web-media-transformmanager.md)|Gets or sets the ID of the job template that the JobDefinition object uses.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TemplateName](jobdefinition-templatename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the job template that the current JobDefinition object uses.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[WatchFolder](jobdefinition-watchfolder-property-microsoft-web-media-transformmanager.md)|Gets or sets a file system folder that will be watched for files that will instantiate jobs.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[WorkFolder](jobdefinition-workfolder-property-microsoft-web-media-transformmanager.md)||

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String)](configurationbase-addconfigurationmessage-method-string-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String, ConfigurationMessageSeverity)](configurationbase-addconfigurationmessage-method-string-configurationmessageseverity-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration using the specified severity value. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[RemoveRestartWarningMessage](configurationbase-removerestartwarningmessage-method-microsoft-web-media-transformmanager.md)|Removes the restart warning message from the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Save](jobdefinition-save-method-microsoft-web-media-transformmanager.md)|Saves member variables to an XML file.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SetJobTemplates](jobdefinition-setjobtemplates-method-microsoft-web-media-transformmanager.md)|Sets or refreshes the job template collection. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[CredentialIdAttributeName](jobdefinition-credentialidattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the id attribute of the credential element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobTemplateIdAttributeName](jobdefinition-jobtemplateidattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the job template id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerCpuCores](jobdefinition-schedulercpucores-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when an HPC scheduling cores element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerCpuNodes](jobdefinition-schedulercpunodes-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when an HPC scheduling nodes element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerCpusAttributeName](jobdefinition-schedulercpusattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the scheduler cpus attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerCpuSockets](jobdefinition-schedulercpusockets-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when an HPC scheduling CPU sockets element is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerIdAttributeName](jobdefinition-scheduleridattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the scheduler id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerMemoryAttributeName](jobdefinition-schedulermemoryattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the scheduler memory attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerNodeGroupsAttributeName](jobdefinition-schedulernodegroupsattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the scheduler nodeGroups attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SchedulerUseNodeProfileAttributeName](jobdefinition-schedulerusenodeprofileattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the scheduler useNodeProfile attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[TaskIdAttributeName](jobdefinition-taskidattributename-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when the task id attribute is assigned to a job definition. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|

## Remarks

A job definition maps three pieces of data: a job template, a scheduler, and a watch folder. A [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object creates jobs based on the job definition. The JobDefinition object maps [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) objects to FileSystemWatcher objects. The FileSystemWatcher object monitors a folder for jobs. When a file that matches a filter arrives in the watch folder, the [JobManager](jobmanager-class-microsoft-web-media-transformmanager.md) object uses the job template to create a set of tasks on the job scheduler and then dispatches the job.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

