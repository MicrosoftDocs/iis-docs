---
title: IIS Smooth Streaming Server Manifest (On-Demand) - audio Element
TOCTitle: <audio>
ms:assetid: e23be25a-940f-4124-8bb4-b92aeac7b401
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230819(v=VS.90)
ms:contentKeyID: 22049447
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - audio Element

The audio element specifies a single track of audio data.

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)  

    <audio src="path" systemBitrate="bitrate number" >   <param name="parameter name" value="value" valuetype="data type" />
    </audio>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

|Attribute|Description|
|--- |--- |
|**src**|Specifies the file in which the track resides. This attribute is required.|
|systemBitrate|Specifies the bit rate of the track. This value is matched to the argument of the **QualityLevels()** noun on the URL.This attribute is required.|
|**systemLanguage**|Specifies the language of the track using an RFC-1766 identifier. This is an informative tagging scheme and distinct track names are still required in order to discriminate between tracks at the same bit rate in different languages. This attribute is optional.|


#### Child Elements

|Element|Description|
|--- |--- |
|**param**|The param element specifies a single parameter for an audio element.|

#### Parent Elements

|Element|Description|
|--- |--- |
|**switch**|The switch element is a container for track information.|

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - textstream param Element](iis-smooth-streaming-server-manifest-on-demand-textstream-param-element.md)

