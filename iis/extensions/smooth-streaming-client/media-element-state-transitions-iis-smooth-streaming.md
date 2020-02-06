---
title: Media Element State Transitions (IIS Smooth Streaming)
TOCTitle: Media Element State Transitions (IIS Smooth Streaming)
ms:assetid: 832d004b-fc61-4e1e-918c-0eff386b8173
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728115(v=VS.90)
ms:contentKeyID: 31469135
ms.date: 05/02/2012
mtps_version: v=VS.90
---

# Media Element State Transitions (IIS Smooth Streaming)

There are eight possible states for a [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object. During state transitions, the [CurrentStateChanged](smoothstreamingmediaelement-currentstatechanged-event-microsoft-web-media-smoothstreaming_1.md) event may not behave as expected.

## Smooth Streaming Media Element State

A [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object can be in any of the following states, which are defined in the [SmoothStreamingMediaElementState](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) enumeration:

  - [Opening](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [Buffering](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [Playing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [Paused](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [Stopped](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [Individualizing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [AcquiringLicense](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

  - [ClipPlaying](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)

To work with an [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object's state and state transitions, you primarily use the following APIs:

  - The [SmoothStreamingMediaElementState](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) enumeration, which defines the states as listed above.

  - The [CurrentState](smoothstreamingmediaelement-currentstate-property-microsoft-web-media-smoothstreaming_1.md) property, which can be queried to get the state of a [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object.

  - The [CurrentStateProperty](smoothstreamingmediaelement-currentstateproperty-field-microsoft-web-media-smoothstreaming_1.md) property, which is a dependency property that is used for binding in XAML.

The following events are available to help you work with [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) state:

  - The [CurrentStateChanged](smoothstreamingmediaelement-currentstatechanged-event-microsoft-web-media-smoothstreaming_1.md) event, which occurs on every state change.

  - The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event, which occurs when seek finishes. Only one seek operation at a time will work. Developers can use this event to determine when a previous seek operation is finished and to block seek operations while a previous seek is in progress. This event is also raised when an application calls [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md).

  - The [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event, which occurs during the opening state and signals that the manifest has been downloaded and some initial actions can be called, such as [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md).

  - The [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event, which occurs during the opening state. For more information, see [Manifest Merge (IIS Smooth Streaming)](manifest-merge.md)

  - The [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) and [MediaFailed](smoothstreamingmediaelement-mediafailed-event-microsoft-web-media-smoothstreaming_1.md) events, which indicate issues that could set the state to closed.

### State Transitions

Several state-affecting conditions might have effects that may not be obvious, including the following:

  - During fast forwarding, when live play is reached, the playback rate is set to 1.0. The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - During rewind, if start is reached, the playback rate is set to 1.0. The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - If the [StartSeekToLive](smoothstreamingmediaelement-startseektolive-method-microsoft-web-media-smoothstreaming_1.md) method is called, playback rate is set to 1.0 and then [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - When the end of stream is reached, the state is set to [Paused](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md).

The following table shows states (rows) and how actions affect those states (columns). For example, if the current state is [Playing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) and the action is [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md), the resulting state is [Playing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md).

State Transition Matrix

|State/Action|Play|Pause|Set Playback Rate|Stop|Seek|Set Source|Select Tracks|Schedule Clip|
|--- |--- |--- |--- |--- |--- |--- |--- |--- |
|Playing|Playing. The action is ignored.|Paused|Playing. The new playback rate applies, which will be a value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) list.|Stopped|Playing. The current position is the new position. A [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event occurs when seek is complete.|Closed for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) setting is true or false. The playback rate will to 1.0.|Playing. The track should be switched immediately.|Playing/ClipPlaying. The clip run as scheduled. If the scheduled time is now, the state changes to clip playing. The application can monitor clip states.|
|Paused|Buffering/Playing. This action does not change the playback rate. When enough data has been buffered, the clip changes to playing state.|Paused. The action is ignored.|Playing. The new playback rate applies, which will be a value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) list.|Stopped.|Paused. The current position on the timeline becomes the new position.|Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) setting is true or false.|Paused.|Paused. The clip must take effect as scheduled. The clip changes to the playing state from the paused state only when the player is resumed.|
|Stopped|Buffering. Playback starts at zero.|Stopped. The clip is set to position zero.|Playing. The playback rate property is set to a new value from the [SupportedPlaybackRates](smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md) list.|Stopped. The request is ignored.|Paused. Goes to the new location indicated by the seek operation, then pauses.|Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the setting of the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) property is true or false.|Stopped.|Stopped. An [InvalidOperationException](https://msdn.microsoft.com/library/2asft85a) error is thrown.|
|Buffering|Playing. The state is changed from buffering to playing. For more details, see [Silverlight State Transition Matrix](https://msdn.microsoft.com/library/cc189079(vs.95).aspx).|Paused|Buffering. Call [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) immediately.|Stopped|Buffering. This action starts a seek operation.|Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) setting is true or false.|Buffering. Call [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md) immediately.|Buffering. The clip must take effect as scheduled. The clip starts in playing state.|
|Opening|Opening. The request is ignored|Opening. The request is ignored|Opening. The request is ignored|Opening. The request is ignored|Opening. The request is ignored|Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the [AutoPlay](smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md) setting is true or false.|Opening. The request is ignored|Opening. The request is ignored|
|ClipPlaying. (See note following table.)|ClipPlaying. If the clip was paused, it resumes.|ClipPlaying. If the clip was playing, it is paused.|ClipPlaying. An [InvalidOperationException](https://msdn.microsoft.com/library/2asft85a) error is thrown.|Stopped. All actions are stopped.|ClipPlaying. An [InvalidOperationException](https://msdn.microsoft.com/library/2asft85a) error is thrown.|Closed.|ClipPlaying. The track should be changed on the main video, but not on the clip.|ClipPlaying. The clip must play as scheduled. The clip starts in Playing state. The most recently started clip takes precedence, and any other clip is stopped and unscheduled.|



> [!NOTE]  
> The ClipPlaying state is used only to determine when a clip is in the active window. There are other states associated with the clip. Applications can use [ClipStateChanged](smoothstreamingmediaelement-clipstatechanged-event-microsoft-web-media-smoothstreaming_1.md) and [CurrentClipState](clipcontext-currentclipstate-property-microsoft-web-media-smoothstreaming_1.md) to get these states.



> [!NOTE]  
> The player state does not change to [Stopped](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) when the manifest/license manager URL is invalid. Instead, the clip remains in [Opening](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) state.


## See Also

### Concepts

[Manifest Merge (IIS Smooth Streaming)](manifest-merge.md)

### Other Resources

[MediaElement States](https://go.microsoft.com/fwlink/?linkid=230681)

