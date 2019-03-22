---
title: TrackInfo.Index Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Index Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.index(v=VS.90)
ms:contentKeyID: 23961028
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Index
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.get_Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.Index
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.set_Index
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Index Property

Gets or sets the Index property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Index As UInteger
'Usage

  Dim instance As TrackInfo
Dim value As UInteger

value = instance.Index

instance.Index = value
```

```csharp
  public uint Index { get; protected set; }
```

```cpp
  public:
property unsigned int Index {
    unsigned int get ();
    protected: void set (unsigned int value);
}
```

```jscript
  function get Index () : uint
protected function set Index (value : uint)
```

### Property Value

Type: [System.UInt32](https://msdn.microsoft.com/library/ctys3981)  
An unsigned integer value that specifies the track index.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

