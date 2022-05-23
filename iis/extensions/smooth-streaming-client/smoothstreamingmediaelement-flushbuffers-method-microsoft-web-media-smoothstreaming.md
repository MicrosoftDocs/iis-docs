---
title: SmoothStreamingMediaElement.FlushBuffers Method  (Microsoft.Web.Media.SmoothStreaming)
description: This page details the syntax for the FlushBuffers method which flushes audio and video buffers, retaining a specified amount of content if possible.
TOCTitle: FlushBuffers Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.FlushBuffers(System.TimeSpan,System.Boolean,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.flushbuffers(v=VS.90)
ms:contentKeyID: 28440978
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.FlushBuffers
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.FlushBuffers
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# FlushBuffers Method

Flushes audio and video buffers, retaining a specified amount of content if possible.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub FlushBuffers ( _
    bufferToKeep As TimeSpan, _
    flushAudio As Boolean, _
    flushVideo As Boolean _
)
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim bufferToKeep As TimeSpan
Dim flushAudio As Boolean
Dim flushVideo As Boolean

instance.FlushBuffers(bufferToKeep, flushAudio, _
    flushVideo)
```

```csharp
  public void FlushBuffers(
    TimeSpan bufferToKeep,
    bool flushAudio,
    bool flushVideo
)
```

```cpp
  public:
void FlushBuffers(
    TimeSpan bufferToKeep, 
    bool flushAudio, 
    bool flushVideo
)
```

```jscript
  public function FlushBuffers(
    bufferToKeep : TimeSpan, 
    flushAudio : boolean, 
    flushVideo : boolean
)
```

### Parameters

  - bufferToKeep  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
    An object that specifies how much of a buffer to retain.  

<!-- end list -->

  - flushAudio  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to flush the audio buffer; otherwise, false.  

<!-- end list -->

  - flushVideo  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
    true to flush the video buffer; otherwise, false.  

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
