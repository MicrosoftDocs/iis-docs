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
- c++
- jscript
---

# IDownloaderPlugin.RequestAsync Method

**Applies to:** Windows Store apps only

Async operation for request on the DownloaderPlugin.

## Syntax

``` csharp
IAsyncOperation<DownloaderResponse> RequestAsync(
DownloaderRequest pDownloaderRequest
)
```

``` c++
HRESULT RequestAsync(
[in] DownloaderRequest* pDownloaderRequest, [out, retval] Windows.Foundation.IAsyncOperation<DownloaderResponse*>** ppAsyncInfo
)
```

``` jscript
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

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p><strong>Minimum supported client</strong></p></td>
<td><p>Windows 8</p></td>
</tr>
<tr class="even">
<td><p><strong>Minimum supported server</strong></p></td>
<td><p>Not Supported</p></td>
</tr>
<tr class="odd">
<td><p><strong>Metadata</strong></p></td>
<td><p>Microsoft.Media.AdaptiveStreaming.winmd</p></td>
</tr>
</tbody>
</table>

