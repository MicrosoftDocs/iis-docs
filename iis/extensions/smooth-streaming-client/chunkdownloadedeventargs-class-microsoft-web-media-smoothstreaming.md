---
title: ChunkDownloadedEventArgs Class (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkDownloadedEventArgs Class
ms:assetid: T:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs(v=VS.95)
ms:contentKeyID: 46307932
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkDownloadedEventArgs Class

Provides arguments for the [ChunkDownloadFailed](smoothstreamingmediaelement-chunkdownloadfailed-event-microsoft-web-media-smoothstreaming.md) event for non-text chunks in main content.

## Inheritance Hierarchy

 [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
  [System.EventArgs](https://msdn.microsoft.com/library/118wxtk3\(v=vs.95\))  
    Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs  

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Class ChunkDownloadedEventArgs _
    Inherits EventArgs
'Usage

Dim instance As ChunkDownloadedEventArgs
```

```csharp
public class ChunkDownloadedEventArgs : EventArgs
```

```cpp
public ref class ChunkDownloadedEventArgs : public EventArgs
```

``` fsharp
type ChunkDownloadedEventArgs =  
    class
        inherit EventArgs
    end
```

```jscript
public class ChunkDownloadedEventArgs extends EventArgs
```

The ChunkDownloadedEventArgs type exposes the following members.

## Properties

||Name|Description|
|--- |--- |--- |
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[CanonicalUri](chunkdownloadedeventargs-canonicaluri-property-microsoft-web-media-smoothstreaming.md)|Gets the canonical URI for downloading the current chunk.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Chunk](chunkdownloadedeventargs-chunk-property-microsoft-web-media-smoothstreaming.md)|Gets the chunk being downloaded.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[DownloadResult](chunkdownloadedeventargs-downloadresult-property-microsoft-web-media-smoothstreaming.md)|Gets the download result.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[RequestType](chunkdownloadedeventargs-requesttype-property-microsoft-web-media-smoothstreaming.md)|Gets the request type being downloaded.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[StatusCode](chunkdownloadedeventargs-statuscode-property-microsoft-web-media-smoothstreaming.md)|Gets the HTTP status code.|
|![Public property](images/Ff728140.pubproperty(en-us,VS.90).gif "Public property")|[Track](chunkdownloadedeventargs-track-property-microsoft-web-media-smoothstreaming.md)|Gets the selected track for downloading the current chunk.|


## Methods

||Name|Description|
|--- |--- |--- |
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[Equals](https://msdn.microsoft.com/library/bsc2ak47(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[Finalize](https://msdn.microsoft.com/library/4k87zsw7(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetHashCode](https://msdn.microsoft.com/library/zdee4b3y(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[GetType](https://msdn.microsoft.com/library/dfwy45w9(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Protected method](images/Ff728153.protmethod(en-us,VS.90).gif "Protected method")|[MemberwiseClone](https://msdn.microsoft.com/library/57ctke0a(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|
|![Public method](images/Ff728153.pubmethod(en-us,VS.90).gif "Public method")|[ToString](https://msdn.microsoft.com/library/7bxwbwt2(v=vs.95))|(Inherited from [Object](https://msdn.microsoft.com/library/e5kfa45b(v=vs.95)).)|


## Remarks

The ChunkDownloadedEventArgs class does not apply to ads, either linear or non-linear.

## Version Information

### Silverlight

Supported in: 5  

## Thread Safety

Any public static (Shared in Visual Basic) members of this type are thread safe. Any instance members are not guaranteed to be thread safe.

## See Also

### Reference

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

