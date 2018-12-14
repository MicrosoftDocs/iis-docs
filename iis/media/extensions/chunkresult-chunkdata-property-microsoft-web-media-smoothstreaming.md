---
title: ChunkResult.ChunkData Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ChunkData Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.chunkdata(v=VS.90)
ms:contentKeyID: 31469231
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_ChunkData
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_ChunkData
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_ChunkData
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkData Property

Gets or sets the data contained by [ChunkResult](chunkresult-class-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicPropertyChunkDataAsStream
'Usage
DiminstanceAsChunkResultDimvalueAsStreamvalue = instance.ChunkData
```

``` csharp
publicStreamChunkData { get; privateset; }
```

``` c++
public:
propertyStream^ ChunkData {
    Stream^ get ();
    private: voidset (Stream^ value);
}
```

``` jscript
function getChunkData () : Streamprivatefunction setChunkData (value : Stream)
```

#### Property Value

Type: [System.IO. . :: . .Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.90\))  
A [Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

