---
title: RequestUri Property
TOCTitle: RequestUri Property
ms:assetid: f0c9b71d-227c-4f80-b438-36581e5bd79f
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822870(v=VS.90)
ms:contentKeyID: 50079624
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# RequestUri Property

**Applies to:** Windows Store apps only

Gets the original request URI.

## Syntax

``` csharp
public Uri RequestUri { get; }
```

``` c++
public:
virtual property Uri^ RequestUri {
Uri^ get () sealed;
}
```

``` jscript
final function get RequestUri () : Uri
```

## Property Value

The request URI.

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

