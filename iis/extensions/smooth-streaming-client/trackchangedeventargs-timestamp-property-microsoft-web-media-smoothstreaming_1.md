---
title: TrackChangedEventArgs.Timestamp Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Timestamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.timestamp(v=VS.95)
ms:contentKeyID: 46307893
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_Timestamp
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TrackChangedEventArgs.Timestamp Property

Gets or sets the Timestamp property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Timestamp As TimeSpan
    Get
    Private Set
'Usage

Dim instance As TrackChangedEventArgs
Dim value As TimeSpan

value = instance.Timestamp
```

``` csharp
public TimeSpan Timestamp { get; private set; }
```

``` c++
public:
property TimeSpan Timestamp {
    TimeSpan get ();
    private: void set (TimeSpan value);
}
```

``` fsharp
member Timestamp : TimeSpan with get, private set
```

``` jscript
function get Timestamp () : TimeSpan
private function set Timestamp (value : TimeSpan)
```

#### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\))  
A [DateTime](https://msdn.microsoft.com/en-us/library/03ybds8y\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

