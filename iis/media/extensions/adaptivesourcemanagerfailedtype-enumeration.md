---
title: AdaptiveSourceManagerFailedType Enumeration
TOCTitle: AdaptiveSourceManagerFailedType Enumeration
ms:assetid: 8b35b3ed-32a7-4451-a2c7-57cf70d68b11
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822773(v=VS.90)
ms:contentKeyID: 50079528
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# AdaptiveSourceManagerFailedType Enumeration

**Applies to:** Windows Store apps only

Represents the adaptive source manager failed type enumeration.

## Syntax

``` csharp
[VersionAttribute()]
public enum AdaptiveSourceManagerFailedType
```

``` c++
[VersionAttribute()]
public enum class AdaptiveSourceManagerFailedType
```

``` jscript
public enum AdaptiveSourceManagerFailedType
```

## Enumeration Values

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 33%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Name</p></th>
<th><p>Value</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Unknown</p></td>
<td><p>100</p></td>
<td><p>Generic error.</p></td>
</tr>
<tr class="even">
<td><p>SetDownloadBufferFailed</p></td>
<td><p>200</p></td>
<td><p>The download buffer failed.</p></td>
</tr>
<tr class="odd">
<td><p>SetBufferDelayFailed</p></td>
<td><p>201</p></td>
<td><p>The buffer delay failed.</p></td>
</tr>
<tr class="even">
<td><p>SetLiveBackoffFailed</p></td>
<td><p>202</p></td>
<td><p>The live back off failed.</p></td>
</tr>
<tr class="odd">
<td><p>SetPlaybackOffsetFailed</p></td>
<td><p>203</p></td>
<td><p>The playback off set failed.</p></td>
</tr>
<tr class="even">
<td><p>SetLiveBeginOffsetFailed</p></td>
<td><p>204</p></td>
<td><p>The live begin off set failed.</p></td>
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

