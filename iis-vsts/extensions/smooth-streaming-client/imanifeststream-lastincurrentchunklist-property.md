---
title: IManifestStream.LastInCurrentChunkList Property
TOCTitle: LastInCurrentChunkList Property
ms:assetid: 2c0de4a6-54e2-4d74-96c4-618f924be1e0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822707(v=VS.90)
ms:contentKeyID: 50079462
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.LastInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the last chunk iterator in the current chunklist.

## Syntax

```csharp
IChunkIter LastInCurrentChunkList { get; }
```

```cpp
property IChunkIter^ LastInCurrentChunkList {
         IChunkIter^ get ();
```

```jscript
function get LastInCurrentChunkList () : IChunkIter
```

## Property Value

The last chunk iterator in the current chunklist.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

