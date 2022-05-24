---
title: IChunkIter Interface
description: Describes the IChunkIter interface and provides the interface's syntax, members, methods, and requirements.
TOCTitle: IChunkIter Interface
ms:assetid: bff052ca-5f58-4f2e-8c99-cdabbed9a130
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822824(v=VS.90)
ms:contentKeyID: 50079578
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IChunkIter Interface

**Applies to:** Windows Store apps only

ChunkIter interface.

## Syntax

```csharp
[GuidAttribute(, , , , , , , , , , )] 

[VersionAttribute()]

public interface IChunkIter
```

```cpp
[GuidAttribute(, , , , , , , , , , )] 

[VersionAttribute()]

public interface class IChunkIter
```

```jscript
public interface IChunkIter
```

## Members

This interface exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[MoveNext](ichunkiter-movenext-method.md)|Move to the next chunk.|
|[MovePrev](ichunkiter-moveprev-method.md)|Move to the previous chunk.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
