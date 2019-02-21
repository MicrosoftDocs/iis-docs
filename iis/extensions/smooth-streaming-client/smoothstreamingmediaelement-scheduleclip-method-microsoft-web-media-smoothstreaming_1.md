---
title: SmoothStreamingMediaElement.ScheduleClip Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ScheduleClip Method
ms:assetid: Overload:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.scheduleclip(v=VS.95)
ms:contentKeyID: 46307720
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
---

# SmoothStreamingMediaElement.ScheduleClip Method

Schedules playing of a media clip.

This member is overloaded. For complete information about this member, including syntax, usage, and examples, click a name in the overload list.

## Overload List

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md)|Schedules playing of a media clip.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ScheduleClip(ClipInformation, Boolean, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-boolean-object-microsoft-web-media-smoothstreaming_1.md)|Schedules playing of a media clip.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ScheduleClip(ClipInformation, Boolean, TimeSpan, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-boolean-timespan-object-microsoft-web-media-smoothstreaming_1.md)|Schedules playing of a media clip.|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ScheduleClip(ClipInformation, TimeSpan, Boolean, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-timespan-boolean-object-microsoft-web-media-smoothstreaming_1.md)|Schedules playing of a media clip.|


## Remarks

The method inserts a clip that will play for its duration, after which the stream that was interrupted resumes.

There are several ways to schedule clips to play before and during a media presentation. You can schedule a clip from an event handler such as the [MarkerReached](smoothstreamingmediaelement-markerreached-event-microsoft-web-media-smoothstreaming_1.md) event. Another scenario, known as pre-roll, can be initialized from the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event. Clips can also be chained together by using the overload of the [ScheduleClip(ClipInformation, ClipContext, Object)](smoothstreamingmediaelement-scheduleclip-method-clipinformation-clipcontext-object-microsoft-web-media-smoothstreaming_1.md) method that has the clipToAppendTo parameter. In this scenario, the clipToAppendTo parameter is set to the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) value of another clip.

A media clip can be scheduled for play when the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is in a Closed state by using the ScheduleClip method with the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.

For more information and for examples, see [Scheduling Media Clips](scheduling-media-clips.md) and [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).


> [!NOTE]  
> Smooth Streaming clips that are scheduled by using ScheduleClip methods require manifests that start at timestamp zero and must be scheduled after the manifest is loaded. If you try to schedule a clip when the Smooth Streaming player is in an opening state, an invalidOperationException error occurs. The ScheduleClip should be called only after the ManifestReady event has occurred.


## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

