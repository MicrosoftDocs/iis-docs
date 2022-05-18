---
title: ManifestTrack.TrackIndex Property
TOCTitle: TrackIndex Property
description: Gets the index of the track in the manifest.
ms:assetid: ffa51f4a-fd4b-4881-8d8a-ff23512cf952
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822881(v=VS.90)
ms:contentKeyID: 50079635
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack.TrackIndex Property

**Applies to:** Windows Store apps only

Gets the index of the track in the manifest.

## Syntax

```csharp
public uint TrackIndex { get; }
```

```cpp
public:
virtual property unsigned int TrackIndex {
unsigned int get () sealed;
}
```

```jscript
final function get TrackIndex () : uint
```

## Property Value

The index of the track in the manifest.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
