---
title: TrackChangedEventArgs.HighestPlayableTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: HighestPlayableTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.HighestPlayableTrack
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.highestplayabletrack(v=VS.95)
ms:contentKeyID: 46307878
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_HighestPlayableTrack
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_HighestPlayableTrack
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# TrackChangedEventArgs.HighestPlayableTrack Property

Gets or sets the highest available track for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property HighestPlayableTrack As TrackInfo
    Get
    Private Set
'Usage

Dim instance As TrackChangedEventArgs
Dim value As TrackInfo

value = instance.HighestPlayableTrack
```

```csharp
public TrackInfo HighestPlayableTrack { get; private set; }
```

```cpp
public:
property TrackInfo^ HighestPlayableTrack {
    TrackInfo^ get ();
    private: void set (TrackInfo^ value);
}
```

``` fsharp
member HighestPlayableTrack : TrackInfo with get, private set
```

```jscript
function get HighestPlayableTrack () : TrackInfo
private function set HighestPlayableTrack (value : TrackInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
