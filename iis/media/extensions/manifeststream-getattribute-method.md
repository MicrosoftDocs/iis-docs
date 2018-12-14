---
title: ManifestStream.GetAttribute Method
TOCTitle: GetAttribute Method
ms:assetid: 197c214d-1f9c-4738-b4e1-70f9a8126160
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822690(v=VS.90)
ms:contentKeyID: 50079445
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream.GetAttribute Method

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

