---
title: CircularList(T).Add Method  (Microsoft.Web.Media.Diagnostics)
description: Learn how the Add method has been deprecated and is not to be used.
TOCTitle: Add Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.CircularList`1.Add(`0)
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728132(v=VS.90)
ms:contentKeyID: 31469152
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1.Add
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1.Add
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# Add Method

(Deprecated. Do not use) Adds an object to the end of the [CircularList\<(Of \<(\<'T\>)\>)\>](circularlist-t-class-microsoft-web-media-diagnostics_1.md).

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Sub Add ( _
    item As T _
)
'Usage

  Dim instance As CircularList
Dim item As T

instance.Add(item)
```

```csharp
  public void Add(
    T item
)
```

```cpp
  public:
void Add(
    T item
)
```

```jscript
  public function Add(
    item : T
)
```

### Parameters

  - item  
    Type: [T](circularlist-t-class-microsoft-web-media-diagnostics_1.md)  
    The object to be added to the list.  

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
