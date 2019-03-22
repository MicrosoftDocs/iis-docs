---
title: IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element
TOCTitle: <textstream>
ms:assetid: 09b51ca0-8e3c-4939-b210-2cd834556c36
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230808(v=VS.90)
ms:contentKeyID: 22049436
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element

The textstream element specifies a single track of textstream data.

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)  

    <textstream src="path" systemBitrate="bitrate number" >   <param name="parameter name" value="value" valuetype="data type" />
    </ textstream >

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|--- |--- |
|**src**|Specifies the file in which the track resides. This attribute is required.|
|systemBitrate|Specifies the bit rate of the track. This value is matched to the argument of the **QualityLevels()** noun on the URL. This attribute is required.|
|**systemLanguage**|Specifies the language of the track using an RFC-1766 identifier. This is an informative tagging scheme and distinct track names are still required in order to discriminate between tracks at the same bit rate in different languages. This attribute is optional.|


### Child Elements

|Element|Description|
|--- |--- |
|**param**|The param element specifies a single parameter for a textstream element.|

### Parent Elements

|Element|Description|
|--- |--- |
|**switch**|The switch element is a container for track information.|

## Remarks

Text tracks are commonly used for closed captioning, script streaming, and chapter markers. Smooth Streaming also gives content producers the option of representing text data in a content element of the [IIS Smooth Streaming Client Manifest](iis-smooth-streaming-client-manifest.md) instead of encoding the text data as a text track.

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - textstream param Element](iis-smooth-streaming-server-manifest-on-demand-textstream-param-element.md)

