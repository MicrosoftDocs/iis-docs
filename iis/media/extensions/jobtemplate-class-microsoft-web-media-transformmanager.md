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
PublicClassJobTemplate _
    InheritsConfigurationBase
'Usage
DiminstanceAsJobTemplate
```

``` csharp
[DataContractAttribute]
publicclassJobTemplate : ConfigurationBase
```

``` c++
[DataContractAttribute]
publicref classJobTemplate : publicConfigurationBase
```

``` fsharp
[<DataContractAttribute>]
typeJobTemplate =  
    classinheritConfigurationBaseend
```

``` jscript
publicclass JobTemplate extendsConfigurationBase
```

The JobTemplate type exposes the following members.

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
<td><a href="jobtemplate-constructor-microsoft-web-media-transformmanager_1.md">JobTemplate() () () ()</a></td>
<td>Initializes a new instance of the JobTemplate class.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="jobtemplate-constructor-fileinfo-xelement-microsoft-web-media-transformmanager.md">JobTemplate(FileInfo, XElement)</a></td>
<td>Initializes a new instance of the JobTemplate class using the specified file information and job template.</td>
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
<td><a href="jobtemplate-configurationdirectory-property-microsoft-web-media-transformmanager.md">ConfigurationDirectory</a></td>
<td>Gets the path of this configuration file.</td>
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
<td><a href="jobtemplate-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
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
<td><a href="jobtemplate-jobtemplateelement-property-microsoft-web-media-transformmanager.md">JobTemplateElement</a></td>
<td>Gets or sets the <a href="https://msdn.microsoft.com/en-us/library/bb340098(v=vs.90)">XElement</a> container of the template file.</td>
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
<td><a href="jobtemplate-properties-property-microsoft-web-media-transformmanager.md">Properties</a></td>
<td>Gets or sets a collection of properties that are defined for the tasks.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="jobtemplate-taskdefinitions-property-microsoft-web-media-transformmanager.md">TaskDefinitions</a></td>
<td>Gets or sets a collection of the task definitions for the job template.</td>
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
<td><a href="jobtemplate-save-method-microsoft-web-media-transformmanager.md">Save</a></td>
<td>Saves a JobTemplate object to a configuration file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="jobtemplate-settaskdefinitions-method-microsoft-web-media-transformmanager.md">SetTaskDefinitions</a></td>
<td>Sets a list of <a href="taskdefinition-class-microsoft-web-media-transformmanager.md">TaskDefinition</a> objects when a job template element is created.</td>
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

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

