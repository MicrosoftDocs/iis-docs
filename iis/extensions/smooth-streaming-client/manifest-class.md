---
title: Manifest Class
description: This article has information on syntax for the Manifest class, as well as members exposed by this class. 
TOCTitle: Manifest Class
ms:assetid: f0a9e6d7-5714-49c0-9470-25fa5be0013f
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822869(v=VS.90)
ms:contentKeyID: 50079623
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# Manifest Class

**Applies to:** Windows Store apps only

The manifest class.

## Syntax

```csharp
[VersionAttribute()]
public sealed class Manifest
```

```cpp
[VersionAttribute()]
public ref class Manifest sealed
```

```jscript
public final class Manifest
```

## Members

This class exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[GetAttribute](manifest-getattribute-method.md)|Gets the stream level attributes from the manifest.|
|[SelectStreamsAsync](manifest-selectstreamsasync-method.md)|Select the streams in the current manifest.|

### Properties

|Property|Description|
|--- |--- |
|[AvailableStreams](manifest-availablestreams-property.md)|Gets the available streams.|
|[Duration](manifest-duration-property.md)|Gets the manifest 'Duration' field.|
|[DVRWindowLength](manifest-dvrwindowlength-property.md)|Gets the manifest 'DVRWindowLength' field.|
|[IsLive](manifest-islive-property.md)|Gets the manifest 'isLive' field.|
|[LookAheadCount](manifest-lookaheadcount-property.md)|Gets the manifest 'LookAheadFragmentCount' field.|
|[MajorVersion](manifest-majorversion-property.md)|Gets the manifest 'MajorVersion' field.|
|[MinorVersion](manifest-minorversion-property.md)|Gets the manifest 'MinorVersion' field.|
|[SelectedStreams](manifest-selectedstreams-property.md)|Gets the selected streams.|
|[StartTime](manifest-starttime-property.md)|Gets the manifest start time.|
|[TimeScale](manifest-timescale-property.md)|Gets the manifest 'TimeScale' field.|
|[Type](manifest-type-property.md)||

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
