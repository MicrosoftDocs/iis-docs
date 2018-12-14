---
title: ManifestStream.ChildStreams Property
TOCTitle: ChildStreams Property
ms:assetid: 5a4899ff-d440-423f-baa2-543c9ce634cf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822739(v=VS.90)
ms:contentKeyID: 50079494
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.ChildStreams Property

**Applies to:** Windows Store apps only

Gets the child (sparse) streams of this stream.

## Syntax

``` csharp
public IVectorView<IManifestStream> ChildStreams { get; }
```

``` c++
public:
virtual property IVectorView<IManifestStream^>^ ChildStreams {
IVectorView<IManifestStream^>^ get () sealed;
}
```

``` jscript
final function get ChildStreams () : IVectorView<IManifestStream>
```

## Property Value

The child (sparse) streams of this stream.

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

