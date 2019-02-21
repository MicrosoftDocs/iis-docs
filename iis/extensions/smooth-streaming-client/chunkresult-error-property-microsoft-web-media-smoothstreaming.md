---
title: ChunkResult.Error Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Error Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.error(v=VS.90)
ms:contentKeyID: 31469262
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Error
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Error
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# Error Property

Contains error information if an error occurs.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property Error As Exception
'Usage

  Dim instance As ChunkResult
Dim value As Exception

value = instance.Error
```

```csharp
  public Exception Error { get; private set; }
```

```cpp
  public:
property Exception^ Error {
    Exception^ get ();
    private: void set (Exception^ value);
}
```

```jscript
  function get Error () : Exception
private function set Error (value : Exception)
```

### Property Value

Type: [System.Exception](https://msdn.microsoft.com/library/c18k6c59)  
An [Exception](https://msdn.microsoft.com/library/c18k6c59) object.  

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

