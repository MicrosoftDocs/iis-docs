---
title: ManifestStream.SelectTracks Method
description: Describes the ManifestStream.SelectTracks method and provides the method's syntax, parameters, return value, and requirements.
TOCTitle: SelectTracks Method
ms:assetid: bcaaf5c4-3f40-4dfa-926c-01508efab3df
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822819(v=VS.90)
ms:contentKeyID: 50079573
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.SelectTracks Method

**Applies to:** Windows Store apps only

Selects the tracks in a subset of all the available tracks.

## Syntax

```csharp
public void SelectTracks(
IVectorView<IManifestTrack> pTracks
)
```

```cpp
public:
virtual void SelectTracks(
[InAttribute] IVectorView<IManifestTrack^>^ pTracks
) sealed
```

```jscript
public final function SelectTracks(
pTracks : IVectorView<IManifestTrack>
)
```

## Parameters

  - pTracks  
    Type: IVectorView(IManifestTrack)

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
