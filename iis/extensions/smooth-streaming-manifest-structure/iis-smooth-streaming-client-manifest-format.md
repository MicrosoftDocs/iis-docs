---
title: IIS Smooth Streaming Client Manifest Format
TOCTitle: Client Manifest Format
ms:assetid: 81ac2d63-2104-49f3-8d66-9f062fb4ba6a
ms:mtpsurl: https://msdn.microsoft.com/library/Ee673436(v=VS.90)
ms:contentKeyID: 26179479
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# IIS Smooth Streaming Client Manifest Format

The manifest contains URIs and names in their unobfuscated form. The file name extension of the client manifest file on disk must be .ismc. The file name of the client manifest file should match the file name of the server manifest.

## Nesting

The structure of the client manifest file is as follows:

  - [IIS Smooth Streaming Client Manifest - SmoothStreamingMedia Element](iis-smooth-streaming-client-manifest-smoothstreamingmedia-element.md) - Root metadata element for presentation.

  - [IIS Smooth Streaming Client Manifest - StreamIndex Element](iis-smooth-streaming-client-manifest-streamindex-element.md) - Metadata for each track in presentation – video, audio, and text.

  - QualityLevel element - Mandatory for video/audio tracks, describes one of the possible choices for a track.

  - c (chunk) element - Mandatory for video/audio tracks, describes the different fragments of this track.

  - f (fragment) element - Metadata for each fragment of a track.

  - Content element - Mandatory for text tracks.

  - ScriptCommand element - Mandatory for Content tracks of subtype SCMD.

  - Marker element - Mandatory for Content tracks of subtype CHAP.

  - Sample element - Allowed only for text tracks that are not SCMD or CHAP.

  - [IIS Smooth Streaming Client Manifest - Protection Element](iis-smooth-streaming-client-manifest-protection-element.md) - Container for content protection playback information.

  - [IIS Smooth Streaming Client Manifest - ProtectionHeader Element](iis-smooth-streaming-client-manifest-protectionheader-element.md) - Specifies data required to play back using a specific content protection scheme.

## See Also

### Concepts

[IIS Smooth Streaming Server Manifest (On-Demand)](iis-smooth-streaming-server-manifest-on-demand.md)

[IIS Smooth Streaming Client](https://msdn.microsoft.com/library/hh943091)
