---
title: ManifestTrack.Stream Property
TOCTitle: Stream Property
description: "The ManifestTrack.Stream property gets the stream object that owns this track. This article describes its syntax, property value, and requirements."
ms:assetid: 8dea3d24-b909-40e9-a06c-659a950321b3
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822778(v=VS.90)
ms:contentKeyID: 50079532
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestTrack.Stream Property

**Applies to:** Windows Store apps only

Gets the stream object that owns this track.

## Syntax

```csharp
public IManifestStream Stream { get; }
```

```cpp
public:
virtual property IManifestStream^ Stream {
IManifestStream^ get () sealed;
}
```

```jscript
final function get Stream () : IManifestStream
```

## Property Value

The stream object that owns this track.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
