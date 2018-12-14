---
title: ManifestTrack.GetCustomAttribute Method
TOCTitle: GetCustomAttribute Method
ms:assetid: a7aa7fdf-b76a-447b-8dd6-b49b4ea50e6c
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822805(v=VS.90)
ms:contentKeyID: 50079559
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestTrack.GetCustomAttribute Method

**Applies to:** Windows Store apps only

Gets the track level custom attributes from the manifest.

## Syntax

``` csharp
public string GetCustomAttribute(
string name
)
```

``` c++
public:
virtual String^ GetCustomAttribute(
[InAttribute] String^ name
) sealed
```

``` jscript
public final function GetCustomAttribute(
name : String
) : String
```

## Parameters

  - name  
    Type: System.String

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

