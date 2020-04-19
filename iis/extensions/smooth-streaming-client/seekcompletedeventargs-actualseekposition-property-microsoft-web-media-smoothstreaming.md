---
title: SeekCompletedEventArgs.ActualSeekPosition Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ActualSeekPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs.actualseekposition(v=VS.90)
ms:contentKeyID: 23961084
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_ActualSeekPosition
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_ActualSeekPosition
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ActualSeekPosition Property

Gets or sets the ActualSeekPosition property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ActualSeekPosition As TimeSpan
'Usage

  Dim instance As SeekCompletedEventArgs
Dim value As TimeSpan

value = instance.ActualSeekPosition

instance.ActualSeekPosition = value
```

```csharp
  public TimeSpan ActualSeekPosition { get; set; }
```

```cpp
  public:
property TimeSpan ActualSeekPosition {
    TimeSpan get ();
    void set (TimeSpan value);
}
```

```jscript
  function get ActualSeekPosition () : TimeSpan
function set ActualSeekPosition (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577)  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577) structure object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SeekCompletedEventArgs Class](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
