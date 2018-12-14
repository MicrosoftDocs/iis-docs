---
title: ConfigurationMessage Class (Microsoft.Web.Media.TransformManager)
TOCTitle: ConfigurationMessage Class
ms:assetid: T:Microsoft.Web.Media.TransformManager.ConfigurationMessage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationmessage(v=VS.90)
ms:contentKeyID: 35520555
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.TransformManager.Common.dll
api_name:
- Microsoft.Web.Media.TransformManager.ConfigurationMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ConfigurationMessage Class

Represents messages that are initialized during IIS Transform Manager service initialization.

## Inheritance Hierarchy

[System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
  Microsoft.Web.Media.TransformManager..::..ConfigurationMessage  

**Namespace:**  [Microsoft.Web.Media.TransformManager](microsoft-web-media-transformmanager-namespace.md)  
**Assembly:**  Microsoft.Web.Media.TransformManager.Common (in Microsoft.Web.Media.TransformManager.Common.dll)

## Syntax

``` vb
'Declaration
<DataContractAttribute> _
PublicClassConfigurationMessage
'Usage
DiminstanceAsConfigurationMessage
```

``` csharp
[DataContractAttribute]
publicclassConfigurationMessage
```

``` c++
[DataContractAttribute]
publicref classConfigurationMessage
```

``` fsharp
[<DataContractAttribute>]
typeConfigurationMessage =  classend
```

``` jscript
publicclass ConfigurationMessage
```

The ConfigurationMessage type exposes the following members.

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
<td><a href="configurationmessage-constructor-string-microsoft-web-media-transformmanager.md">ConfigurationMessage(String)</a></td>
<td>Initializes a new instance of the ConfigurationMessage class using the specified message.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationmessage-constructor-xelement-configurationbase-microsoft-web-media-transformmanager.md">ConfigurationMessage(XElement, ConfigurationBase)</a></td>
<td>Initializes a new instance of the ConfigurationMessage class using the specified message element and configuration object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationmessage-constructor-string-string-string-string-microsoft-web-media-transformmanager.md">ConfigurationMessage(String, String, String, String)</a></td>
<td>Initializes a new instance of the ConfigurationMessage class using the specified name, file name, message, and help link ID.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubmethod(en-us,VS.90).gif" title="Public method" alt="Public method" /></td>
<td><a href="configurationmessage-constructor-string-string-string-string-configurationmessageseverity-microsoft-web-media-transformmanager.md">ConfigurationMessage(String, String, String, String, ConfigurationMessageSeverity)</a></td>
<td>Initializes a new instance of the ConfigurationMessage class using the specified name, file name, message, help link ID, and severity.</td>
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
<td><a href="configurationmessage-filename-property-microsoft-web-media-transformmanager.md">FileName</a></td>
<td>Gets or sets the name of the configuration file.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-helplinkid-property-microsoft-web-media-transformmanager.md">HelpLinkId</a></td>
<td>Gets or sets a context-sensitive help link ID value.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-message-property-microsoft-web-media-transformmanager.md">Message</a></td>
<td>Gets or sets a configuration message.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-name-property-microsoft-web-media-transformmanager.md">Name</a></td>
<td>Gets or sets the name of the configuration object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-objectid-property-microsoft-web-media-transformmanager.md">ObjectId</a></td>
<td>Gets or sets the ID of configuration object.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-objecttype-property-microsoft-web-media-transformmanager.md">ObjectType</a></td>
<td>Gets or set the type of the configuration object.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-regkeyfound-property-microsoft-web-media-transformmanager.md">RegKeyFound</a></td>
<td>Gets or sets a message to post when the registration key value is found.</td>
</tr>
<tr class="even">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-regkeynotfound-property-microsoft-web-media-transformmanager.md">RegKeyNotFound</a></td>
<td>Gets or sets a message to post when the registration key is not found.</td>
</tr>
<tr class="odd">
<td><img src="images/Dd565996.pubproperty(en-us,VS.90).gif" title="Public property" alt="Public property" /></td>
<td><a href="configurationmessage-severity-property-microsoft-web-media-transformmanager.md">Severity</a></td>
<td>Gets or set the error severity.</td>
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

