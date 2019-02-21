---
title: TrackChangedEventArgs.NewTrack Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NewTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.NewTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.newtrack(v=VS.95)
ms:contentKeyID: 46307892
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_NewTrack
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.NewTrack
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TrackChangedEventArgs.NewTrack Property

Gets or sets a new [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property NewTrack As TrackInfo
    Get
    Private Set
'Usage

Dim instance As TrackChangedEventArgs
Dim value As TrackInfo

value = instance.NewTrack
```

```csharp
public TrackInfo NewTrack { get; private set; }
```

```cpp
public:
property TrackInfo^ NewTrack {
    TrackInfo^ get ();
    private: void set (TrackInfo^ value);
}
```

``` fsharp
member NewTrack : TrackInfo with get, private set
```

```jscript
function get NewTrack () : TrackInfo
private function set NewTrack (value : TrackInfo)
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

