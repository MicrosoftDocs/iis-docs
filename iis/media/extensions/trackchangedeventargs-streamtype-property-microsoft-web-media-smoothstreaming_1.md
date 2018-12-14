---
title: TrackChangedEventArgs.StreamType Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamType Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.StreamType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.streamtype(v=VS.95)
ms:contentKeyID: 46307879
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.StreamType
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_StreamType
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_StreamType
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_StreamType
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_StreamType
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.StreamType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TrackChangedEventArgs.StreamType Property

Gets or sets the StreamType property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property StreamType As MediaStreamType
    Get
    Private Set
'Usage

Dim instance As TrackChangedEventArgs
Dim value As MediaStreamType

value = instance.StreamType
```

``` csharp
public MediaStreamType StreamType { get; private set; }
```

``` c++
public:
property MediaStreamType StreamType {
    MediaStreamType get ();
    private: void set (MediaStreamType value);
}
```

``` fsharp
member StreamType : MediaStreamType with get, private set
```

``` jscript
function get StreamType () : MediaStreamType
private function set StreamType (value : MediaStreamType)
```

#### Property Value

Type: [System.Windows.Media.MediaStreamType](https://msdn.microsoft.com/en-us/library/cc672180\(v=vs.95\))  
A System.Windows.MediaStream object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

