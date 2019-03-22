---
title: IManifestStream.RestrictTracks Method
TOCTitle: RestrictTracks Method
ms:assetid: 65974158-70aa-4ab0-bacc-4431d059bbef
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822751(v=VS.90)
ms:contentKeyID: 50079506
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.RestrictTracks Method

**Applies to:** Windows Store apps only

Restricts the tracks to a subset of all the available tracks.

## Syntax

```csharp
void RestrictTracks(
IVectorView<IManifestTrack> pTracks
)
```

```cpp
void RestrictTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
)
```

```jscript
function RestrictTracks(
pTracks : IVectorView<IManifestTrack>
)
```

## Parameters

  - pTracks  
    \[in\] The list of tracks to keep available in the stream. Tracks not in the list will be removed.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

