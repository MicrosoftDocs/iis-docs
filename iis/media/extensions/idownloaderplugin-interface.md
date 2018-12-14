---
title: IDownloaderPlugin Interface
TOCTitle: IDownloaderPlugin Interface
ms:assetid: 8ea37240-a2f6-44b4-9670-d39e28db3bcb
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822781(v=VS.90)
ms:contentKeyID: 50079535
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IDownloaderPlugin Interface

**Applies to:** Windows Store apps only

The DownloaderPlugin interface.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface IDownloaderPlugin 
```

``` c++
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface class IDownloaderPlugin
```

``` jscript
public interface IDownloaderPlugin
```

## Members

This interface exposes the following members.

### Methods

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Method</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="idownloaderplugin-requestasync-method.md">RequestAsync</a></p></td>
<td><p>Async operation for request on the DownloaderPlugin.</p></td>
</tr>
<tr class="even">
<td><p><a href="idownloaderplugin-responsedata-method.md">ResponseData</a></p></td>
<td><p>Response after download data are ready for caching.</p></td>
</tr>
</tbody>
</table>


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

