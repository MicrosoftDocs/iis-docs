---
title: IManifestStream.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 06636435-83a0-44e8-ad4c-992afdfa58bd
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822669(v=VS.90)
ms:contentKeyID: 50079424
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestStream.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the stream level attributes from the manifest.

## Syntax

``` csharp
string GetAttribute(
string name
)
```

``` c++
String^ GetAttribute(
[InAttribute] String^ name
)
```

``` jscript
function GetAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: [String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))

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

