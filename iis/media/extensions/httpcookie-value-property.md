---
title: HttpCookie.Value Property
TOCTitle: Value Property
ms:assetid: 9d33fd25-e5d7-4ca0-bcc1-e97ff49617bf
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822795(v=VS.90)
ms:contentKeyID: 50079549
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# HttpCookie.Value Property

**Applies to:** Windows Store apps only

Gets the value of the http cookie.

## Syntax

``` csharp
public string Value { get; set; }
```

``` c++
public:
virtual property String^ Value {
String^ get () sealed;
void set (String^ value) sealed;
}
```

``` jscript
final function get Value () : String
final function set Value (value : String)
```

## Property Value

The value of the http cookie.

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

