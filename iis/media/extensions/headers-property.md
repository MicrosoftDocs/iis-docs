---
title: Headers Property
TOCTitle: Headers Property
ms:assetid: fff38b05-57c8-43fe-9542-820baa63c0f0
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822882(v=VS.90)
ms:contentKeyID: 50079636
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Headers Property

**Applies to:** Windows Store apps only

Gets the headers.

## Syntax

``` csharp
public IMapView<string, string> Headers { get; }
```

``` c++
public:
virtual property IMapView<String^, String^>^ Headers {
IMapView<String^, String^>^ get () sealed;
}
```

``` jscript
final function get Headers () : IMapView<String, String>
```

## Property Value

The headers.

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

