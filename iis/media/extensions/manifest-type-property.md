---
title: Manifest.Type Property
TOCTitle: Type Property
ms:assetid: bfc7c8b2-bb68-46c4-8ee6-0203b8485eb9
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822823(v=VS.90)
ms:contentKeyID: 50079577
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.Type Property

**Applies to:** Windows Store apps only

Gets the manifest type.

## Syntax

``` csharp
public ManifestType Type { get; }
```

``` c++
public: 
virtual property ManifestType Type {
ManifestType get () sealed; 
}
```

``` jscript
final function get Type () : ManifestType
```

## Property Value

Type: [AdaptiveStreaming.ManifestType](manifesttype-enumeration.md)

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

