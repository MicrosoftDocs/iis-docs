---
title: HttpCookie.Flags Property
TOCTitle: Flags Property
ms:assetid: 379945b4-79f8-46a0-8931-020a6be57e2c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822716(v=VS.90)
ms:contentKeyID: 50079471
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# HttpCookie.Flags Property

**Applies to:** Windows Store apps only

Gets the flags of the http cookie.

## Syntax

``` csharp
public uint Flags { get; set; }
```

``` c++
public:
virtual property unsigned int Flags {
unsigned int get () sealed;
void set (unsigned int value) sealed;
}
```

``` jscript
final function get Flags () : uint
final function set Flags (value : uint)
```

## Property Value

The flags.

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

