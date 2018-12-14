---
title: IManifestTrack Interface.CodecPrivateData Property
TOCTitle: CodecPrivateData Property
ms:assetid: e9b3f56b-2a72-4ae0-8b41-cbe54df464ae
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822862(v=VS.90)
ms:contentKeyID: 50079616
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestTrack Interface.CodecPrivateData Property

**Applies to:** Windows Store apps only

Gets the CodecPrivateData.

## Syntax

``` csharp
byte[] CodecPrivateData { get; }
```

``` c++
property array<unsigned char>^ CodecPrivateData {
array<unsigned char>^ get ();
}
```

``` jscript
function get CodecPrivateData () : byte[]
```

## Property Value

The CodecPrivateData.

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

