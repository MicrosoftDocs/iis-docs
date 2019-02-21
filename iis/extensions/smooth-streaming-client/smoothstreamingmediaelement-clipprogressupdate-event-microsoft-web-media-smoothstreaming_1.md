---
title: SmoothStreamingMediaElement.ClipProgressUpdate Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipProgressUpdate Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipProgressUpdate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.clipprogressupdate(v=VS.95)
ms:contentKeyID: 46307490
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipProgressUpdate
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ClipProgressUpdate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ClipProgressUpdate
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ClipProgressUpdate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.ClipProgressUpdate Event

Occurs when media reaches a marker.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ClipProgressUpdate As EventHandler(Of ClipPlaybackEventArgs)
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As EventHandler(Of ClipPlaybackEventArgs)

AddHandler instance.ClipProgressUpdate, handler
```

```csharp
public event EventHandler<ClipPlaybackEventArgs> ClipProgressUpdate
```

```cpp
public:
 event EventHandler<ClipPlaybackEventArgs^>^ ClipProgressUpdate {
    void add (EventHandler<ClipPlaybackEventArgs^>^ value);
    void remove (EventHandler<ClipPlaybackEventArgs^>^ value);
}
```

``` fsharp
member ClipProgressUpdate : <EventHandler<ClipPlaybackEventArgs>,
    ClipPlaybackEventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

The ClipProgressUpdate event does not occur for linear ads.

For more information, see [Events](events.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

