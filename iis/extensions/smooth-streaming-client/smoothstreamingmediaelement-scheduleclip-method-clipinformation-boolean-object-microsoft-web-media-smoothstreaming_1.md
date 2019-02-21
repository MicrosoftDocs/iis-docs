---
title: SmoothStreamingMediaElement.ScheduleClip Method (ClipInformation, Boolean, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ScheduleClip Method (ClipInformation, Boolean, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip(Microsoft.Web.Media.SmoothStreaming.ClipInformation,System.Boolean,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.scheduleclip(v=VS.95)
ms:contentKeyID: 46307691
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ScheduleClip Method (ClipInformation, Boolean, Object)

Schedules playing of a media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Function ScheduleClip ( _
    clipInfo As ClipInformation, _
    pauseTimeline As Boolean, _
    userData As Object _
) As ClipContext
'Usage

Dim instance As SmoothStreamingMediaElement
Dim clipInfo As ClipInformation
Dim pauseTimeline As Boolean
Dim userData As Object
Dim returnValue As ClipContext

returnValue = instance.ScheduleClip(clipInfo, _
    pauseTimeline, userData)
```

```csharp
public ClipContext ScheduleClip(
    ClipInformation clipInfo,
    bool pauseTimeline,
    Object userData
)
```

```cpp
public:
ClipContext^ ScheduleClip(
    ClipInformation^ clipInfo, 
    bool pauseTimeline, 
    Object^ userData
)
```

``` fsharp
member ScheduleClip : 
        clipInfo:ClipInformation * 
        pauseTimeline:bool * 
        userData:Object -> ClipContext 
```

```jscript
public function ScheduleClip(
    clipInfo : ClipInformation, 
    pauseTimeline : boolean, 
    userData : Object
) : ClipContext
```

### Parameters

  - clipInfo  
    Type: [Microsoft.Web.Media.SmoothStreaming.ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)  
    A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object that represents the smooth clip to be scheduled..

<!-- end list -->

  - pauseTimeline  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    true to pause the timeline when starting a clip; false to specify that the timeline continues while the clip plays. During on-demand video playback, it is typical to pause; live video sources typically continue the video without pausing.

<!-- end list -->

  - userData  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    An object that can contain any data required by the application, usually including the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object that will play the clip.

### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.

## Remarks

The object passed in the userData parameter is saved as the [Data](clipcontext-data-property-microsoft-web-media-smoothstreaming_1.md) member of the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) used by the ScheduleClip(ClipInformation, Boolean, Object) method. The application can pass anything it requires in this parameter. The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is usually included in userData. Later the data can be cast to type [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) (for example, (SmoothStreamingMediaElement)clipContext.Data) in order to retrieve the Smooth Player that generated the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) instance. If the application requires more information, it can create a class to contain all the information and then pass that type using the userData parameter.

A media clip can be scheduled for play when the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is in a Closed state by using the ScheduleClip method with the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.

For more information, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md) and [Scheduling Media Clips](scheduling-media-clips.md).


> [!NOTE]  
> Smooth Streaming clips scheduled by using ScheduleClip methods require manifests that start at timestamp zero and must be scheduled after the manifest is loaded. If you try to schedule a clip when the Smooth Streaming player is in an opening state, an invalidOperationException error occurs. The ScheduleClip should be called only after the ManifestReady event has occurred.


## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[ScheduleClip Overload](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

