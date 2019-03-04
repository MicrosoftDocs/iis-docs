---
title: SmoothStreamingMediaElement.IsDecodingOnGPU Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: IsDecodingOnGPU Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsDecodingOnGPU
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.isdecodingongpu(v=VS.95)
ms:contentKeyID: 46307825
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsDecodingOnGPU
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsDecodingOnGPU
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_IsDecodingOnGPU
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.IsDecodingOnGPU
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.IsDecodingOnGPU Property

Gets a value that indicates whether Global Processing Unit (GPU) decoding is enabled.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property IsDecodingOnGPU As Boolean
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.IsDecodingOnGPU
```

```csharp
public bool IsDecodingOnGPU { get; }
```

```cpp
public:
property bool IsDecodingOnGPU {
    bool get ();
}
```

``` fsharp
member IsDecodingOnGPU : bool
```

```jscript
function get IsDecodingOnGPU () : boolean
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if GPU decoding is enabled; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

