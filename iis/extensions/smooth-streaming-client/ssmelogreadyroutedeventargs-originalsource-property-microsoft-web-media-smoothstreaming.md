---
title: SSMELogReadyRoutedEventArgs.OriginalSource Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: OriginalSource Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ssmelogreadyroutedeventargs.originalsource(v=VS.90)
ms:contentKeyID: 31469256
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_OriginalSource
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.get_OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.OriginalSource
- Microsoft.Web.Media.SmoothStreaming.SSMELogReadyRoutedEventArgs.set_OriginalSource
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# OriginalSource Property

Gets or sets the object that raised the event.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property OriginalSource As Object
'Usage

  Dim instance As SSMELogReadyRoutedEventArgs
Dim value As Object

value = instance.OriginalSource
```

```csharp
  public Object OriginalSource { get; private set; }
```

```cpp
  public:
property Object^ OriginalSource {
    Object^ get ();
    private: void set (Object^ value);
}
```

```jscript
  function get OriginalSource () : Object
private function set OriginalSource (value : Object)
```

### Property Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
An [Object](https://msdn.microsoft.com/library/e5kfa45b) that is the source of the event.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SSMELogReadyRoutedEventArgs Class](ssmelogreadyroutedeventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
