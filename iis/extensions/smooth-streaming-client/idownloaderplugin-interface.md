---
title: IDownloaderPlugin Interface
TOCTitle: IDownloaderPlugin Interface
ms:assetid: 8ea37240-a2f6-44b4-9670-d39e28db3bcb
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822781(v=VS.90)
ms:contentKeyID: 50079535
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IDownloaderPlugin Interface

**Applies to:** Windows Store apps only

The DownloaderPlugin interface.

## Syntax

```csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface IDownloaderPlugin 
```

```cpp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface class IDownloaderPlugin
```

```jscript
public interface IDownloaderPlugin
```

## Members

This interface exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[RequestAsync](idownloaderplugin-requestasync-method.md)|Async operation for request on the DownloaderPlugin.|
|[ResponseData](idownloaderplugin-responsedata-method.md)|Response after download data are ready for caching.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

