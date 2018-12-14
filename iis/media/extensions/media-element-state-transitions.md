---
title: Media Element State Transitions
TOCTitle: Media Element State Transitions
ms:assetid: 832d004b-fc61-4e1e-918c-0eff386b8173
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728115(v=VS.95)
ms:contentKeyID: 46359326
ms.date: 05/31/2012
mtps_version: v=VS.95
---

# Media Element State Transitions

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

  - The [ManifestMerge](smoothstreamingmediaelement-manifestmerge-event-microsoft-web-media-smoothstreaming_1.md) event, which occurs during the opening state. For more information, see [Manifest Merge](manifest-merge.md)

  - The [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) and [MediaFailed](smoothstreamingmediaelement-mediafailed-event-microsoft-web-media-smoothstreaming_1.md) events, which indicate issues that could set the state to closed.

### State Transitions

Several state-affecting conditions might have effects that may not be obvious, including the following:

  - During fast forwarding, when live play is reached, the playback rate is set to 1.0. The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - During rewind, if start is reached, the playback rate is set to 1.0. The [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - If the [StartSeekToLive](smoothstreamingmediaelement-startseektolive-method-microsoft-web-media-smoothstreaming_1.md) method is called, playback rate is set to 1.0 and then [SeekCompleted](smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md) event is raised to indicate that the playback rate changed.

  - When the end of stream is reached, the state is set to [Paused](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md).

The following table shows states (rows) and how actions affect those states (columns). For example, if the current state is [Playing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md) and the action is [SetPlaybackRate](smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md), the resulting state is [Playing](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md).

State Transition Matrix

<table style="width:100%;">
<colgroup>
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
<col style="width: 11%" />
</colgroup>
<thead>
<tr class="header">
<th><p>State/Action</p></th>
<th><p>Play</p></th>
<th><p>Pause</p></th>
<th><p>Set Playback Rate</p></th>
<th><p>Stop</p></th>
<th><p>Seek</p></th>
<th><p>Set Source</p></th>
<th><p>Select Tracks</p></th>
<th><p>Schedule Clip</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td><p>Playing</p></td>
<td><p>Playing. The action is ignored.</p></td>
<td><p>Paused</p></td>
<td><p>Playing. The new playback rate applies, which will be a value from the <a href="smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md">SupportedPlaybackRates</a> list.</p></td>
<td><p>Stopped</p></td>
<td><p>Playing. The current position is the new position. A <a href="smoothstreamingmediaelement-seekcompleted-event-microsoft-web-media-smoothstreaming_1.md">SeekCompleted</a> event occurs when seek is complete.</p></td>
<td><p>Closed for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> setting is true or false. The playback rate will to 1.0.</p></td>
<td><p>Playing. The track should be switched immediately.</p></td>
<td><p>Playing/ClipPlaying. The clip run as scheduled. If the scheduled time is now, the state changes to clip playing. The application can monitor clip states.</p></td>
</tr>
<tr class="even">
<td><p>Paused</p></td>
<td><p>Buffering/Playing. This action does not change the playback rate. When enough data has been buffered, the clip changes to playing state.</p></td>
<td><p>Paused. The action is ignored.</p></td>
<td><p>Playing. The new playback rate applies, which will be a value from the <a href="smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md">SupportedPlaybackRates</a> list.</p></td>
<td><p>Stopped.</p></td>
<td><p>Paused. The current position on the timeline becomes the new position.</p></td>
<td><p>Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> setting is true or false.</p></td>
<td><p>Paused.</p></td>
<td><p>Paused. The clip must take effect as scheduled. The clip changes to the playing state from the paused state only when the player is resumed.</p></td>
</tr>
<tr class="odd">
<td><p>Stopped</p></td>
<td><p>Buffering. Playback starts at zero.</p></td>
<td><p>Stopped. The clip is set to position zero.</p></td>
<td><p>Playing. The playback rate property is set to a new value from the <a href="smoothstreamingmediaelement-supportedplaybackrates-property-microsoft-web-media-smoothstreaming_1.md">SupportedPlaybackRates</a> list.</p></td>
<td><p>Stopped. The request is ignored.</p></td>
<td><p>Paused. Goes to the new location indicated by the seek operation, then pauses.</p></td>
<td><p>Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the setting of the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> property is true or false.</p></td>
<td><p>Stopped.</p></td>
<td><p>Stopped. An <a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.95)">InvalidOperationException</a> error is thrown.</p></td>
</tr>
<tr class="even">
<td><p>Buffering</p></td>
<td><p>Playing. The state is changed from buffering to playing. For more details, see the <a href="http://go.microsoft.com/fwlink/?linkid=251079">MediaElement State Transition Table</a>.</p></td>
<td><p>Paused</p></td>
<td><p>Buffering. Call <a href="smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md">SetPlaybackRate</a> immediately.</p></td>
<td><p>Stopped</p></td>
<td><p>Buffering. This action starts a seek operation.</p></td>
<td><p>Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> setting is true or false.</p></td>
<td><p>Buffering. Call <a href="smoothstreamingmediaelement-setplaybackrate-method-microsoft-web-media-smoothstreaming_1.md">SetPlaybackRate</a> immediately.</p></td>
<td><p>Buffering. The clip must take effect as scheduled. The clip starts in playing state.</p></td>
</tr>
<tr class="odd">
<td><p>Opening</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Closed. This is for the clip that is currently playing. There can subsequently be a call for opening, buffering, or other actions, depending on whether the <a href="smoothstreamingmediaelement-autoplay-property-microsoft-web-media-smoothstreaming_1.md">AutoPlay</a> setting is true or false.</p></td>
<td><p>Opening. The request is ignored</p></td>
<td><p>Opening. An invalidOperationException error occurs.</p></td>
</tr>
<tr class="even">
<td><p>ClipPlaying. (See note following table.)</p></td>
<td><p>ClipPlaying. If the clip was paused, it resumes.</p></td>
<td><p>ClipPlaying. If the clip was playing, it is paused.</p></td>
<td><p>ClipPlaying. An <a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.95)">InvalidOperationException</a> error is thrown.</p></td>
<td><p>Stopped. All actions are stopped.</p></td>
<td><p>ClipPlaying. An <a href="https://msdn.microsoft.com/en-us/library/2asft85a(v=vs.95)">InvalidOperationException</a> error is thrown.</p></td>
<td><p>Closed.</p></td>
<td><p>ClipPlaying. The track should be changed on the main video, but not on the clip.</p></td>
<td><p>ClipPlaying. The clip must play as scheduled. The clip starts in Playing state. The most recently started clip takes precedence, and any other clip is stopped and unscheduled.</p></td>
</tr>
</tbody>
</table>



> [!NOTE]
> <P>The ClipPlaying state is used only to determine when a clip is in the active window. There are other states associated with the clip. Applications can use <A href="smoothstreamingmediaelement-clipstatechanged-event-microsoft-web-media-smoothstreaming_1.md">ClipStateChanged</A> and <A href="clipcontext-currentclipstate-property-microsoft-web-media-smoothstreaming_1.md">CurrentClipState</A> to get these states.</P>




> [!NOTE]
> <P>The player state does not change to <A href="smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md">Stopped</A> when the manifest/license manager URL is invalid. Instead, the clip remains in <A href="smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md">Opening</A> state.</P>



## See Also

#### Concepts

[Manifest Merge](manifest-merge.md)

#### Other Resources

[MediaElement States](http://go.microsoft.com/fwlink/?linkid=230681)

