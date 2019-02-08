---
title: IIS Smooth Streaming Server Manifest (On-Demand) - switch Element
TOCTitle: <switch>
ms:assetid: 52109d46-962d-4421-8a91-256ef637614c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee230812(v=VS.90)
ms:contentKeyID: 22049440
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - switch Element

The switch element is a container for track information.

[IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)  
  [IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md)  
    [IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md)  
      [IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md)  

    <switch>
    </switch>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

None

#### Child Elements

|Element|Description|
|--- |--- |
|**video**|The video element specifies a single track of video data.|
|**audio**|The audio element specifies a single track of audio data.|
|**textstream**|The textstream element specifies a single track of textstream data. Text tracks are commonly used for closed captioning, script streaming and chapter markers.|


#### Parent Elements

|Element|Description|
|--- |--- |
|**body**|The body element is a container for track information and references to other media.|

## Remarks

A Smooth Streaming presentation must contain one or more tracks (specified by [IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md), [IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md) and [IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md) elements).

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md)

