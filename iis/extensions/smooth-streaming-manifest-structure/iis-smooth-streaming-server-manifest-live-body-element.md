---
title: IIS Smooth Streaming Server Manifest (Live) - body Element
TOCTitle: <body>
ms:assetid: 32015356-29af-4e0b-a81b-c198939235a0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ee673432(v=VS.90)
ms:contentKeyID: 26179475
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (Live) - body Element

The body element is a container for track information and references to other media.

[IIS Smooth Streaming Server Manifest (Live) - smil Element](iis-smooth-streaming-server-manifest-live-smil-element.md)  
  [IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)  

    <body>
    </body>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

#### Attributes

None

#### Child Elements

|Element|Description|
|--- |--- |
|**switch**|The switch element is a container for track information. A Smooth Streaming presentation must contain one or more <a href="iis-smooth-streaming-server-manifest-live-video-element.md">IIS Smooth Streaming Server Manifest (Live) - video Element</a>, <a href="iis-smooth-streaming-server-manifest-live-audio-element.md">IIS Smooth Streaming Server Manifest (Live) - audio Element</a>, and <a href="iis-smooth-streaming-server-manifest-live-textstream-element.md">IIS Smooth Streaming Server Manifest (Live) - textstream Element</a> tracks.|

#### Parent Elements

|Element|Description|
|--- |--- |
|**smil**|Smooth Streaming uses the SMIL 2.0 format for Server Manifest. The smil element is the root container used by SMIL 2.0.|

## See Also

#### Reference

[IIS Smooth Streaming Server Manifest (Live) - smil Element](iis-smooth-streaming-server-manifest-live-smil-element.md)

[IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md)

