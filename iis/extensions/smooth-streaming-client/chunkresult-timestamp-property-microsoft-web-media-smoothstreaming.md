---
title: ChunkResult.Timestamp Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Timestamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.Timestamp
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.timestamp(v=VS.90)
ms:contentKeyID: 31469147
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Timestamp
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Timestamp
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Timestamp
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Timestamp
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# Timestamp Property

Gets or sets the time stamp of the chunk in ticks.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Timestamp As TimeSpan
'Usage

  Dim instance As ChunkResult
Dim value As TimeSpan

value = instance.Timestamp
```

```csharp
  public TimeSpan Timestamp { get; private set; }
```

```cpp
  public:
property TimeSpan Timestamp {
    TimeSpan get ();
    private: void set (TimeSpan value);
}
```

```jscript
  function get Timestamp () : TimeSpan
private function set Timestamp (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577) object.  

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

