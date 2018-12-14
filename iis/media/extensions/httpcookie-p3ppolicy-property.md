---
title: HttpCookie.P3PPolicy Property
TOCTitle: P3PPolicy Property
ms:assetid: e60a43b1-37c8-480d-97dd-08a47278ef0e
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822856(v=VS.90)
ms:contentKeyID: 50079610
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# HttpCookie.P3PPolicy Property

**Applies to:** Windows Store apps only

Gets the P3P policy of the http cookie.

## Syntax

``` csharp
public string P3PPolicy { get; set; }
```

``` c++
public:
virtual property String^ P3PPolicy {
String^ get () sealed;
void set (String^ value) sealed;
}
```

``` jscript
final function get P3PPolicy () : String
final function set P3PPolicy (value : String)
```

## Property Value

The P3P policy.

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

