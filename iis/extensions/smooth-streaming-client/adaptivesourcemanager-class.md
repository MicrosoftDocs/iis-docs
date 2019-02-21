---
title: AdaptiveSourceManager Class
TOCTitle: AdaptiveSourceManager Class
ms:assetid: e8073a26-452b-461a-9a0f-32085dc000ae
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/JJ822860(v=VS.90)
ms:contentKeyID: 50079614
ms.date: 11/19/2012
mtps_version: v=VS.90
dev_langs:
- csharp
- "cpp"
- jscript
---

# AdaptiveSourceManager Class

**Applies to:** Windows Store apps only

Represents the adaptive source single playback session.

## Syntax

```csharp
[VersionAttribute()]
[StaticAttribute(typeof(IAdaptiveSourceManagerStatics), )]
public sealed class AdaptiveSourceManager : IAdaptiveSourceManager
```

```cpp
[VersionAttribute()]
[StaticAttribute(typeof(IAdaptiveSourceManagerStatics), )]
public ref class AdaptiveSourceManager sealed : IAdaptiveSourceManager
```

```jscript
public final class AdaptiveSourceManager implements IAdaptiveSourceManager
```

## Members

This class exposes the following members.

### Methods

|Method|Description|
|--- |--- |
|[GetDefault](adaptivesourcemanager-getdefault-method.md)|Gets the source manager singleton.|
|[SendExtendedCommand](adaptivesourcemanager-sendextendedcommand-method.md)|Reserved for future use.|
|[SetBufferDelaySec](adaptivesourcemanager-setbufferdelaysec-method.md)|Sets the buffer delay in seconds before playback starts.|
|[SetDownloadBufferSec](adaptivesourcemanager-setdownloadbuffersec-method.md)|Sets the downloader buffer in seconds.|
|[SetDownloaderPlugin](adaptivesourcemanager-setdownloaderplugin-method.md)|Sets the downloader plugin.|
|[SetLiveBackoffSec](adaptivesourcemanager-setlivebackoffsec-method.md)|Sets the seconds backed off from current live server time.|
|[SetLiveBeginOffsetSec](adaptivesourcemanager-setlivebeginoffsetsec-method.md)|Sets the seconds after first chunk to start playing at when tuning to left edge, when tuning to live.|
|[SetPlaybackOffsetSec](adaptivesourcemanager-setplaybackoffsetsec-method.md)|Sets the seconds playback is backed off from when tuning to live.|


### Properties

|Property|Description|
|--- |--- |
|[AdaptiveSources](adaptivesourcemanager-adaptivesources-property.md)|Gets the list of opened adaptive sources.|


### Events

|Method|Description|
|--- |--- |
|[AdaptiveSourceClosedEvent](adaptivesourcemanager-adaptivesourceclosedevent-event.md)|Occurs when the adaptive source is closed.|
|[AdaptiveSourceFailedEvent](adaptivesourcemanager-adaptivesourcefailedevent-event.md)|Occurs when the adaptive source event failed.|
|[AdaptiveSourceManagerFailedEvent](adaptivesourcemanager-adaptivesourcemanagerfailedevent-event.md)|Occurs when the AdaptiveSourceManager event failed.|
|[AdaptiveSourceOpenedEvent](adaptivesourcemanager-adaptivesourceopenedevent-event.md)|Occurs when the adaptive source is opened.|
|[AdaptiveSourceStatusUpdatedEvent](adaptivesourcemanager-adaptivesourcestatusupdatedevent-event.md)|Occurs when the adaptive source status is updated.|
|[ManifestReadyEvent](adaptivesourcemanager-manifestreadyevent-event.md)|Occurs when the manifest is ready.|


## Requirements

|||
|--- |--- |
|**Minimum supported client**|Windows 8|
|**Minimum supported server**|Not Supported|
|**Metadata**|Microsoft.Media.AdaptiveStreaming.winmd|

