---
title: Manifest.LookAheadCount Property
TOCTitle: LookAheadCount Property
ms:assetid: 8e0e38cc-99e6-464c-8860-0bd0aa1141dc
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822780(v=VS.90)
ms:contentKeyID: 50079534
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.LookAheadCount Property

**Applies to:** Windows Store apps only

Gets the manifest 'LookAheadFragmentCount' field.

## Syntax

``` csharp
public uint LookAheadCount { get; }
```

``` c++
public:
virtual property unsigned int LookAheadCount {
unsigned int get () sealed;
}
```

``` jscript
final function get LookAheadCount () : uint
```

## Property Value

The manifest 'LookAheadFragmentCount' field.

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

