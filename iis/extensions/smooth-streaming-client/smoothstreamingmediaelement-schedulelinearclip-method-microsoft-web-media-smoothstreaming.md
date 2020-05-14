---
title: SmoothStreamingMediaElement.ScheduleLinearClip Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ScheduleLinearClip Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleLinearClip(Microsoft.Web.Media.SmoothStreaming.ClipInformation,System.TimeSpan,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.schedulelinearclip(v=VS.95)
ms:contentKeyID: 46307451
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleLinearClip
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ScheduleLinearClip
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ScheduleLinearClip Method

Schedules play of a linear media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Function ScheduleLinearClip ( _
    clipInfo As ClipInformation, _
    manifestTimestamp As TimeSpan, _
    userData As Object _
) As ClipContext
'Usage

Dim instance As SmoothStreamingMediaElement
Dim clipInfo As ClipInformation
Dim manifestTimestamp As TimeSpan
Dim userData As Object
Dim returnValue As ClipContext

returnValue = instance.ScheduleLinearClip(clipInfo, _
    manifestTimestamp, userData)
```

```csharp
public ClipContext ScheduleLinearClip(
    ClipInformation clipInfo,
    TimeSpan manifestTimestamp,
    Object userData
)
```

```cpp
public:
ClipContext^ ScheduleLinearClip(
    ClipInformation^ clipInfo,
    TimeSpan manifestTimestamp,
    Object^ userData
)
```

``` fsharp
member ScheduleLinearClip :
        clipInfo:ClipInformation *
        manifestTimestamp:TimeSpan *
        userData:Object -> ClipContext
```

```jscript
public function ScheduleLinearClip(
    clipInfo : ClipInformation,
    manifestTimestamp : TimeSpan,
    userData : Object
) : ClipContext
```

### Parameters

  - clipInfo  
    Type: [Microsoft.Web.Media.SmoothStreaming.ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)  
    A [ClipInformation](clipinformation-class-microsoft-web-media-smoothstreaming_1.md) object that represents the smooth clip to be scheduled.

<!-- end list -->

  - manifestTimestamp  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
    The manifest time of the main content where the clip is inserted.

<!-- end list -->

  - userData  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    An object that can contain any data needed by the application, including the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object that will play the clip.

### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
A [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) object.The method inserts a clip that will play for its duration, after which the stream that was interrupted resumes.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
