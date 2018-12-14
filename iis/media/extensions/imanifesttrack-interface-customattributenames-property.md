---
title: IManifestTrack Interface.CustomAttributeNames Property
TOCTitle: CustomAttributeNames Property
ms:assetid: 08043f81-e8bb-4e50-9614-b05abdee82b7
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822672(v=VS.90)
ms:contentKeyID: 50079427
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestTrack Interface.CustomAttributeNames Property

**Applies to:** Windows Store apps only

Gets the track level custom attributes names.

## Syntax

``` csharp
IVectorView<string> CustomAttributeNames { get; }
```

``` c++
property IVectorView<String^>^ CustomAttributeNames {
IVectorView<String^>^ get ();
}
```

``` jscript
function get CustomAttributeNames () : IVectorView<String>
```

## Property Value

The track level custom attributes names.

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

