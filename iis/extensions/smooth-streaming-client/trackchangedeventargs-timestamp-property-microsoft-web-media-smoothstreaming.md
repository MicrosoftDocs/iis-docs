---
title: TrackChangedEventArgs.Timestamp Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Timestamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackchangedeventargs.timestamp(v=VS.90)
ms:contentKeyID: 23961026
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_Timestamp
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.set_Timestamp
- Microsoft.Web.Media.SmoothStreaming.TrackChangedEventArgs.Timestamp
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Timestamp Property

Gets or sets the Timestamp property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Timestamp As TimeSpan
'Usage

  Dim instance As TrackChangedEventArgs
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
A [DateTime](https://msdn.microsoft.com/library/03ybds8y) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackChangedEventArgs Class](trackchangedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
