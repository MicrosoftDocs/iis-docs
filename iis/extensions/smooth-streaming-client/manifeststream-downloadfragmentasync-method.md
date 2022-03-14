---
title: ManifestStream.DownloadFragmentAsync Method
TOCTitle: DownloadFragmentAsync Method
ms:assetid: 91f7430b-8fd6-40b4-98ef-8d6caabe5b10
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822783(v=VS.90)
ms:contentKeyID: 50079537
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# ManifestStream.DownloadFragmentAsync Method

**Applies to:** Windows Store apps only

Downloads the fragment data for the given chunk iterator through async call.

## Syntax

```csharp
public IAsyncOperation<IBuffer> DownloadFragmentAsync(
IChunkIter pChunkIter,
IManifestTrack pTrack
)
```

```cpp
public:
virtual IAsyncOperation<IBuffer^>^ DownloadFragmentAsync(
[InAttribute] IChunkIter^ pChunkIter, 
[InAttribute] IManifestTrack^ pTrack
) sealed
```

```jscript
public final function DownloadFragmentAsync(
pChunkIter : IChunkIter, 
pTrack : IManifestTrack
) : IAsyncOperation<IBuffer>
```

## Parameters

  - pChunkIter  
    Type: Microsoft.Media.AdaptiveStreaming.IChunkIter

  - pTrack  
    Type: Microsoft.Media.AdaptiveStreaming.IManifestTrack

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
