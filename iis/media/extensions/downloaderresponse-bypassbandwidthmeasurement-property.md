---
title: DownloaderResponse.BypassBandwidthMeasurement Property
TOCTitle: BypassBandwidthMeasurement Property
ms:assetid: a6b5d250-7343-4676-9c75-c6a5f6ae2890
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822804(v=VS.90)
ms:contentKeyID: 50079558
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# DownloaderResponse.BypassBandwidthMeasurement Property

**Applies to:** Windows Store apps only

Gets the flag determining whether the bandwidth measurement should be bypassed for the downloader response.

## Syntax

``` csharp
public bool BypassBandwidthMeasurement { get; }
```

``` c++
public:
virtual property bool BypassBandwidthMeasurement {
bool get () sealed;
}
```

``` jscript
final function get BypassBandwidthMeasurement () : bool
```

## Property Value

Type: Bool. The flag determining whether the bandwidth measurement should be bypassed.

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

