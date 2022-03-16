---
title: IManifestTrack Interface
TOCTitle: IManifestTrack Interface
ms:assetid: 5f90d2dd-9e42-4bc7-affb-1f44364268d6
ms:mtpsurl: https://msdn.microsoft.com/library/JJ822746(v=VS.90)
ms:contentKeyID: 50079501
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- cpp
- jscript
---

# IManifestTrack Interface

**Applies to:** Windows Store apps only

IManifestTrack interface.

## Syntax

```csharp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface IManifestTrack
```

```cpp
[VersionAttribute()]
[GuidAttribute(, , , , , , , , , , )]
public interface class IManifestTrack
```

```jscript
public interface IManifestTrack
```

## Members

This interface exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[GetAttribute](imanifesttrack-interface-getattribute-method.md)|Gets the track level attributes from the manifest.|
|[GetCustomAttribute](imanifesttrack-interface-getcustomattribute-method.md)|Gets the track level custom attributes from the manifest.|

### Properties

|Property|Description|
|--- |--- |
|[AudioTag](imanifesttrack-interface-audiotag-property.md)|Gets the 'AudioTag' field.|
|[Bitrate](imanifesttrack-interface-bitrate-property.md)|Gets the track 'Bitrate' field.|
|[CodecPrivateData](imanifesttrack-interface-codecprivatedata-property.md)|Gets the CodecPrivateData.|
|[CustomAttributeNames](imanifesttrack-interface-customattributenames-property.md)|Gets the track level custom attributes names.|
|[FourCC](imanifesttrack-interface-fourcc-property.md)|Gets the FourCC.|
|[HardwareProfile](imanifesttrack-interface-hardwareprofile-property.md)|Gets the 'HardwareProfile' field.|
|[MaxHeight](imanifesttrack-interface-maxheight-property.md)|Gets the track 'MaxHeight' field.|
|[MaxWidth](imanifesttrack-interface-maxwidth-property.md)|Gets the track 'MaxWidth' field.|
|[NAUnitLength](imanifesttrack-interface-naunitlength-property.md)|Gets the ‘NALUnitLength’ field.|
|[NominalBitrate](imanifesttrack-interface-nominalbitrate-property.md)|Gets the track 'NominalBitrate' field.|
|[Stream](imanifesttrack-interface-stream-property.md)|Gets the stream object that owns this track.|
|[TrackIndex](imanifesttrack-interface-trackindex-property.md)|Gets the index of the track in the manifest.|

## Requirements

|Requirement|Description|
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|
