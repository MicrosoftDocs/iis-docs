---
title: IIS Smooth Streaming Live Server Manifest Format
TOCTitle: Live Server Manifest Format
ms:assetid: f2c78562-d907-4048-be99-9cd2724cfc51
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673443(v=VS.90)
ms:contentKeyID: 26179486
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Live Server Manifest Format

The encoder must embed a Live Server Manifest in a Live Server Manifest Box at the beginning of each stream, except as specified in Live Presentations. The overall structure of the manifest closely mirrors that of an [IIS Smooth Streaming Server Manifest (On-Demand)](iis-smooth-streaming-server-manifest-on-demand.md) Server Manifest. However, there are some changes to the syntax and semantics relative to the On-Demand Server Manifest. The following data must be omitted from the syntax for the Live scenario:

\<meta name="clientManifestRelativePath"\>

The src attribute of the [IIS Smooth Streaming Server Manifest (Live) - video Element](iis-smooth-streaming-server-manifest-live-video-element.md), [IIS Smooth Streaming Server Manifest (Live) - audio Element](iis-smooth-streaming-server-manifest-live-audio-element.md) and [IIS Smooth Streaming Server Manifest (Live) - textstream Element](iis-smooth-streaming-server-manifest-live-textstream-element.md) elements has a different semantic meaning for the live scenario. Instead of referring to a path on disk, the src attribute in the Live case is interpreted as a URL relative to the encoder URL from which the live Server Manifest was retrieved, or an absolute URL if an absolute URL is specified.

## Nesting

The structure of the server manifest file is as follows:

  - [IIS Smooth Streaming Server Manifest (Live) - smil Element](iis-smooth-streaming-server-manifest-live-smil-element.md) - Root element for the presentation (required)

  - [IIS Smooth Streaming Server Manifest (Live) - head Element](iis-smooth-streaming-server-manifest-live-head-element.md)- Container for presentation level metadata (required)

  - [IIS Smooth Streaming Server Manifest (Live) - meta Element](iis-smooth-streaming-server-manifest-live-meta-element.md) - Describes a single piece of metadata

  - [IIS Smooth Streaming Server Manifest (Live) - body Element](iis-smooth-streaming-server-manifest-live-body-element.md) - Root container for tracks and references (required)

  - [IIS Smooth Streaming Server Manifest (Live) - switch Element](iis-smooth-streaming-server-manifest-live-switch-element.md) - Root container for tracks (required)

  - [IIS Smooth Streaming Server Manifest (Live) - video Element](iis-smooth-streaming-server-manifest-live-video-element.md) - Specifies a video track

  - [IIS Smooth Streaming Server Manifest (Live) - video param Element](iis-smooth-streaming-server-manifest-live-video-param-element.md)- Specifies a track parameter (required)

  - [IIS Smooth Streaming Server Manifest (Live) - audio Element](iis-smooth-streaming-server-manifest-live-audio-element.md) - Specifies an audio track

  - [IIS Smooth Streaming Server Manifest (Live) - audio param Element](iis-smooth-streaming-server-manifest-live-audio-param-element.md) - Specifies a track parameter (required)

  - [IIS Smooth Streaming Server Manifest (Live) - textstream Element](iis-smooth-streaming-server-manifest-live-textstream-element.md) - Specifies a text track

  - [IIS Smooth Streaming Server Manifest (Live) - textstream param Element](iis-smooth-streaming-server-manifest-live-textstream-param-element.md)- Specifies a track parameter (required)

## See Also

### Concepts

[IIS Smooth Streaming Server Manifest (Live)](iis-smooth-streaming-server-manifest-live.md)

