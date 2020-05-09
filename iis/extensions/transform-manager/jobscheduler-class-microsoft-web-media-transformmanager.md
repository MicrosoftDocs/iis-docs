---
title: JobScheduler Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobScheduler Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobScheduler
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.jobscheduler(v=VS.90)
ms:contentKeyID: 35521071
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobScheduler
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobScheduler
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# JobScheduler Class

Provides scheduling capabilities for incoming jobs.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [Microsoft.Web.Media.TransformManager.ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..JobScheduler  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
Public Class JobScheduler _
    Inherits ConfigurationBase
'Usage

  Dim instance As JobScheduler
```

```csharp
[SerializableAttribute]
[DataContractAttribute]
public class JobScheduler : ConfigurationBase
```

```cpp
[SerializableAttribute]
[DataContractAttribute]
public ref class JobScheduler : public ConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
type JobScheduler =  
    class
        inherit ConfigurationBase
    end
```

```jscript
  public class JobScheduler extends ConfigurationBase
```

The JobScheduler type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobScheduler() () () ()](jobscheduler-constructor-microsoft-web-media-transformmanager_1.md)|Initializes a new instance of the JobScheduler class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobScheduler(FileInfo, XElement)](jobscheduler-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the JobScheduler class using the specified file information and job scheduler XML element.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[BaseNamespace](configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML namespace for the configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConcurrentJobs](jobscheduler-concurrentjobs-property-microsoft-web-media-transformmanager.md)|Gets or sets the number of concurrent jobs that this scheduler can run.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ConfigurationDirectory](jobscheduler-configurationdirectory-property-microsoft-web-media-transformmanager.md)|Gets the path of the configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessages](configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessagesElement](configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationStatus](configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md)|Gets or sets the IIS Transform Manager configuration status. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConnectionString](jobscheduler-connectionstring-property-microsoft-web-media-transformmanager.md)|Gets or sets the connection string that is used by this scheduler.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](configurationbase-description-property-microsoft-web-media-transformmanager.md)|Gets or sets a description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DescriptionElement](configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md)|Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](jobscheduler-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of this configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](configurationbase-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element ID of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IdElement](configurationbase-idelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML ID element of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobSchedulerElement](jobscheduler-jobschedulerelement-property-microsoft-web-media-transformmanager.md)|Gets the XML element that contains the scheduler definition.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[LocalSchedulerFolder](jobscheduler-localschedulerfolder-property-microsoft-web-media-transformmanager.md)|Gets the local scheduler folder name.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[LocalSchedulerId](jobscheduler-localschedulerid-property-microsoft-web-media-transformmanager.md)|Gets the local scheduler ID.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](configurationbase-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevelElement](configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains log level details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationbase-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element name of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NameElement](configurationbase-nameelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains name details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SchedulerType](jobscheduler-schedulertype-property-microsoft-web-media-transformmanager.md)|Gets or sets the string token that represents the scheduler type.|

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
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Save](jobscheduler-save-method-microsoft-web-media-transformmanager.md)|Saves job scheduler details to a file as XML.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
