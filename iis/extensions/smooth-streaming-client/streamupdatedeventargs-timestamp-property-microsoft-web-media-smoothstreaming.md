---
title: StreamUpdatedEventArgs.Timestamp Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Timestamp Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Timestamp
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedeventargs.timestamp(v=VS.90)
ms:contentKeyID: 31469237
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Timestamp
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Timestamp
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.get_Timestamp
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.set_Timestamp
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs.Timestamp
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Timestamp Property

Optional timestamp for the StreamSelected()()()(), ChunkAdded()()()() and TracksSelected()()()() actions.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Timestamp As Nullable(Of TimeSpan)
'Usage

  Dim instance As StreamUpdatedEventArgs
Dim value As Nullable(Of TimeSpan)

value = instance.Timestamp
```

```csharp
  public Nullable<TimeSpan> Timestamp { get; private set; }
```

```cpp
  public:
property Nullable<TimeSpan> Timestamp {
    Nullable<TimeSpan> get ();
    private: void set (Nullable<TimeSpan> value);
}
```

```jscript
  function get Timestamp () : Nullable<TimeSpan>
private function set Timestamp (value : Nullable<TimeSpan>)
```

### Property Value

Type: [System.Nullable](https://msdn.microsoft.com/library/b3h38hb0)\< (Of \< ( \<'[TimeSpan](https://msdn.microsoft.com/library/269ew577)\> ) \> ) \>  
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

[StreamUpdatedEventArgs Class](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

