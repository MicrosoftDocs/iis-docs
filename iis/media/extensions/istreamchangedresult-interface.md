---
title: IStreamChangedResult Interface
TOCTitle: IStreamChangedResult Interface
ms:assetid: 9e3acbba-11bd-437a-a96d-4a4382e83fce
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822796(v=VS.90)
ms:contentKeyID: 50079550
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IStreamChangedResult Interface

**Applies to:** Windows Store apps only

Stream changed result interface.

## Syntax

``` csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IStreamChangedResult
```

``` c++
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IStreamChangedResult
```

``` jscript
public interface IStreamChangedResult
```

## Members

This interface exposes the following members.

### Properties

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Property</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="istreamchangedresult-action-property.md">Action</a></p></td>
<td><p>Gets the action of the stream.</p></td>
</tr>
<tr class="even">
<td><p><a href="istreamchangedresult-resultcode-property.md">ResultCode</a></p></td>
<td><p>Gets the result code.</p></td>
</tr>
<tr class="odd">
<td><p><a href="istreamchangedresult-stream-property.md">Stream</a></p></td>
<td><p>Gets the stream that is selected or de-selected.</p></td>
</tr>
</tbody>
</table>


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

