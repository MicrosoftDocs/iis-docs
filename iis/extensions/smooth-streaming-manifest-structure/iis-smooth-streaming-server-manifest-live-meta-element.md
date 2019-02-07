---
title: IIS Smooth Streaming Server Manifest (Live) - meta Element
TOCTitle: <meta>
ms:assetid: fe6e56c1-2d82-405d-b00b-d843316675ab
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673446(v=VS.90)
ms:contentKeyID: 26179487
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - meta Element

The meta element specifies a single piece of presentation-level metadata.

[IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)  

    <meta name="title" content="{content title}"/>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

|Attribute|Description|
|--- |--- |
|**name**|The title of the presentation.This attribute is required.|
|**content**|Specifies the value of the metadata.This attribute is required.|


#### name Attribute

|Value|Description|
|--- |--- |
|**title**|The content attribute specifies a title.|

#### Child Elements

None

#### Parent Elements

|Element|Description|
|--- |--- |
|**head**|The head element is a container for presentation-level metadata.|

## Remarks

In the live manifest scenario, the clientManifestRelativePath value for the name attribute must be omitted.

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)

