---
title: AdaptiveSourceStatusUpdateType Enumeration
TOCTitle: AdaptiveSourceStatusUpdateType Enumeration
ms:assetid: 7a1b0efb-ec4a-4b6a-a060-182bf76ca004
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822762(v=VS.90)
ms:contentKeyID: 50079517
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# AdaptiveSourceStatusUpdateType Enumeration

**Applies to:** Windows Store apps only

Adaptive source update type enumeration.

## Syntax

```csharp
[VersionAttribute()]
public enum AdaptiveSourceStatusUpdateType
```

```cpp
[VersionAttribute()]
public enum class AdaptiveSourceStatusUpdateType
```

```jscript
public enum AdaptiveSourceStatusUpdateType
```

## Enumeration Values

|Name|Value|Description|
|--- |--- |--- |
|Unknown|0|Generic error.|
|Underrun|1|There was an underrun event.|
|Rebuffer|2|There was a rebuffering event.|
|StartEndTime|3|The start/end time changed.|
|BitrateChanged|4|The bitrate changed.|
|ChunkConnectHttpInvalid|5|http <200 or >=400 response on connect|
|NextChunkHttpInvalid|6|http <200 or >=400 response on next chunk|
|ChunkHdrHttpInvalid|7|http <200 or >=400 reponse on chunk hdr|
|ChunkHdrError|8|Chunk header parser error.|
|EndOfLive|9|Live presentation is no longer live|
|OutsideWindowEdge|10|Playable position is outside of DVR window, app should seek and/or change play rate.|
|SegmentManifestError|11|Error while getting a segment manifest.|
|ChunkDownloaded|12|Additional info on every chunk downloaded.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

