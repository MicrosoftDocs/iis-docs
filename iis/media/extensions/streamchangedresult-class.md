---
title: StreamChangedResult Class
TOCTitle: StreamChangedResult Class
ms:assetid: 0515e63d-b0e8-4902-a477-e9dea0cdc485
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822668(v=VS.90)
ms:contentKeyID: 50079423
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# StreamChangedResult Class

**Applies to:** Windows Store apps only

Represents the results when the stream is changed.

## Syntax

``` csharp
[VersionAttribute()]
public sealed class StreamChangedResult : IStreamChangedResult
```

``` c++
[VersionAttribute()]
public ref class StreamChangedResult sealed : IStreamChangedResult
```

``` jscript
public final class StreamChangedResult implements IStreamChangedResult
```

## Members

This class exposes the following members.

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
<td><p><a href="streamchangedresult-action-property.md">Action</a></p></td>
<td><p>Gets the action of the stream.</p></td>
</tr>
<tr class="even">
<td><p><a href="streamchangedresult-resultcode-property.md">ResultCode</a></p></td>
<td><p>Gets the result code.</p></td>
</tr>
<tr class="odd">
<td><p><a href="streamchangedresult-stream-property.md">Stream</a></p></td>
<td><p>Gets a stream that is selected or de-selected.</p></td>
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

