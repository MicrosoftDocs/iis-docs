---
title: CircularList(T) Constructor  (Microsoft.Web.Media.Diagnostics)
TOCTitle: CircularList(T) Constructor
ms:assetid: M:Microsoft.Web.Media.Diagnostics.CircularList`1.#ctor(System.Int32)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/Ff728288(v=VS.90)
ms:contentKeyID: 31469307
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1.#ctor
- Microsoft.Web.Media.Diagnostics.CircularList`1.CircularList
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CircularList(T) Constructor

(Deprecated. Do not use) Initializes a new instance of the [CircularList\<(Of \<(\<'T\>)\>)\>](circularlist-t-class-microsoft-web-media-diagnostics_1.md) class.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub New ( _
    maxLength As Integer _
)
'Usage

  Dim maxLength As Integer

Dim instance As New CircularList(maxLength)
```

```csharp
  public CircularList(
    int maxLength
)
```

```cpp
  public:
CircularList(
    int maxLength
)
```

```jscript
  public function CircularList(
    maxLength : int
)
```

### Parameters

  - maxLength  
    Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  
    An integer value that specifies the maximum length of this list.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[CircularList\< (Of \< ( \<'T\> ) \> ) \> Class](circularlist-t-class-microsoft-web-media-diagnostics_1.md)

[Microsoft.Web.Media.Diagnostics Namespace](microsoft-web-media-diagnostics-namespace_1.md)

