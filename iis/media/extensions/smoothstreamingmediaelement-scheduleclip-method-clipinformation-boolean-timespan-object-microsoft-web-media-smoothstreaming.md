---
title: SmoothStreamingMediaElement.ScheduleClip Method (ClipInformation, Boolean, TimeSpan, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ScheduleClip Method (ClipInformation, Boolean, TimeSpan, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip(Microsoft.Web.Media.SmoothStreaming.ClipInformation,System.Boolean,System.TimeSpan,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.scheduleclip(v=VS.90)
ms:contentKeyID: 31469277
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- c++
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ScheduleClip Method (ClipInformation, Boolean, TimeSpan, Object)

Schedules playing of a media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicFunctionScheduleClip ( _
    clipInfoAsClipInformation, _
    pauseTimelineAsBoolean, _
    startOffsetAsTimeSpan, _
    userDataAsObject _
) AsClipContext
'Usage
DiminstanceAsSmoothStreamingMediaElementDimclipInfoAsClipInformationDimpauseTimelineAsBooleanDimstartOffsetAsTimeSpanDimuserDataAsObjectDimreturnValueAsClipContextreturnValue = instance.ScheduleClip(clipInfo, _
    pauseTimeline, startOffset, userData)
```

``` csharp
publicClipContextScheduleClip(
    ClipInformationclipInfo,
    boolpauseTimeline,
    TimeSpanstartOffset,
    ObjectuserData
)
```

``` c++
public:
ClipContext^ ScheduleClip(
    ClipInformation^ clipInfo, 
    boolpauseTimeline, 
    TimeSpanstartOffset, 
    Object^ userData
)
```

``` jscript
publicfunctionScheduleClip(
    clipInfo : ClipInformation, 
    pauseTimeline : boolean, 
    startOffset : TimeSpan, 
    userData : Object
) : ClipContext
```

#### Parameters

  - clipInfo  
    Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)  
    A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object.  

<!-- end list -->

  - pauseTimeline  
    Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
    true to pause the timeline when starting a clip; false to specify that the timeline continues while the clip plays. During on-demand video playback, it is typical to pause; live video sources typically continue the video without pausing.  

<!-- end list -->

  - startOffset  
    Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
    The start time of the clip.  

<!-- end list -->

  - userData  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    An object that can contain any data needed by the application, including the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object that will play the clip.  

#### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

The method inserts a clip that will play for its duration, after which the stream that was interrupted resumes.

A media clip can be scheduled for play when the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is in a Closed state by using the ScheduleClip method with the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.

For more information, see [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).


> [!NOTE]
> <P>IIS Smooth Streaming Clips scheduled by using ScheduleClip methods require manifests that start at timestamp zero.</P>



## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[ScheduleClip Overload](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

