---
title: IAdaptiveSourceManager.SendExtendedCommand Method
TOCTitle: SendExtendedCommand Method
ms:assetid: 2ce10730-3944-4f32-910e-416cbdba2eab
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822708(v=VS.90)
ms:contentKeyID: 50079463
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSourceManager.SendExtendedCommand Method

**Applies to:** Windows Store apps only

Reserved for future use.

## Syntax

``` csharp
void SendExtendedCommand(
string cmd,
string parameter
)
```

``` c++
void SendExtendedCommand(
[InAttribute] String^ cmd,
[InAttribute] String^ parameter
)
```

``` jscript
function SendExtendedCommand(
cmd : String,
parameter : String
)
```

## Parameters

  - cmd  
    Type: System.String

  - parameter  
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

