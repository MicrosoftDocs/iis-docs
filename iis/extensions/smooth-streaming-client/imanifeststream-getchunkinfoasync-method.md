---
title: IManifestStream.GetChunkInfoAsync Method
TOCTitle: GetChunkInfoAsync Method
ms:assetid: 00ee0434-0e92-4fa9-a0be-30643081a99f
ms:mtpsurl: https://msdn.microsoft.com/library/JJ851079(v=VS.90)
ms:contentKeyID: 50079418
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream.GetChunkInfoAsync Method

**Applies to:** Windows Store apps only

Gets the chunk info of the given chunk iterator through async call.

## Syntax

```csharp
IAsyncOperation<ChunkInfo> GetChunkInfoAsync(
IChunkIter pChunkIter
)
```

```cpp
IAsyncOperation<ChunkInfo>^ GetChunkInfoAsync(
[InAttribute] IChunkIter^ pChunkIter
)
```

```jscript
function GetChunkInfoAsync(
pChunkIter : IChunkIter
) : IAsyncOperation<ChunkInfo>
```

## Parameters

  - pChunkIter  
    \[in\] The pointer to the chunk iterator.

  - ppAsyncInfo  
    \[out\] The async operation result.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

