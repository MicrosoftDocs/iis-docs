---
title: SmoothStreamingMediaElement.ScheduleClip Method (ClipInformation, Boolean, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ScheduleClip Method (ClipInformation, Boolean, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleClip(Microsoft.Web.Media.SmoothStreaming.ClipInformation,System.Boolean,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.scheduleclip(v=VS.90)
ms:contentKeyID: 23960957
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
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

# ScheduleClip Method (ClipInformation, Boolean, Object)

Schedules playing of a media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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
    A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object.  

<!-- end list -->

  - pauseTimeline  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to pause the timeline when starting a clip; false to specify that the timeline continues while the clip plays. During on-demand video playback, it is typical to pause; live video sources typically continue the video without pausing.  

<!-- end list -->

  - userData  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    An object that can contain any data required by the application, usually including the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object that will play the clip.  

### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Remarks

The object passed in the userData parameter is saved as the [Data](clipcontext-data-property-microsoft-web-media-smoothstreaming_1.md) member of the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) used by the ScheduleClip(ClipInformation, Boolean, Object) method. The application can pass anything it requires in this parameter. The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is usually included in userData. Later the data can be cast to type [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) (for example, (SmoothStreamingMediaElement)clipContext.Data) in order to retrieve the Smooth Player that generated the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) instance. If the application requires more information, it can create a class to contain all the information and then pass that type using the userData parameter.

For more information, see [IIS Smooth Streaming Client 1.5](microsoft-smooth-streaming-client-2-0.md) and [Scheduling Media Clips (IIS Smooth Streaming)](scheduling-media-clips.md).

> [!NOTE]  
> IIS Smooth Streaming clips scheduled by using ScheduleClip methods require manifests that start at timestamp zero.

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[ScheduleClip Overload](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
