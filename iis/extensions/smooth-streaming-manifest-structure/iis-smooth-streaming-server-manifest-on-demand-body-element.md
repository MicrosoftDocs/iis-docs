---
title: IIS Smooth Streaming Server Manifest (On-Demand) - body Element
TOCTitle: <body>
ms:assetid: 5f4d812d-16ea-4112-809b-9e1e67e72356
ms:mtpsurl: https://msdn.microsoft.com/library/Ee230814(v=VS.90)
ms:contentKeyID: 22049442
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Server Manifest (On-Demand) - body Element

The body element is a container for track information and references to other media.

[IIS Smooth Streaming Server Manifest (On-Demand) - smil Element](iis-smooth-streaming-server-manifest-on-demand-smil-element.md)  
  [IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)  

    <body>
    </body>

## Attributes and Elements

The following sections describe attributes, child elements, and parent elements.

### Attributes

None

### Child Elements

|Element|Description|
|--- |--- |
|**switch**|The switch element is a container for track information. A Smooth Streaming presentation must contain one or more <a href="iis-smooth-streaming-server-manifest-on-demand-video-element.md">IIS Smooth Streaming Server Manifest (On-Demand) - video Element</a>, <a href="iis-smooth-streaming-server-manifest-on-demand-audio-element.md">IIS Smooth Streaming Server Manifest (On-Demand) - audio Element</a>, and <a href="iis-smooth-streaming-server-manifest-on-demand-textstream-element.md">IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element</a> tracks.|

### Parent Elements

|Element|Description|
|--- |--- |
|**smil**|Smooth Streaming uses the SMIL 2.0 format for Server Manifest. The smil element is the root container used by SMIL 2.0.|

## See Also

### Reference

[IIS Smooth Streaming Server Manifest (On-Demand) - smil Element](iis-smooth-streaming-server-manifest-on-demand-smil-element.md)

[IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md)

