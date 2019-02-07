---
title: JobTemplate Class (Microsoft.Web.Media.TransformManager)
TOCTitle: JobTemplate Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.JobTemplate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.jobtemplate(v=VS.90)
ms:contentKeyID: 35521057
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.JobTemplate
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.JobTemplate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# JobTemplate Class

Represents a set of sequential tasks that define a job and that are used during the transform process.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..JobTemplate  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataContractAttribute> _
Public Class JobTemplate _
    Inherits ConfigurationBase
'Usage

  Dim instance As JobTemplate
```

``` csharp
[DataContractAttribute]
public class JobTemplate : ConfigurationBase
```

``` c++
[DataContractAttribute]
public ref class JobTemplate : public ConfigurationBase
```

``` fsharp
[<DataContractAttribute>]
type JobTemplate =  
    class
        inherit ConfigurationBase
    end
```

``` jscript
  public class JobTemplate extends ConfigurationBase
```

The JobTemplate type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobTemplate() () () ()](jobtemplate-constructor-microsoft-web-media-transformmanager_1.md)|Initializes a new instance of the JobTemplate class.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[JobTemplate(FileInfo, XElement)](jobtemplate-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the JobTemplate class using the specified file information and job template.|


Top

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[BaseNamespace](configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML namespace for the configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationDirectory](jobtemplate-configurationdirectory-property-microsoft-web-media-transformmanager.md)|Gets the path of this configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessages](configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessagesElement](configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationStatus](configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md)|Gets or sets the IIS Transform Manager configuration status. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](configurationbase-description-property-microsoft-web-media-transformmanager.md)|Gets or sets a description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DescriptionElement](configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md)|Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](jobtemplate-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of this configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](configurationbase-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element ID of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IdElement](configurationbase-idelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML ID element of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[JobTemplateElement](jobtemplate-jobtemplateelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the [XElement](https://msdn.microsoft.com/en-us/library/bb340098(v=vs.90)) container of the template file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](configurationbase-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevelElement](configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains log level details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationbase-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element name of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NameElement](configurationbase-nameelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains name details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Properties](jobtemplate-properties-property-microsoft-web-media-transformmanager.md)|Gets or sets a collection of properties that are defined for the tasks.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskDefinitions](jobtemplate-taskdefinitions-property-microsoft-web-media-transformmanager.md)|Gets or sets a collection of the task definitions for the job template.|

Top

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String)](configurationbase-addconfigurationmessage-method-string-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String, ConfigurationMessageSeverity)](configurationbase-addconfigurationmessage-method-string-configurationmessageseverity-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration using the specified severity value. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/en-us/library/bsc2ak47(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/en-us/library/4k87zsw7(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/en-us/library/zdee4b3y(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/en-us/library/dfwy45w9(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/en-us/library/57ctke0a(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[RemoveRestartWarningMessage](configurationbase-removerestartwarningmessage-method-microsoft-web-media-transformmanager.md)|Removes the restart warning message from the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Save](jobtemplate-save-method-microsoft-web-media-transformmanager.md)|Saves a JobTemplate object to a configuration file.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[SetTaskDefinitions](jobtemplate-settaskdefinitions-method-microsoft-web-media-transformmanager.md)|Sets a list of [TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md) objects when a job template element is created.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/en-us/library/7bxwbwt2(v=vs.90))|(Inherited from [Object](https://msdn.microsoft.com/en-us/library/e5kfa45b(v=vs.90)).)|

Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

