---
title: TrackInfo.GetChunkUri Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: GetChunkUri Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri(System.TimeSpan)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.getchunkuri(v=VS.95)
ms:contentKeyID: 46307701
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# TrackInfo.GetChunkUri Method

Gets the Uri for the chunk identified by the timestamp parameter.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Function GetChunkUri ( _
    timestamp As TimeSpan _
) As Uri
'Usage

Dim instance As TrackInfo
Dim timestamp As TimeSpan
Dim returnValue As Uri

returnValue = instance.GetChunkUri(timestamp)
```

``` csharp
public Uri GetChunkUri(
    TimeSpan timestamp
)
```

``` c++
public:
Uri^ GetChunkUri(
    TimeSpan timestamp
)
```

``` fsharp
member GetChunkUri : 
        timestamp:TimeSpan -> Uri 
```

``` jscript
public function GetChunkUri(
    timestamp : TimeSpan
) : Uri
```

#### Parameters

  - timestamp  
    Type: [System.TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.95\))  
    A Sytem.TimeSpan object.

#### Return Value

Type: [System.Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.95\))  
A [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

