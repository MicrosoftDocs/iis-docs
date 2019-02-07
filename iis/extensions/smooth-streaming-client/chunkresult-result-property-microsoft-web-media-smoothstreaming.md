---
title: ChunkResult.Result Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Result Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.result(v=VS.90)
ms:contentKeyID: 31469249
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Result
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Result
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Result
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Result Property

Gets or sets the result of call to [BeginGetChunk](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) or [GetChunkUri](trackinfo-getchunkuri-method-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property Result As ChunkResult..::..ChunkResultState
'Usage

  Dim instance As ChunkResult
Dim value As ChunkResult..::..ChunkResultState

value = instance.Result
```

``` csharp
  public ChunkResult..::..ChunkResultState Result { get; private set; }
```

``` c++
  public:
property ChunkResult..::..ChunkResultState Result {
    ChunkResult..::..ChunkResultState get ();
    private: void set (ChunkResult..::..ChunkResultState value);
}
```

``` jscript
  function get Result () : ChunkResult..::..ChunkResultState
private function set Result (value : ChunkResult..::..ChunkResultState)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming. . :: . .ChunkResult. . :: . .ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md)  
A [ChunkResult..::..ChunkResultState](chunkresult-chunkresultstate-enumeration-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

