---
title: ManifestReadyEventHandler Delegate
TOCTitle: ManifestReadyEventHandler Delegate
ms:assetid: 11612fc5-187b-4658-b09e-554a145bbea3
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ573658(v=VS.90)
ms:contentKeyID: 49080900
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestReadyEventHandler Delegate

**Applies to:** Windows Store apps only

The actual handler for the manifest ready event.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void ManifestReadyEventHandler(
AdaptiveSource sender,
ManifestReadyEventArgs args
)
```

``` c++
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public delegate void ManifestReadyEventHandler(
[InAttribute] AdaptiveSource^ sender,
[InAttribute] ManifestReadyEventArgs^ args
)
```

``` jscript
```

## Parameters

  - sender  
    Adaptive source this event belongs to

  - ManifestReadyEventArgs  
    Event arguments

## Return Value

If the method succeeds, it returns S\_OK. Otherwise, it returns an HRESULT error code.

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

