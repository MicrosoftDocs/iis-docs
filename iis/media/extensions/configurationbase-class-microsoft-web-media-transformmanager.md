---
title: ConfigurationBase Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationBase Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ConfigurationBase
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase(v=VS.90)
ms:contentKeyID: 35520658
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationBase
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationBase Class

Provides a base class that represents IIS Transform Manager configuration information.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..ConfigurationBase  
    [Microsoft.Web.Media.TransformManager. . :: . .JobDefinition](jobdefinition-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager. . :: . .JobScheduler](jobscheduler-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager. . :: . .JobTemplate](jobtemplate-class-microsoft-web-media-transformmanager.md)  
    [Microsoft.Web.Media.TransformManager. . :: . .TaskDefinition](taskdefinition-class-microsoft-web-media-transformmanager.md)  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataContractAttribute> _
PublicClassConfigurationBase
'Usage
DiminstanceAsConfigurationBase
```

``` csharp
[DataContractAttribute]
publicclassConfigurationBase
```

``` c++
[DataContractAttribute]
publicref classConfigurationBase
```

``` fsharp
[<DataContractAttribute>]
typeConfigurationBase =  classend
```

``` jscript
publicclass ConfigurationBase
```

The ConfigurationBase type exposes the following members.

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
<td><a href="configurationbase-constructor-xnamespace-microsoft-web-media-transformmanager.md">ConfigurationBase(XNamespace)</a></td>
<td>Initializes a new instance of the ConfigurationBase class using the specified namespace.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationbase-constructor-xnamespace-fileinfo-microsoft-web-media-transformmanager.md">ConfigurationBase(XNamespace, FileInfo)</a></td>
<td>Initializes a new instance of the ConfigurationBase class using the specified namespace and file information.</td>
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
<td>Gets or sets the XML namespace for the configuration.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="configurationbase-configurationdirectory-property-microsoft-web-media-transformmanager.md">ConfigurationDirectory</a></td>
<td>Gets or sets the configuration directory path for the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessages-property-microsoft-web-media-transformmanager.md">ConfigurationMessages</a></td>
<td>Gets or sets a list of IIS Transform Manager configuration messages.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationmessageselement-property-microsoft-web-media-transformmanager.md">ConfigurationMessagesElement</a></td>
<td>Gets or sets an XML element that contains configuration messages for the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-configurationstatus-property-microsoft-web-media-transformmanager.md">ConfigurationStatus</a></td>
<td>Gets or sets the IIS Transform Manager configuration status.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-description-property-microsoft-web-media-transformmanager.md">Description</a></td>
<td>Gets or sets a description of the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-descriptionelement-property-microsoft-web-media-transformmanager.md">DescriptionElement</a></td>
<td>Gets or set the XML element that contains the description of the IIS Transform Manager configuration.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the configuration file name for the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-id-property-microsoft-web-media-transformmanager.md">Id</a></td>
<td>Gets or sets the XML element ID of a configuration object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-idelement-property-microsoft-web-media-transformmanager.md">IdElement</a></td>
<td>Gets or sets the XML ID element of a configuration object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-lastmodified-property-microsoft-web-media-transformmanager.md">LastModified</a></td>
<td>Gets or sets the date and time when the IIS Transform Manager configuration was last modified.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevel-property-microsoft-web-media-transformmanager.md">LogLevel</a></td>
<td>Gets or sets a value that represents the level of detail for a log that is contained in the log level element of the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-loglevelelement-property-microsoft-web-media-transformmanager.md">LogLevelElement</a></td>
<td>Gets or sets an XML element that contains log level details.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets or sets the XML element name of the IIS Transform Manager configuration.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationbase-nameelement-property-microsoft-web-media-transformmanager.md">NameElement</a></td>
<td>Gets or sets an XML element that contains name details.</td>
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
<td>Adds the specified message to the IIS Transform Manager configuration.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationbase-addconfigurationmessage-method-string-configurationmessageseverity-microsoft-web-media-transformmanager.md">AddConfigurationMessage(String, ConfigurationMessageSeverity)</a></td>
<td>Adds the specified message to the IIS Transform Manager configuration using the specified severity value.</td>
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
<td>Removes the restart warning message from the IIS Transform Manager configuration.</td>
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
<td><a href="configurationbase-configurationextension-field-microsoft-web-media-transformmanager.md">ConfigurationExtension</a></td>
<td>Represents a string constant that specifies the file name extension (&quot;.xml&quot;) of a configuration file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="configurationbase-jobdefinitionsdirectory-field-microsoft-web-media-transformmanager.md">JobDefinitionsDirectory</a></td>
<td>Represents a string constant that specifies a configuration directory (&quot;Job Definitions&quot;) for job definitions.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="configurationbase-jobschedulersdirectory-field-microsoft-web-media-transformmanager.md">JobSchedulersDirectory</a></td>
<td>Represents a string constant that specifies a configuration directory (&quot;Job Schedulers&quot;) for job schedulers.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="configurationbase-jobtemplatesdirectory-field-microsoft-web-media-transformmanager.md">JobTemplatesDirectory</a></td>
<td>Represents a string constant that specifies a configuration directory (&quot;Job Templates&quot;) for job templates.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565979.pubfield(en-us,VS.90).gif" title="Public field" alt="Public field" /><img src="images/Dd565979.static(en-us,VS.90).gif" title="Static member" alt="Static member" /></td>
<td><a href="configurationbase-taskdefinitionsdirectory-field-microsoft-web-media-transformmanager.md">TaskDefinitionsDirectory</a></td>
<td>Represents a string constant that specifies a configuration directory (&quot;Task Definitions&quot;) for task definitions.</td>
</tr>
</tbody>
</table>


Top

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

#### Reference

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

