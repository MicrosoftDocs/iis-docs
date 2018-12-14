---
title: ManifestTrack.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: b0ed9843-4ef2-4fdc-be81-738373f07492
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822809(v=VS.90)
ms:contentKeyID: 50079563
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestTrack.GetAttribute Method

**Applies to:** Windows Store apps only

Gets the track level attributes from the manifest.

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

