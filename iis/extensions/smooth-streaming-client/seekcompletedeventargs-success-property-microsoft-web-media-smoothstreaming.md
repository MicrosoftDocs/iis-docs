---
title: SeekCompletedEventArgs.Success Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Success Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.seekcompletedeventargs.success(v=VS.90)
ms:contentKeyID: 23961130
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_Success
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.get_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.set_Success
- Microsoft.Web.Media.SmoothStreaming.SeekCompletedEventArgs.Success
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Success Property

Gets or sets the Success property to indicate that the seek operation is successful.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Success As Boolean
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

```jscript
  function get Success () : boolean
function set Success (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
A Boolean value, true if the seek operation is successful, otherwise false.  

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

