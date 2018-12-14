---
title: IManifestTrack Interface
TOCTitle: IManifestTrack Interface
ms:assetid: 5f90d2dd-9e42-4bc7-affb-1f44364268d6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822746(v=VS.90)
ms:contentKeyID: 50079501
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IManifestTrack Interface

**Applies to:** Windows Store apps only

IManifestTrack interface.

## Syntax

``` csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IManifestTrack
```

``` c++
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IManifestTrack
```

``` jscript
public interface IManifestTrack
```

## Members

This interface exposes the following members.

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
<td><p><a href="imanifesttrack-interface-getattribute-method.md">GetAttribute</a></p></td>
<td><p>Gets the track level attributes from the manifest.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-getcustomattribute-method.md">GetCustomAttribute</a></p></td>
<td><p>Gets the track level custom attributes from the manifest.</p></td>
</tr>
</tbody>
</table>


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
<td><p><a href="imanifesttrack-interface-audiotag-property.md">AudioTag</a></p></td>
<td><p>Gets the 'AudioTag' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-bitrate-property.md">Bitrate</a></p></td>
<td><p>Gets the track 'Bitrate' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifesttrack-interface-codecprivatedata-property.md">CodecPrivateData</a></p></td>
<td><p>Gets the CodecPrivateData.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-customattributenames-property.md">CustomAttributeNames</a></p></td>
<td><p>Gets the track level custom attributes names.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifesttrack-interface-fourcc-property.md">FourCC</a></p></td>
<td><p>Gets the FourCC.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-hardwareprofile-property.md">HardwareProfile</a></p></td>
<td><p>Gets the 'HardwareProfile' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifesttrack-interface-maxheight-property.md">MaxHeight</a></p></td>
<td><p>Gets the track 'MaxHeight' field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-maxwidth-property.md">MaxWidth</a></p></td>
<td><p>Gets the track 'MaxWidth' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifesttrack-interface-naunitlength-property.md">NAUnitLength</a></p></td>
<td><p>Gets the ‘NALUnitLength’ field.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-nominalbitrate-property.md">NominalBitrate</a></p></td>
<td><p>Gets the track 'NominalBitrate' field.</p></td>
</tr>
<tr class="odd">
<td><p><a href="imanifesttrack-interface-stream-property.md">Stream</a></p></td>
<td><p>Gets the stream object that owns this track.</p></td>
</tr>
<tr class="even">
<td><p><a href="imanifesttrack-interface-trackindex-property.md">TrackIndex</a></p></td>
<td><p>Gets the index of the track in the manifest.</p></td>
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

