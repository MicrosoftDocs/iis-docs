---
title: ConfigurationBase.AddConfigurationMessage Method  (Microsoft.Web.Media.TransformManager)
TOCTitle: AddConfigurationMessage Method
ms:assetid: Overload:Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.transformmanager.configurationbase.addconfigurationmessage(v=VS.90)
ms:contentKeyID: 35520738
ms.date: 06/14/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.TransformManager.ConfigurationBase.AddConfigurationMessage
dev_langs:
- CSharp
- JScript
- VB
- FSharp
---

# AddConfigurationMessage Method

Adds a message to the IIS Transform Manager configuration.

This member is overloaded. For complete information about this member, including syntax, usage, and examples, click a name in the overload list.

## Overload List

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
</tbody>
</table>


Top

## Remarks

Several IIS Transform Manager configuration object types are derived from this base class, such as task definitions and job templates. Instances of these objects can be added to the configuration by copying files into the configuration directory. When IIS Transform Manager starts, it reads all of the configuration files and validates some of the data. If there is a problem with the validation, a configuration message is added to the base class of the object that has the problem. The messages can be seen in the UI and are reported in logs.

## See Also

#### Reference

[ConfigurationBase Class](configurationbase-class-microsoft-web-media-transformmanager.md)

[Microsoft.Web.Media.TransformManager Namespace](microsoft-web-media-transformmanager-namespace.md)

