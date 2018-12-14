---
title: HttpCookie.ExpireTime Property
TOCTitle: ExpireTime Property
ms:assetid: e20dd9e5-262d-4e6b-9671-f6a2434f7cfe
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822854(v=VS.90)
ms:contentKeyID: 50079608
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# HttpCookie.ExpireTime Property

**Applies to:** Windows Store apps only

Gets the expire time.

## Syntax

``` csharp
 public DateTime ExpireTime { get; set; }
```

``` c++
 public:
virtual property DateTime ExpireTime {
DateTime get () sealed;
void set (DateTime value) sealed;
}
```

``` jscript
 final function get ExpireTime () : DateTime
final function set ExpireTime (value : DateTime)
```

## Property Value

The expire time.

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

