---
title: ConfigurationBase Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationBase Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ConfigurationBase
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.transformmanager.configurationbase(v=VS.90)
ms:contentKeyID: 35520658
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ConfigurationBase Class

Provides a base class that represents IIS Transform Manager configuration information.

## Inheritance Hierarchy

[System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
  Microsoft.Web.Media.TransformManager..::..ConfigurationBase  
    [Microsoft.Web.Media.TransformManager.JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager.JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager.JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager.TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

```vb
'Declaration
<DataContractAttribute> _
Public Class ConfigurationBase
'Usage

  Dim instance As ConfigurationBase
```

```csharp
[DataContractAttribute]
public class ConfigurationBase
```

```cpp
[DataContractAttribute]
public ref class ConfigurationBase
```

``` fsharp
[<DataContractAttribute>]
type ConfigurationBase =  class end
```

```jscript
  public class ConfigurationBase
```

The ConfigurationBase type exposes the following members.

## Constructors

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationBase(XNamespace)](configurationbase-constructor-xnamespace-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationBase class using the specified namespace.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ConfigurationBase(XNamespace, FileInfo)](configurationbase-constructor-xnamespace-fileinfo-microsoft-web-media-transformmanager.md)|Initializes a new instance of the ConfigurationBase class using the specified namespace and file information.|

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[BaseNamespace](configurationbase-basenamespace-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML namespace for the configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ConfigurationDirectory](configurationbase-configurationdirectory-property-microsoft-web-media-transformmanager.md)|Gets or sets the configuration directory path for the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessages](configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md)|Gets or sets a list of IIS Transform Manager configuration messages.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationMessagesElement](configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[ConfigurationStatus](configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md)|Gets or sets the IIS Transform Manager configuration status.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Description](configurationbase-description-property-microsoft-web-media-transformmanager.md)|Gets or sets a description of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[DescriptionElement](configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md)|Gets or set the XML element that contains the description of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[FileName](configurationbase-filename-property-microsoft-web-media-transformmanager.md)|Gets or sets the configuration file name for the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Id](configurationbase-id-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element ID of a configuration object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[IdElement](configurationbase-idelement-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML ID element of a configuration object.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LastModified](configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md)|Gets or sets the date and time when the IIS Transform Manager configuration was last modified.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevel](configurationbase-loglevel-property-microsoft-web-media-transformmanager.md)|Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[LogLevelElement](configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains log level details.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[Name](configurationbase-name-property-microsoft-web-media-transformmanager.md)|Gets or sets the XML element name of the IIS Transform Manager configuration.|
|![Public property](images/Hh125762.pubproperty(en-us,VS.90).gif "Public property")|[NameElement](configurationbase-nameelement-property-microsoft-web-media-transformmanager.md)|Gets or sets an XML element that contains name details.|

## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String)](configurationbase-addconfigurationmessage-method-string-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[AddConfigurationMessage(String, ConfigurationMessageSeverity)](configurationbase-addconfigurationmessage-method-string-configurationmessageseverity-microsoft-web-media-transformmanager.md)|Adds the specified message to the IIS Transform Manager configuration using the specified severity value.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Protected method](images/Hh125771.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[RemoveRestartWarningMessage](configurationbase-removerestartwarningmessage-method-microsoft-web-media-transformmanager.md)|Removes the restart warning message from the IIS Transform Manager configuration.|
|![Public method](images/Hh125771.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2)|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b).)|

## Fields

||Name|Description|
|--- |--- |--- |
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[ConfigurationExtension](configurationbase-configurationextension-field-microsoft-web-media-transformmanager.md)|Represents a string constant that specifies the file name extension (".xml") of a configuration file.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobDefinitionsDirectory](configurationbase-jobdefinitionsdirectory-field-microsoft-web-media-transformmanager.md)|Represents a string constant that specifies a configuration directory ("Job Definitions") for job definitions.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobSchedulersDirectory](configurationbase-jobschedulersdirectory-field-microsoft-web-media-transformmanager.md)|Represents a string constant that specifies a configuration directory ("Job Schedulers") for job schedulers.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[JobTemplatesDirectory](configurationbase-jobtemplatesdirectory-field-microsoft-web-media-transformmanager.md)|Represents a string constant that specifies a configuration directory ("Job Templates") for job templates.|
|![Public field](images/Hh125771.pubfield(en-us,VS.90).gif "Public field")![Static member](images/Hh125771.static(en-us,VS.90).gif "Static member")|[TaskDefinitionsDirectory](configurationbase-taskdefinitionsdirectory-field-microsoft-web-media-transformmanager.md)|Represents a string constant that specifies a configuration directory ("Task Definitions") for task definitions.|

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)
