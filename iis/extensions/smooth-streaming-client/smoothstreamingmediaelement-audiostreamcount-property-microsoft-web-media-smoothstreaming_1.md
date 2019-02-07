---
title: SmoothStreamingMediaElement.AudioStreamCount Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AudioStreamCount Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.audiostreamcount(v=VS.95)
ms:contentKeyID: 46307799
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamCount
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_AudioStreamCount
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_AudioStreamCount
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.AudioStreamCount Property

Gets or sets the audio stream count. (This property is available only for Windows Media Video (.wmv) content.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property AudioStreamCount As Integer
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Integer

value = instance.AudioStreamCount

instance.AudioStreamCount = value
```

``` csharp
public int AudioStreamCount { get; set; }
```

``` c++
public:
property int AudioStreamCount {
    int get ();
    void set (int value);
}
```

``` fsharp
member AudioStreamCount : int with get, set
```

``` jscript
function get AudioStreamCount () : int
function set AudioStreamCount (value : int)
```

#### Property Value

Type: [System.Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.95\))  
The audio stream count.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

