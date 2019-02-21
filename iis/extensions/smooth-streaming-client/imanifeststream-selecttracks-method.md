---
title: IManifestStream.SelectTracks Method
TOCTitle: SelectTracks Method
ms:assetid: 173bc76d-1179-4345-8f55-aba78ae7d7df
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822684(v=VS.90)
ms:contentKeyID: 50079439
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# IManifestStream.SelectTracks Method

**Applies to:** Windows Store apps only

Selects the tracks in a subset of all the available tracks.

## Syntax

```csharp
void SelectTracks(
IVectorView<IManifestTrack> pTracks
)
```

```cpp
void SelectTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
)
```

```jscript
function SelectTracks(
pTracks : IVectorView<IManifestTrack>
)
```

## Parameters

  - pTracks  
    Type: IVectorView(IManifestTrack)

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

