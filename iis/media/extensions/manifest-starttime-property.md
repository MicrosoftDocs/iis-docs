---
title: Manifest.StartTime Property
TOCTitle: StartTime Property
ms:assetid: 2480315c-a759-48fd-a697-2e1348b728f1
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822703(v=VS.90)
ms:contentKeyID: 50079458
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.StartTime Property

**Applies to:** Windows Store apps only

Gets the manifest start time.

## Syntax

``` csharp
public ulong StartTime { get; }
```

``` c++
public:
virtual property unsigned long long StartTime {
unsigned long long get () sealed;
}
```

``` jscript
final function get StartTime () : ulong
```

## Property Value

The start time.

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

