---
title: TrackChangedEventArgs.NewTrack Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NewTrack Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.NewTrack
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.newtrack(v=VS.90)
ms:contentKeyID: 31469213
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.NewTrack
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_NewTrack
dev_langs:
- CSharp
- JScript
- VB
- c++
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
ROBOTS: INDEX,FOLLOW
---

# NewTrack Property

Gets or sets a new [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property NewTrack As TrackInfo
'Usage

  Dim instance As TrackChangedEventArgs
Dim value As TrackInfo

value = instance.NewTrack
```

``` csharp
  public TrackInfo NewTrack { get; private set; }
```

``` c++
  public:
property TrackInfo^ NewTrack {
    TrackInfo^ get ();
    private: void set (TrackInfo^ value);
}
```

``` jscript
  function get NewTrack () : TrackInfo
private function set NewTrack (value : TrackInfo)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

