---
title: SeekCompletedEventArgs.Success Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Success Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs.success(v=VS.95)
ms:contentKeyID: 46307789
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_Success
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SeekCompletedEventArgs.Success Property

Gets or sets the Success property to indicate that the seek operation is successful.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Success As Boolean
    Get
    Set
'Usage

Dim instance As SeekCompletedEventArgs
Dim value As Boolean

value = instance.Success

instance.Success = value
```

```csharp
public bool Success { get; set; }
```

```cpp
public:
property bool Success {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member Success : bool with get, set
```

```jscript
function get Success () : boolean
function set Success (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if the seek operation is successful, otherwise false.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SeekCompletedEventArgs Class](seekcompletedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
