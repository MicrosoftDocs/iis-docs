---
title: IIS Smooth Streaming Server Manifest (On-Demand) - meta Element
TOCTitle: <meta>
ms:assetid: e4397b74-1779-48a3-97a2-cffeb65ccdd5
ms:mtpsurl: https://msdn.microsoft.com/library/Ee230820(v=VS.90)
ms:contentKeyID: 22049448
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - meta Element

The meta element specifies a single piece of presentation-level metadata.

[IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md)  

```xml
<meta name="title" content="{content title}"/>
```

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**name**|The title of the presentation.This attribute is required.|
|**content**|Specifies the value of the metadata.This attribute is required.|

#### name Attribute

|Value|Description|
|--- |--- |
|**title**|The content attribute specifies a title.|
|**clientManfiestPath**|The content attribute specifies the physical path of the client manifest relative to the server manifest.|

### Child Elements

None

### Parent Elements

|Element|Description|
|--- |--- |
|**head**|The head element is a container for presentation-level metadata.|

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md)
