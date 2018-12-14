---
title: IHttpCookie.Flags Property
TOCTitle: Flags Property
ms:assetid: 378ce4b0-837c-4c12-bca4-c22f71ee3fcd
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822715(v=VS.90)
ms:contentKeyID: 50079470
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IHttpCookie.Flags Property

**Applies to:** Windows Store apps only

Gets the flags of the h ttp cookie.

## Syntax

``` csharp
uint Flags { get; set; }
```

``` c++
property unsigned int Flags {
unsigned int get ();
void set (unsigned int value); 
}
```

``` jscript
function get Flags () : uint
function set Flags (value : uint) 
```

## Property Value

Type: System.UInt32

The flags of the http cookie.

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

