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
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.TaskDefinition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TaskDefinition Class

Represents a single task that defines a transformation process.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  [Microsoft.Web.Media.TransformManager. . :: . .ConfigurationBase](configurationbase-class-microsoft-web-media-transformmanager.md)  
    Microsoft.Web.Media.TransformManager..::..TaskDefinition  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<SerializableAttribute> _
<DataContractAttribute> _
PublicClassTaskDefinition _
    InheritsConfigurationBase
'Usage
DiminstanceAsTaskDefinition
```

``` csharp
[SerializableAttribute]
[DataContractAttribute]
publicclassTaskDefinition : ConfigurationBase
```

``` c++
[SerializableAttribute]
[DataContractAttribute]
publicref classTaskDefinition : publicConfigurationBase
```

``` fsharp
[<SerializableAttribute>]
[<DataContractAttribute>]
typeTaskDefinition =  
    classinheritConfigurationBaseend
```

``` jscript
publicclass TaskDefinition extendsConfigurationBase
```

The TaskDefinition type exposes the following members.

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
<td><a href="taskdefinition-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md">TaskDefinition(FileInfo, XElement)</a></td>
<td>Initializes a new instance of the TaskDefinition class by using the specified file information and task definition.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="taskdefinition-constructor-fileinfo-xelement-xelement-microsoft-web-media-transformmanager.md">TaskDefinition(FileInfo, XElement, XElement)</a></td>
<td>Initializes a new instance of the TaskDefinition class by using the specified file information, task definition, and default task definition.</td>
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
<td><a href="taskdefinition-commandline-property-microsoft-web-media-transformmanager.md">CommandLine</a></td>
<td>Gets or sets a command line for the task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-commandlinearchitecture-property-microsoft-web-media-transformmanager.md">CommandLineArchitecture</a></td>
<td>Gets or sets the architecture of the command-line executable.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-configurationdirectory-property-microsoft-web-media-transformmanager.md">ConfigurationDirectory</a></td>
<td>Gets the path to the task definition configuration file.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md">ConfigurationMessages</a></td>
<td>Gets or sets a list of IIS Transform Manager configuration messages. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md">ConfigurationMessagesElement</a></td>
<td>Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md">ConfigurationStatus</a></td>
<td>Gets or sets the IIS Transform Manager configuration status. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-copyright-property-microsoft-web-media-transformmanager.md">Copyright</a></td>
<td>Gets or sets the copyright string that has been supplied by the task author.</td>
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
<td><a href="taskdefinition-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the name of the task definition configuration file.</td>
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
<td><a href="taskdefinition-inputfolder-property-microsoft-web-media-transformmanager.md">InputFolder</a></td>
<td>Gets or sets the folder name to append to the working directory in order to find input files.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-isexecutable-property-microsoft-web-media-transformmanager.md">IsExecutable</a></td>
<td>Gets or sets a value that specifies whether the type of task is an executable or an <a href="itask-interface-microsoft-web-media-transformmanager.md">ITask</a> interface.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md">LastModified</a></td>
<td>Gets or sets the date and time when the IIS Transform Manager configuration was last modified. (Inherited from <a href="configurationbase-class-microsoft-web-media-transformmanager.md">ConfigurationBase</a>.)</td>
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
<td><a href="taskdefinition-outputfolder-property-microsoft-web-media-transformmanager.md">OutputFolder</a></td>
<td>Gets or sets the folder name to append to the working directory in order to write output files.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-properties-property-microsoft-web-media-transformmanager.md">Properties</a></td>
<td>Gets or sets a collection of the properties that are defined for the current task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-propertynamespace-property-microsoft-web-media-transformmanager.md">PropertyNamespace</a></td>
<td>Gets or sets a property namespace for the current task.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-propertynamespaceprefix-property-microsoft-web-media-transformmanager.md">PropertyNamespacePrefix</a></td>
<td>Gets or sets a prefix for the property namespace of the current task.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-successcodes-property-microsoft-web-media-transformmanager.md">SuccessCodes</a></td>
<td>Gets or sets a set of codes that indicate whether the task completed successfully.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-taskcodetype-property-microsoft-web-media-transformmanager.md">TaskCodeType</a></td>
<td>Gets or sets the task type.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-taskdefinitionelement-property-microsoft-web-media-transformmanager.md">TaskDefinitionElement</a></td>
<td>Gets or sets the <a href="https://msdn.microsoft.com/en-us/library/bb340098(v=vs.90)">XElement</a> object container of the template file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="taskdefinition-tasktypearchitecture-property-microsoft-web-media-transformmanager.md">TaskTypeArchitecture</a></td>
<td>Gets or sets the architecture of the task type, if the command-line executable is architecture specific.</td>
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
<td><a href="taskdefinition-save-method-microsoft-web-media-transformmanager.md">Save</a></td>
<td>Saves a task definition object to a configuration file.</td>
</tr>
<tr class="even">
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
<td><a href="taskdefinition-idelementname-field-microsoft-web-media-transformmanager.md">idElementName</a></td>
<td>Represents a constant that is used when assigning the ID of the element that contains the input folder of the task. The value is &quot;ID&quot;. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="taskdefinition-taskdefinitionelementname-field-microsoft-web-media-transformmanager.md">taskDefinitionElementName</a></td>
<td>Represents a constant that is used when assigning the taskDefinition element name of the task. The value is &quot;taskDefinition&quot;. This type/member supports the IIS Transform Manager infrastructure and is not intended to be used directly from your code.</td>
</tr>
</tbody>
</table>


Top

## Remarks

TaskDefinition objects are contained in a [JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md) object that defines a transformation process.

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

