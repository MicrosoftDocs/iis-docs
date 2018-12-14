---
title: ManifestTrack Class
TOCTitle: ManifestTrack Class
ms:assetid: 9782a68b-91c3-4a9c-9a78-b2a73c5351cd
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822790(v=VS.90)
ms:contentKeyID: 50079544
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestTrack Class

**Applies to:** Windows Store apps only

The manifest track class.

## Syntax

``` csharp
[VersionAttribute()]
public sealed class ManifestTrack : IManifestTrack
```

``` c++
[VersionAttribute()]
public ref class ManifestTrack sealed : IManifestTrack
```

``` jscript
public final class ManifestTrack implements IManifestTrack
```

## Members

This class exposes the following members.

### Methods

<table>
<colgroup>
<col style="width: 50%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th><p>Method</p></th>
<th><p>Description</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p><a href="manifesttrack-getattribute-method.md">GetAttribute</a></p></td>
<td><p>Gets the track level attributes from the manifest.</p></td>
</tr>
<tr class="even">
<td><p><a href="manifesttrack-getcustomattribute-method.md">GetCustomAttribute</a></p></td>
<td><p>Gets the track level custom attributes from the manifest.</p></td>
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

