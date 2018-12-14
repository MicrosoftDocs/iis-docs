---
title: IManifestTrack Interface.GetCustomAttribute Method
TOCTitle: GetCustomAttribute Method
ms:assetid: 65e59412-e7f9-4d26-954f-8d803ce347d2
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822752(v=VS.90)
ms:contentKeyID: 50079507
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestTrack Interface.GetCustomAttribute Method

**Applies to:** Windows Store apps only

Gets the track level custom attributes from the manifest.

## Syntax

``` csharp
string GetCustomAttribute(
string name
)
```

``` c++
String^ GetCustomAttribute(
[InAttribute] String^ name
)
```

``` jscript
function GetCustomAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: [String](https://msdn.microsoft.com/en-us/library/s1wwdcbf\(v=vs.90\))

## Return Value

The track level custom attributes from the manifest.

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

