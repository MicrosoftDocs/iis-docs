---
title: SmoothStreamingMediaElement.SetSource Method | Microsoft.Web.Media.SmoothStreaming
description: "This article shows how to set the source method for the SmoothStreamingMediaElement object, providing syntax, parameters, notes, version information, permissions, and reference links."
TOCTitle: SetSource Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetSource(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.setsource(v=VS.90)
ms:contentKeyID: 23961177
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetSource
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.SetSource
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SetSource Method

Sets the source of the [SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub SetSource ( _
    stream As Stream _
)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim stream As Stream

instance.SetSource(stream)
```

```csharp
  public void SetSource(
    Stream stream
)
```

```cpp
  public:
void SetSource(
    Stream^ stream
)
```

```jscript
  public function SetSource(
    stream : Stream
)
```

### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e)  
    The source object.  

## Remarks

When you call SetSource(Stream) or assign the [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) or [Source](smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md) properties, [Source](smoothstreamingmediaelement-source-property-microsoft-web-media-smoothstreaming_1.md) is reset to [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md). However, [SmoothStreamingSource](smoothstreamingmediaelement-smoothstreamingsource-property-microsoft-web-media-smoothstreaming_1.md) is not cleared when reset to a progressive-downloading source.

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
