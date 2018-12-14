---
title: Manifest.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 94e846e7-90f8-489c-81f7-1b8a0190672a
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822786(v=VS.90)
ms:contentKeyID: 50079540
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# Manifest.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the stream level attributes from the manifest.

## Syntax

``` csharp
public string GetAttribute(
string name
)
```

``` c++
public:
virtual String^ GetAttribute(
[InAttribute] String^ name
) sealed
```

``` jscript
public final function GetAttribute(
name : String
) : String
```

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

