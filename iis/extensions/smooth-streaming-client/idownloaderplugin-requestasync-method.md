---
title: IDownloaderPlugin.RequestAsync Method
TOCTitle: RequestAsync Method
ms:assetid: 5fc7254f-afe3-4245-acfa-a5ed986e3dc9
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822748(v=VS.90)
ms:contentKeyID: 50079503
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# IDownloaderPlugin.RequestAsync Method

**Applies to:** Windows Store apps only

Async operation for request on the DownloaderPlugin.

## Syntax

```csharp
IAsyncOperation<DownloaderResponse> RequestAsync(
DownloaderRequest pDownloaderRequest
)
```

```cpp
HRESULT RequestAsync(
[in] DownloaderRequest* pDownloaderRequest, [out, retval] Windows.Foundation.IAsyncOperation<DownloaderResponse*>** ppAsyncInfo
)
```

```jscript
bfunction RequestAsync(
pDownloaderRequest : DownloaderRequest
) : IAsyncOperation<DownloaderResponse>
```

## Parameters

  - pDownloaderRequest  
    Type: DownloaderRequest. The downloader request for the async call

  - ppAsyncInfo  
    Type: DownloaderRequest. The Windows Runtime async call IAsyncOperation with DownloaderResponse as the result.

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

