---
title: IAdaptiveSourceManager.AdaptiveSources Property
TOCTitle: AdaptiveSources Property
ms:assetid: 64b4b8d7-2ec2-45a0-b3d6-5240c270633c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822750(v=VS.90)
ms:contentKeyID: 50079505
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.AdaptiveSources Property

**Applies to:** Windows Store apps only

Gets the list of opened adaptive sources.

## Syntax

``` csharp
IVectorView<IAdaptiveSource> AdaptiveSources { get; }
```

``` c++
property IVectorView<IAdaptiveSource^>^ AdaptiveSources {
IVectorView<IAdaptiveSource^>^ get ();
}
```

``` jscript
function get AdaptiveSources () : IVectorView<IAdaptiveSource>
```

## Property Value

Type: IVectorView(IAdaptiveSource)

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

