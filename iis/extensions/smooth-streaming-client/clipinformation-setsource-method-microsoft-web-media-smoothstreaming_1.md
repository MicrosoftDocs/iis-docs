---
title: ClipInformation.SetSource Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetSource Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ClipInformation.SetSource(Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement,System.Windows.Controls.MediaElement,System.String,System.Int64)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipinformation.setsource(v=VS.95)
ms:contentKeyID: 46307468
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.SetSource
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.SetSource
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ClipInformation.SetSource Method

Sets the source for the clip. Enables setting the clip information on the clip MediaElement for extensibility purposes.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Protected Friend Overridable Sub SetSource ( _
    ssme As SmoothStreamingMediaElement, _
    mediaElement As MediaElement, _
    markerStringId As String, _
    clipLength As Long _
)
'Usage

Dim ssme As SmoothStreamingMediaElement
Dim mediaElement As MediaElement
Dim markerStringId As String
Dim clipLength As Long

Me.SetSource(ssme, mediaElement, markerStringId, _
    clipLength)
```

```csharp
protected internal virtual void SetSource(
    SmoothStreamingMediaElement ssme,
    MediaElement mediaElement,
    string markerStringId,
    long clipLength
)
```

```cpp
protected public:
virtual void SetSource(
    SmoothStreamingMediaElement^ ssme,
    MediaElement^ mediaElement,
    String^ markerStringId,
    long long clipLength
)
```

``` fsharp
abstract SetSource :
        ssme:SmoothStreamingMediaElement *
        mediaElement:MediaElement *
        markerStringId:string *
        clipLength:int64 -> unit
override SetSource :
        ssme:SmoothStreamingMediaElement *
        mediaElement:MediaElement *
        markerStringId:string *
        clipLength:int64 -> unit
```

```jscript
 function SetSource(
    ssme : SmoothStreamingMediaElement,
    mediaElement : MediaElement,
    markerStringId : String,
    clipLength : long
)
```

### Parameters

  - ssme  
    Type: [Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)  
    The [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) that will play the clip.

<!-- end list -->

  - mediaElement  
    Type: [System.Windows.Controls.MediaElement](https://msdn.microsoft.com/library/ms611595\(v=vs.95\))  
    The clip media element.

<!-- end list -->

  - markerStringId  
    Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
    Marker string identifier of the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md).

<!-- end list -->

  - clipLength  
    Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
    A long integer that specifies the clip length.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
