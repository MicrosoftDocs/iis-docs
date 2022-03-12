---
title: IManifestStream Interface
TOCTitle: IManifestStream Interface
ms:assetid: ddaf345c-e931-40e2-82eb-e819f04876d2
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822846(v=VS.90)
ms:contentKeyID: 50079600
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestStream Interface

**Applies to:** Windows Store apps only

Represents the stream interface.

## Syntax

```csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IManifestStream
```

```cpp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IManifestStream
```

```jscript
public interface IManifestStream
```

## Members

This interface exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[DownloadFragmentAsync](imanifeststream-downloadfragmentasync-method.md)|Downloads the fragment data for the given chunk iterator through async call.|
|[GetAttribute](imanifeststream-getattribute-method.md)|Gets the stream level attributes from the manifest.|
|[GetChunkInfoAsync](imanifeststream-getchunkinfoasync-method.md)|Gets the chunk info of the given chunk iterator through async call.|
|[GetIterator](imanifeststream-getiterator-method.md)|Gets the last chunk iterator within the specified time range.|
|[RestrictTracks](imanifeststream-restricttracks-method.md)|Restricts the tracks to a subset of all the available tracks.|
|[SelectTracks](imanifeststream-selecttracks-method.md)|Selects the tracks in a subset of all the available tracks.|

### Properties

|Property|Description|
|--- |--- |
|[AvailableTracks](imanifeststream-availabletracks-property.md)|Gets the available tracks in the current stream.|
|[ChildStreams](imanifeststream-childstreams-property.md)|Gets the child (sparse) streams of this stream.|
|[DisplayHeight](imanifeststream-displayheight-property.md)|Gets the stream 'DisplayHeight' field.|
|[DisplayWidth](imanifeststream-displaywidth-property.md)|Gets the stream 'DisplayWidth' field.|
|[FirstInCurrentChunklist](imanifeststream-firstincurrentchunklist-property.md)|Gets the first chunk iterator in the current chunklist.|
|[Language](imanifeststream-language-property.md)|Gets the stream 'Language' field.|
|[LastInCurrentChunkList](imanifeststream-lastincurrentchunklist-property.md)|Gets the last chunk iterator in the current chunklist.|
|[MaxHeight](imanifeststream-maxheight-property.md)|Gets the stream 'MaxHeight' field.|
|[MaxWidth](imanifeststream-maxwidth-property.md)|Gets the stream 'MaxWidth' field.|
|[Name](imanifeststream-name-property.md)|Gets the stream 'Name' field.|
|[ParentStream](imanifeststream-parentstream-property.md)|Gets the parent stream of this stream.|
|[SelectedTracks](imanifeststream-selectedtracks-property.md)|Gets the selected tracks in the current stream.|
|[SubType](imanifeststream-subtype-property.md)|Gets the stream 'SubType' field.|
|[TimeScale](imanifeststream-timescale-property.md)|Gets the stream 'TimeScale' field.|
|[Type](imanifeststream-type-property.md)|Gets the stream 'Type' field.|
|[Url](imanifeststream-url-property.md)|Gets the url template.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
