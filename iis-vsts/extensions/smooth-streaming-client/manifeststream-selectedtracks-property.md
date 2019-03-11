---
title: ManifestStream.SelectedTracks Property
TOCTitle: SelectedTracks Property
ms:assetid: 0c5ad117-bcae-4f9f-97ee-335f3aee7a7d
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822676(v=VS.90)
ms:contentKeyID: 50079431
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.SelectedTracks Property

Gets the selected tracks in the current stream.

## Syntax

```csharp
public IVectorView<IManifestTrack> SelectedTracks { get; }
```

```cpp
public:
virtual property IVectorView<IManifestTrack^>^ SelectedTracks {
IVectorView<IManifestTrack^>^ get () sealed;
}
```

```jscript
final function get SelectedTracks () : IVectorView<IManifestTrack>
```

## Property Value

The selected tracks in the current stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

