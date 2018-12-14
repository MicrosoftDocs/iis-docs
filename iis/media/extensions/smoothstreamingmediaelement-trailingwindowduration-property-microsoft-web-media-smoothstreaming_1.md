---
title: SmoothStreamingMediaElement.TrailingWindowDuration Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: TrailingWindowDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.trailingwindowduration(v=VS.95)
ms:contentKeyID: 46307852
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_TrailingWindowDuration
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_TrailingWindowDuration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.TrailingWindowDuration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.TrailingWindowDuration Property

Gets or sets the trailing window duration.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property TrailingWindowDuration As Duration
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Duration

value = instance.TrailingWindowDuration

instance.TrailingWindowDuration = value
```

``` csharp
public Duration TrailingWindowDuration { get; set; }
```

``` c++
public:
property Duration TrailingWindowDuration {
    Duration get ();
    void set (Duration value);
}
```

``` fsharp
member TrailingWindowDuration : Duration with get, set
```

``` jscript
function get TrailingWindowDuration () : Duration
function set TrailingWindowDuration (value : Duration)
```

#### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.95\))  
A duration object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

