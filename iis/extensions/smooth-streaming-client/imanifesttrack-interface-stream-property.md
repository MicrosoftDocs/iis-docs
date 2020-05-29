---
title: IManifestTrack Interface.Stream Property
TOCTitle: Stream Property
ms:assetid: a42aa3f4-56a8-4357-a1f3-7047c68e32d7
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822800(v=VS.90)
ms:contentKeyID: 50079554
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface.Stream Property

**Applies to:** Windows Store apps only

Gets the stream object that owns this track.

## Syntax

```csharp
IManifestStream Stream { get; }
```

```cpp
property IManifestStream^ Stream {
IManifestStream^ get ();
}
```

```jscript
function get Stream () : IManifestStream
```

## Property Value

The stream object that owns this track.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
