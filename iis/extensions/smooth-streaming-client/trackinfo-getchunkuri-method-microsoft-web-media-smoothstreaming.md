---
title: TrackInfo.GetChunkUri Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: GetChunkUri Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri(System.TimeSpan)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.getchunkuri(v=VS.90)
ms:contentKeyID: 31469203
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.GetChunkUri
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# GetChunkUri Method

Gets the Uri for the chunk identified by the timestamp parameter.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
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

```csharp
  public Uri GetChunkUri(
    TimeSpan timestamp
)
```

```cpp
  public:
Uri^ GetChunkUri(
    TimeSpan timestamp
)
```

```jscript
  public function GetChunkUri(
    timestamp : TimeSpan
) : Uri
```

### Parameters

  - timestamp  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
    A TimeSpan object.  

### Return Value

Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a)  
A [Uri](https://msdn.microsoft.com/library/txt7706a) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

