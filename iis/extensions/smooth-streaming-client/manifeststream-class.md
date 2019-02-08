---
title: ManifestStream Class
TOCTitle: ManifestStream Class
ms:assetid: c07d1103-508b-4763-ab69-0007842dc6a6
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822825(v=VS.90)
ms:contentKeyID: 50079579
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# ManifestStream Class

**Applies to:** Windows Store apps only

The manifest stream class.

## Syntax

``` csharp
[VersionAttribute()]
public sealed class ManifestStream : IManifestStream
```

``` c++
[VersionAttribute()]
public ref class ManifestStream sealed : IManifestStream
```

``` jscript
public final class ManifestStream implements IManifestStream
```

## Members

### Methods

|Method|Description|
|--- |--- |
|[DownloadFragmentAsync](manifeststream-downloadfragmentasync-method.md)|Downloads the fragment data for the given chunk iterator through an async call.|
|[GetAttribute](manifeststream-getattribute-method.md)|Gets the stream level attributes from the manifest.|
|[GetChunkInfoAsync](manifeststream-getchunkinfoasync-method.md)|Gets the chunk info of the given chunk iterator through async call.|
|[GetIterator](manifeststream-getiterator-method.md)|Gets the last chunk iterator within the specified time range.|
|[RestrictTracks](manifeststream-restricttracks-method.md)|Restricts the tracks to a subset of all the available tracks.|
|[SelectTracks](manifeststream-selecttracks-method.md)|Selects the tracks in a subset of all the available tracks.|


### Properties

|Property|Description|
|--- |--- |
|[AvailableTracks](manifeststream-availabletracks-property.md)|Gets the available tracks in the current stream.|
|[ChildStreams](manifeststream-childstreams-property.md)|Gets the child (sparse) streams of this stream.|
|[DisplayHeight](manifeststream-displayheight-property.md)|Gets the stream 'DisplayHeight' field.|
|[DisplayWidth](manifeststream-displaywidth-property.md)|Gets the stream ‘DisplayWidth’ field.|
|[FirstInCurrentChunkList](manifeststream-firstincurrentchunklist-property.md)|Gets the first chunk iterator in the current chunklist.|
|[Language](manifeststream-language-property.md)|Gets the stream 'Language' field.|
|[LastInCurrentChunkList](manifeststream-lastincurrentchunklist-property.md)|Gets the last chunk iterator in the current chunklist.|
|[MaxHeight](manifeststream-maxheight-property.md)|Gets the stream 'MaxHeight' field.|
|[MaxWidth](manifeststream-maxwidth-property.md)|Gets the stream 'MaxWidth' field.|
|[Name](manifeststream-name-property.md)|Gets the stream 'Name' field.|
|[ParentStream](manifeststream-parentstream-property.md)|Gets the parent stream of this stream. This stream is typically a sparse stream.|
|[SelectedTracks](manifeststream-selectedtracks-property.md)|Gets the selected tracks in the current stream.|
|[SubType](manifeststream-subtype-property.md)|Gets the stream 'SubType' field.|
|[TimeScale](manifeststream-timescale-property.md)|Gets the stream 'TimeScale' field.|
|[Type](manifeststream-type-property.md)|Gets the manifest type.|
|[Url](manifeststream-url-property.md)|Gets the URL template.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

