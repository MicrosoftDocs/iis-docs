---
title: IManifestStream.SelectedTracks Property
TOCTitle: SelectedTracks Property
ms:assetid: bca9989e-270d-4bf6-90ae-ae587b63855d
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822818(v=VS.90)
ms:contentKeyID: 50079572
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.SelectedTracks Property

**Applies to:** Windows Store apps only

Gets the selected tracks in the current stream.

## Syntax

```csharp
IVectorView<IManifestTrack> SelectedTracks { get; }
```

```cpp
property IVectorView<IManifestTrack^>^ SelectedTracks {
IVectorView<IManifestTrack^>^ get ();
}
```

```jscript
function get SelectedTracks () : IVectorView<IManifestTrack>
```

## Property Value

The selected tracks in the current stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

