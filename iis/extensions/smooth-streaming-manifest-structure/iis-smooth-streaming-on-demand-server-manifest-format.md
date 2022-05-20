---
title: IIS Smooth Streaming On-Demand Server Manifest Format
description: Describes the IIS Smooth Streaming On-Demand Server Manifest format and provides the structure of the server manifest file.
TOCTitle: On-Demand Server Manifest Format
ms:assetid: 52c07be6-0a29-4eb5-a99e-307ddf1ac47b
ms:mtpsurl: https://msdn.microsoft.com/library/Ee230813(v=VS.90)
ms:contentKeyID: 22049441
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming On-Demand Server Manifest Format

The server manifest specifies constituent files and tracks. To prevent local playback by players that do not support fragmented MP4, the file name extension of the media for IIS Smooth Streaming must not be .mp4. Instead, media should use the .ismv extension for files containing video tracks, and .isma for audio-only files.

## Nesting

The structure of the server manifest file is as follows:

  - [IIS Smooth Streaming Server Manifest (On-Demand) - smil Element](iis-smooth-streaming-server-manifest-on-demand-smil-element.md) - Root element for the presentation (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - head Element](iis-smooth-streaming-server-manifest-on-demand-head-element.md) - Container for presentation level metadata (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - meta Element](iis-smooth-streaming-server-manifest-on-demand-meta-element.md) - Describes a single piece of metadata

  - [IIS Smooth Streaming Server Manifest (On-Demand) - body Element](iis-smooth-streaming-server-manifest-on-demand-body-element.md)- Root container for tracks and references (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - switch Element](iis-smooth-streaming-server-manifest-on-demand-switch-element.md) - Root container for tracks (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - video Element](iis-smooth-streaming-server-manifest-on-demand-video-element.md) - Specifies a video track

  - [IIS Smooth Streaming Server Manifest (On-Demand) - video param Element](iis-smooth-streaming-server-manifest-on-demand-video-param-element.md)- Specifies a track parameter (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - audio Element](iis-smooth-streaming-server-manifest-on-demand-audio-element.md) - Specifies an audio track

  - [IIS Smooth Streaming Server Manifest (On-Demand) - audio param Element](iis-smooth-streaming-server-manifest-on-demand-audio-param-element.md) - Specifies a track parameter (required)

  - [IIS Smooth Streaming Server Manifest (On-Demand) - textstream Element](iis-smooth-streaming-server-manifest-on-demand-textstream-element.md) - Specifies a text track

  - [IIS Smooth Streaming Server Manifest (On-Demand) - textstream param Element](iis-smooth-streaming-server-manifest-on-demand-textstream-param-element.md) - Specifies a track parameter (required)

## See Also

### Concepts

[IIS Smooth Streaming Server Manifest (On-Demand)](iis-smooth-streaming-server-manifest-on-demand.md)
