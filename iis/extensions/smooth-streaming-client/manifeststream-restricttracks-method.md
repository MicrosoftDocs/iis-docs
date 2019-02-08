---
title: ManifestStream.RestrictTracks Method
TOCTitle: RestrictTracks Method
ms:assetid: d865d229-3247-4191-a34f-d701cfa8b423
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822843(v=VS.90)
ms:contentKeyID: 50079597
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.RestrictTracks Method

**Applies to:** Windows Store apps only

Restricts the tracks to a subset of all the available tracks.

## Syntax

``` csharp
public void RestrictTracks(
IVectorView<IManifestTrack> pTracks
)
```

``` c++
public:
virtual void RestrictTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
) sealed
```

``` jscript
public final function RestrictTracks(
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

