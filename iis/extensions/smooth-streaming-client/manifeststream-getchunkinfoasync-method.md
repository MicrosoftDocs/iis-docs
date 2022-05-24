---
title: ManifestStream.GetChunkInfoAsync Method
description: Describes the ManifestStream.GetChunkInfoAsync method and provides the method's syntax, parameters, return value, and requirements.
TOCTitle: GetChunkInfoAsync Method
ms:assetid: 3e737bcc-ccc5-44b5-a34e-9cb46e08f495
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822721(v=VS.90)
ms:contentKeyID: 50079476
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.GetChunkInfoAsync Method

**Applies to:** Windows Store apps only

Gets the chunk info of the given chunk iterator through async call.

## Syntax

```csharp
public IAsyncOperation<ChunkInfo> GetChunkInfoAsync(
IChunkIter pChunkIter
)
```

```cpp
public:
virtual IAsyncOperation<ChunkInfo>^ GetChunkInfoAsync(
[InAttribute] IChunkIter^ pChunkIter
) sealed
```

```jscript
public final function GetChunkInfoAsync(
pChunkIter : IChunkIter
) : IAsyncOperation<ChunkInfo>
```

## Parameters

  - pChunkIter  
    Type: IAsyncOperation(ChunkInfo)

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
