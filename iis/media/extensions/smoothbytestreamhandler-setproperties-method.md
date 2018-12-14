---
title: SmoothByteStreamHandler.SetProperties Method
TOCTitle: SetProperties Method
ms:assetid: 1797d7e6-4646-4c00-9bdc-c51462705e66
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822685(v=VS.90)
ms:contentKeyID: 50079440
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# SmoothByteStreamHandler.SetProperties Method

**Applies to:** Windows Store apps only

Sets the Smooth Byte Stream Handler properties.

## Syntax

``` csharp
public void SetProperties(
IPropertySet configuration
)
```

``` c++
public:
virtual void SetProperties(
[InAttribute] IPropertySet^ configuration
) sealed
```

``` jscript
public final function SetProperties(
configuration : IPropertySet
)
```

## Parameters

  - configuration  
    Type: IPropertySet

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

