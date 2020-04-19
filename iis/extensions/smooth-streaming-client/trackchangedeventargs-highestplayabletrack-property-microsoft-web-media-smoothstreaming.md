---
title: TrackChangedEventArgs.HighestPlayableTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: HighestPlayableTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.HighestPlayableTrack
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.highestplayabletrack(v=VS.90)
ms:contentKeyID: 31469312
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.HighestPlayableTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_HighestPlayableTrack
dev_langs:
- csharp
- jscript
- vb
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

# HighestPlayableTrack Property

Gets or sets the highest available track for this stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property HighestPlayableTrack As TrackInfo
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

```jscript
  function get HighestPlayableTrack () : TrackInfo
private function set HighestPlayableTrack (value : TrackInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
