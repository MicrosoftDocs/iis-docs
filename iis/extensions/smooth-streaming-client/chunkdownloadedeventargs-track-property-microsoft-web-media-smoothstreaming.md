---
title: ChunkDownloadedEventArgs.Track Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Track Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Track
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.track(v=VS.95)
ms:contentKeyID: 46307758
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_Track
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Track
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_Track
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_Track
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_Track
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.Track
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkDownloadedEventArgs.Track Property

Gets the selected track for downloading the current chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Track As TrackInfo
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
Dim value As TrackInfo

value = instance.Track
```

``` csharp
public TrackInfo Track { get; private set; }
```

``` c++
public:
property TrackInfo^ Track {
    TrackInfo^ get ();
    private: void set (TrackInfo^ value);
}
```

``` fsharp
member Track : TrackInfo with get, private set
```

``` jscript
function get Track () : TrackInfo
private function set Track (value : TrackInfo)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.TrackInfo](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A TrackInfo object that represents the track.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

