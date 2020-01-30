---
title: IDownloaderPlugin.ResponseData Method
TOCTitle: ResponseData Method
ms:assetid: d74e3408-f57c-49b8-b61f-99f1ca873a1e
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822842(v=VS.90)
ms:contentKeyID: 50079596
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IDownloaderPlugin.ResponseData Method

**Applies to:** Windows Store apps only

Response after download data is ready for caching.

## Syntax

```csharp
void ResponseData(
DownloaderRequest pDownloaderRequest,
DownloaderResponse pDownloaderResponse
)
```

```cpp
HRESULT ResponseData(
[in] DownloaderRequest* pDownloaderRequest, 
[in] DownloaderResponse* pDownloaderResponse
)
```

```jscript
function ResponseData(
pDownloaderRequest : DownloaderRequest, 
pDownloaderResponse : DownloaderResponse
)
```

## Parameters

  - pDownloaderRequest  
    Type: DownloaderRequest. The downloader request.

  - pDownloaderResponse  
    Type: DownloaderResponse. The downloader response.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

