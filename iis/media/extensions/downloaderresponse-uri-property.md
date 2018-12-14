---
title: DownloaderResponse.Uri Property
TOCTitle: Uri Property
ms:assetid: 96aab3f5-03e6-4479-82c2-56393cd14086
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822788(v=VS.90)
ms:contentKeyID: 50079542
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# DownloaderResponse.Uri Property

**Applies to:** Windows Store apps only

Gets the uri for the response.

## Syntax

``` csharp
public Uri Uri { get; }
```

``` c++
public:
virtual property Uri^ Uri {
Uri^ get () sealed;
}
```

``` jscript
final function get Uri () : Uri
```

## Property Value

Type: Uri. The URI, which may be original or modified.

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

