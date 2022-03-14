---
title: ManifestStream.FirstInCurrentChunkList Property
TOCTitle: FirstInCurrentChunkList Property
ms:assetid: 2021ddf8-b4b9-44c1-8fe4-5cc652b8bef6
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822699(v=VS.90)
ms:contentKeyID: 50079454
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.FirstInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the first chunk iterator in the current chunklist.

## Syntax

```csharp
public IChunkIter FirstInCurrentChunkList { get; }
```

```cpp
public:
virtual property IChunkIter^ FirstInCurrentChunkList {
IChunkIter^ get () sealed;
}
```

```jscript
final function get FirstInCurrentChunkList () : IChunkIter
```

## Property Value

The first chunk iterator in the current chunklist.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
