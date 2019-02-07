---
title: SmoothStreamingMediaElement.CurrentState Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentState Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentState
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentstate(v=VS.95)
ms:contentKeyID: 46307817
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CurrentState
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CurrentState
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.CurrentState Property

Gets or sets the current state of playback.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property CurrentState As SmoothStreamingMediaElementState
    Get
    Friend Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As SmoothStreamingMediaElementState

value = instance.CurrentState
```

``` csharp
public SmoothStreamingMediaElementState CurrentState { get; internal set; }
```

``` c++
public:
property SmoothStreamingMediaElementState CurrentState {
    SmoothStreamingMediaElementState get ();
    internal: void set (SmoothStreamingMediaElementState value);
}
```

``` fsharp
member CurrentState : SmoothStreamingMediaElementState with get, internal set
```

``` jscript
function get CurrentState () : SmoothStreamingMediaElementState
internal function set CurrentState (value : SmoothStreamingMediaElementState)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElementState](smoothstreamingmediaelementstate-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A state object.

## Remarks

State does not change to Stopped when the manifest/license manager URL is invalid; instead, it remains in Opening state.

A media clip can be scheduled for play when the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object is in a Closed state by using the [ScheduleClip()](smoothstreamingmediaelement-scheduleclip-method-microsoft-web-media-smoothstreaming_1.md) method with the [ManifestReady](smoothstreamingmediaelement-manifestready-event-microsoft-web-media-smoothstreaming_1.md) event.

For more information and for examples, see [Microsoft Smooth Streaming Client 2.0](microsoft-smooth-streaming-client-2-0.md).

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

