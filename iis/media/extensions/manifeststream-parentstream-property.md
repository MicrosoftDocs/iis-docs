---
title: ManifestStream.ParentStream Property
TOCTitle: ParentStream Property
ms:assetid: 12414628-3a17-4353-9b3b-32b11a4dfd46
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822681(v=VS.90)
ms:contentKeyID: 50079436
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.ParentStream Property

Gets the parent stream of this stream. This stream is typically a sparse stream.

## Syntax

``` csharp
public IManifestStream ParentStream { get; }
```

``` c++
public:
virtual property IManifestStream^ ParentStream {
IManifestStream^ get () sealed;
}
```

``` jscript
final function get ParentStream () : IManifestStream
```

## Property Value

The parent stream of this stream. This stream is typically a sparse stream.

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

