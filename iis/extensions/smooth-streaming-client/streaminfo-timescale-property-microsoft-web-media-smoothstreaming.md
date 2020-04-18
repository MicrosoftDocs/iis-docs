---
title: StreamInfo.Timescale Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Timescale Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamInfo.TimeScale
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streaminfo.timescale(v=VS.95)
ms:contentKeyID: 46307871
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_Timescale
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_Timescale
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.Timescale
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.get_TimeScale
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.set_TimeScale
- Microsoft.Web.Media.SmoothStreaming.StreamInfo.TimeScale
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamInfo.Timescale Property

Gets or sets the time scale of the stream.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Timescale As Long
    Get
    Set
'Usage

Dim instance As StreamInfo
Dim value As Long

value = instance.Timescale

instance.Timescale = value
```

```csharp
public long Timescale { get; set; }
```

```cpp
public:
property long long Timescale {
    long long get ();
    void set (long long value);
}
```

``` fsharp
member Timescale : int64 with get, set
```

```jscript
function get Timescale () : long
function set Timescale (value : long)
```

### Property Value

Type: [System.Int64](https://msdn.microsoft.com/library/6yy583ek\(v=vs.95\))  
A long integer that specifies the time scale.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[StreamInfo Class](streaminfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
