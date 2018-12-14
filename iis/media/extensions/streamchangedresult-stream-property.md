---
title: StreamChangedResult.Stream Property
TOCTitle: Steam Property
ms:assetid: 5d5166cb-6096-4e81-9105-57594353134d
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822743(v=VS.90)
ms:contentKeyID: 50079498
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# StreamChangedResult.Stream Property

**Applies to:** Windows Store apps only

Gets a stream that is selected or de-selected.

## Syntax

``` csharp
public IManifestStream Stream { get; }
```

``` c++
public:
virtual property IManifestStream^ Stream {
IManifestStream^ get () sealed;
}
```

``` jscript
final function get Stream () : IManifestStreama
```

## Property Value

The stream that is selected or de-selected.

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

