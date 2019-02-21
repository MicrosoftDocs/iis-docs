---
title: ChunkInfo.TimeStamp Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: TimeStamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkinfo.timestamp(v=VS.90)
ms:contentKeyID: 31469322
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.get_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.set_TimeStamp
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.TimeStamp
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TimeStamp Property

Gets or sets the start time for the data chunk.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property TimeStamp As TimeSpan
'Usage

  Dim instance As ChunkInfo
Dim value As TimeSpan

value = instance.TimeStamp
```

```csharp
  public TimeSpan TimeStamp { get; internal set; }
```

```cpp
  public:
property TimeSpan TimeStamp {
    TimeSpan get ();
    internal: void set (TimeSpan value);
}
```

```jscript
  function get TimeStamp () : TimeSpan
internal function set TimeStamp (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ChunkInfo Class](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

