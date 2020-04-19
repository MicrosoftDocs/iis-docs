---
title: ClipContext.Data Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Data Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.clipcontext.data(v=VS.90)
ms:contentKeyID: 23961264
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_Data
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_Data
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_Data
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Data Property

Gets or sets the Data property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Data As Object
'Usage

  Dim instance As ClipContext
Dim value As Object

value = instance.Data
```

```csharp
  public Object Data { get; private set; }
```

```cpp
  public:
property Object^ Data {
    Object^ get ();
    private: void set (Object^ value);
}
```

```jscript
  function get Data () : Object
private function set Data (value : Object)
```

### Property Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
A [Object](https://msdn.microsoft.com/library/e5kfa45b) that contains media data.  

## Remarks

Any data passed by the player application.

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
