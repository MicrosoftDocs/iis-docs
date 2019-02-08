---
title: IAdaptiveSource Interface
TOCTitle: IAdaptiveSource Interface
ms:assetid: d0656cbb-c4f9-407d-9566-cf840783d895
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822837(v=VS.90)
ms:contentKeyID: 50079591
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- c++
- jscript
---

# IAdaptiveSource Interface

**Applies to:** Windows Store apps only

Adaptive source, single playback session.

## Syntax

``` csharp
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface IAdaptiveSource
```

``` c++
[GuidAttribute(, , , , , , , , , , )]
[VersionAttribute()]
public interface class IAdaptiveSource
```

``` jscript
public interface IAdaptiveSource
```

## Members

This interface exposes the following members.

### Properties

|Property|Description|
|--- |--- |
|[Manifest](iadaptivesource-manifest-property.md)|Gets the manifest.|
|[Uri](iadaptivesource-uri-property.md)|Gets the URI.|


### Events

|Method|Description|
|--- |--- |
|AdaptiveSourceFailedEvent|Adds the failed event handler.|
|[AdaptiveSourceStatusUpdatedEvent](iadaptivesource-adaptivesourcestatusupdatedevent-event.md)|Adds the status updated event handler.|
|[ManifestReadyEvent](iadaptivesource-manifestreadyevent-event.md)|Adds the manifest ready event handler.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

