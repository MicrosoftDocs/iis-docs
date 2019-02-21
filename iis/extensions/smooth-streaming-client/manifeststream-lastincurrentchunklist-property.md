---
title: ManifestStream.LastInCurrentChunkList Property
TOCTitle: LastInCurrentChunkList Property
ms:assetid: b769edbd-21ab-47d5-a8b1-625dcd505cc3
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822815(v=VS.90)
ms:contentKeyID: 50079569
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# ManifestStream.LastInCurrentChunkList Property

**Applies to:** Windows Store apps only

Gets the last chunk iterator in the current chunklist.

## Syntax

```csharp
public IChunkIter LastInCurrentChunkList { get; }
```

```cpp
public:
virtual property IChunkIter^ LastInCurrentChunkList {
IChunkIter^ get () sealed;
}
```

```jscript
final function get LastInCurrentChunkList () : IChunkIter
```

## Property Value

The last chunk iterator in the current chunklist.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

