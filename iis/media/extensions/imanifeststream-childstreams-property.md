---
title: IManifestStream.ChildStreams Property
TOCTitle: ChildStreams Property
ms:assetid: 8dff8f9d-ca08-4896-8c9d-6b19584ec059
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822779(v=VS.90)
ms:contentKeyID: 50079533
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.ChildStreams Property

**Applies to:** Windows Store apps only

Gets the child (sparse) streams of this stream.

## Syntax

``` csharp
IVectorView<IManifestStream> ChildStreams { get; }
```

``` c++
property IVectorView<IManifestStream^>^ ChildStreams {
IVectorView<IManifestStream^>^ get ();
}
```

``` jscript
 function get ChildStreams () : IVectorView<IManifestStream>
```

## Property Value

Type: IVectorView(IManifestStream)

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

