---
title: ManifestStream.AvailableTracks Property
TOCTitle: AvailableTracks Property
ms:assetid: 9cd8b94c-363d-4683-ba41-2c095d577331
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822793(v=VS.90)
ms:contentKeyID: 50079547
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.AvailableTracks Property

**Applies to:** Windows Store apps only

Gets the available tracks in the current stream.

## Syntax

```csharp
public IVectorView<IManifestTrack> AvailableTracks { get; }
```

```cpp
public:
virtual property IVectorView<IManifestTrack^>^ AvailableTracks {
IVectorView<IManifestTrack^>^ get () sealed;
}
```

```jscript
final function get AvailableTracks () : IVectorView<IManifestTrack>
```

## Property Value

The available tracks in the current stream.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

