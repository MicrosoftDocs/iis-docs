---
title: IManifestStream.FirstInCurrentChunkList Property
TOCTitle: FirstInCurrentChunkList Property
description: Gets the first chunk iterator in the current chunklist.
ms:assetid: 4b2ce767-a162-47c0-9f38-9817c8179c2f
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822729(v=VS.90)
ms:contentKeyID: 50079484
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.FirstInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the first chunk iterator in the current chunklist.

## Syntax

```csharp
IChunkIter FirstInCurrentChunkList { get; }
```

```cpp
property IChunkIter^ FirstInCurrentChunkList {
IChunkIter^ get ();
}
```

```jscript
function get FirstInCurrentChunkList () : IChunkIter
```

## Property Value

The first chunk iterator in the current chunklist.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
