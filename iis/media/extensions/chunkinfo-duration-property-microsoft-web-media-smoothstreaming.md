---
title: ChunkInfo.Duration Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Duration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkinfo.duration(v=VS.90)
ms:contentKeyID: 31469244
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_Duration
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_Duration
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_Duration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Duration Property

Time duration that corresponds the to the \<d\> element in the manifest for the chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyDurationAsTimeSpan
'Usage
DiminstanceAsChunkInfoDimvalueAsTimeSpanvalue = instance.Duration
```

``` csharp
publicTimeSpanDuration { get; privateset; }
```

``` c++
public:
propertyTimeSpanDuration {
    TimeSpanget ();
    private: voidset (TimeSpanvalue);
}
```

``` jscript
function getDuration () : TimeSpanprivatefunction setDuration (value : TimeSpan)
```

#### Property Value

Type: [System. . :: . .TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\))  
A [TimeSpan](https://msdn.microsoft.com/en-us/library/269ew577\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ChunkInfo Class](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

