---
title: TrackInfo.Bitrate Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Bitrate Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.bitrate(v=VS.95)
ms:contentKeyID: 46307894
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Bitrate
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Bitrate
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Bitrate
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TrackInfo.Bitrate Property

Gets or sets the Bitrate property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Bitrate As ULong
    Get
    Protected Set
'Usage

Dim instance As TrackInfo
Dim value As ULong

value = instance.Bitrate

instance.Bitrate = value
```

```csharp
public ulong Bitrate { get; protected set; }
```

```cpp
public:
property unsigned long long Bitrate {
    unsigned long long get ();
    protected: void set (unsigned long long value);
}
```

``` fsharp
member Bitrate : uint64 with get, set
```

```jscript
function get Bitrate () : ulong
protected function set Bitrate (value : ulong)
```

### Property Value

Type: [System.UInt64](https://msdn.microsoft.com/library/06cf7918\(v=vs.95\))  
An unsigned long integer.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

