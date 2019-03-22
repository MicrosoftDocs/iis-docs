---
title: TaskDefinition Class (Microsoft.Web.Media.TransformManager)
TOCTitle: TaskDefinition Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.TaskDefinition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.taskdefinition(v=VS.90)
ms:contentKeyID: 35521055
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.TaskDefinition
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TaskDefinition Class

Represents a single task that defines a transformation process.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  [Microsoft.Web.Media.TransformManager.ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..TaskDefinition  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
Public Class TaskDefinition _
    Inherits ConfigurationBase
'Usage

  Dim instance As TaskDefinition
```

```csharp
[SerializableAttribute]
[DataContractAttribute]
public class TaskDefinition : ConfigurationBase
```

```cpp
[SerializableAttribute]
[DataContractAttribute]
public ref class TaskDefinition : public ConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
type TaskDefinition =  
    class
        inherit ConfigurationBase
    end
```

```jscript
  public class TaskDefinition extends ConfigurationBase
```

The TaskDefinition type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TaskDefinition(FileInfo, XElement)](taskdefinition-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the TaskDefinition class by using the specified file information and task definition.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[TaskDefinition(FileInfo, XElement, XElement)](taskdefinition-constructor-fileinfo-xelement-xelement-microsoft-web-media-transformmanager.md)|Initializes a new instance of the TaskDefinition class by using the specified file information, task definition, and default task definition.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[BaseNamespace](configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML namespace for the configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CommandLine](taskdefinition-commandline-property-microsoft-web-media-transformmanager.md)|Gets or sets a command line for the task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[CommandLineArchitecture](taskdefinition-commandlinearchitecture-property-microsoft-web-media-transformmanager.md)|Gets or sets the architecture of the command-line executable.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationDirectory](taskdefinition-configurationdirectory-property-microsoft-web-media-transformmanager.md)|Gets the path to the task definition configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessages](configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessagesElement](configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationStatus](configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md)|Gets or sets the IIS Transform Manager configuration status. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Copyright](taskdefinition-copyright-property-microsoft-web-media-transformmanager.md)|Gets or sets the copyright string that has been supplied by the task author.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](configurationbase-description-property-microsoft-web-media-transformmanager.md)|Gets or sets a description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DescriptionElement](configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md)|Gets or set the XML element that contains the description of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](taskdefinition-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the name of the task definition configuration file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](configurationbase-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element ID of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IdElement](configurationbase-idelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML ID element of a configuration object. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[InputFolder](taskdefinition-inputfolder-property-microsoft-web-media-transformmanager.md)|Gets or sets the folder name to append to the working directory in order to find input files.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IsExecutable](taskdefinition-isexecutable-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that specifies whether the type of task is an executable or an [ITask](itask-interface-microsoft-web-media-transformmanager.md) interface.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](configurationbase-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevelElement](configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains log level details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationbase-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element name of the IIS Transform Manager configuration. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NameElement](configurationbase-nameelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains name details. (Inherited from [ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md).)|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[OutputFolder](taskdefinition-outputfolder-property-microsoft-web-media-transformmanager.md)|Gets or sets the folder name to append to the working directory in order to write output files.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Properties](taskdefinition-properties-property-microsoft-web-media-transformmanager.md)|Gets or sets a collection of the properties that are defined for the current task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[PropertyNamespace](taskdefinition-propertynamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets a property namespace for the current task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[PropertyNamespacePrefix](taskdefinition-propertynamespaceprefix-property-microsoft-web-media-transformmanager.md)|Gets or sets a prefix for the property namespace of the current task.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[SuccessCodes](taskdefinition-successcodes-property-microsoft-web-media-transformmanager.md)|Gets or sets a set of codes that indicate whether the task completed successfully.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskCodeType](taskdefinition-taskcodetype-property-microsoft-web-media-transformmanager.md)|Gets or sets the task type.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskDefinitionElement](taskdefinition-taskdefinitionelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the [XElement](https://msdn.microsoft.com/library/bb340098) object container of the template file.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[TaskTypeArchitecture](taskdefinition-tasktypearchitecture-property-microsoft-web-media-transformmanager.md)|Gets or sets the architecture of the task type, if the command-line executable is architecture specific.|

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
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Save](taskdefinition-save-method-microsoft-web-media-transformmanager.md)|Saves a task definition object to a configuration file.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[idElementName](taskdefinition-idelementname-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when assigning the ID of the element that contains the input folder of the task. The value is "ID". This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[taskDefinitionElementName](taskdefinition-taskdefinitionelementname-field-microsoft-web-media-transformmanager.md)|Represents a constant that is used when assigning the taskDefinition element name of the task. The value is "taskDefinition". This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.|

## Remarks

TaskDefinition objects are contained in a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object that defines a transformation process.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

