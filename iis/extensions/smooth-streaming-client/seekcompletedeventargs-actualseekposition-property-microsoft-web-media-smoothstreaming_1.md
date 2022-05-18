---
title: SeekCompletedEventArgs.ActualSeekPosition Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the SeekCompletedEventArgs.ActualSeekPosition property and details its syntax, property value, and Silverlight information.
TOCTitle: ActualSeekPosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs.actualseekposition(v=VS.95)
ms:contentKeyID: 46307781
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_ActualSeekPosition
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_ActualSeekPosition
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# SeekCompletedEventArgs.ActualSeekPosition Property

Gets or sets the ActualSeekPosition property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ActualSeekPosition As TimeSpan
    Get
    Set
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

``` fsharp
member ActualSeekPosition : TimeSpan with get, set
```

```jscript
function get ActualSeekPosition () : TimeSpan
function set ActualSeekPosition (value : TimeSpan)
```

### Property Value

Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
A [TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\)) structure object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SeekCompletedEventArgs Class](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
