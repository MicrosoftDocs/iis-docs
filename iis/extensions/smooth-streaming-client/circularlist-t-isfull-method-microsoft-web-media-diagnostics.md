---
title: CircularList(T).IsFull Method  (Microsoft.Web.Media.Diagnostics)
TOCTitle: IsFull Method
ms:assetid: M:Microsoft.Web.Media.Diagnostics.CircularList`1.IsFull
ms:mtpsurl: https://msdn.microsoft.com/library/Ff728270(v=VS.90)
ms:contentKeyID: 31469289
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.Diagnostics.CircularList`1.IsFull
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.Diagnostics.CircularList`1.IsFull
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# IsFull Method

(Deprecated. Do not use) Boolean value that indicates whether the list is full.

**Namespace:**  [Microsoft.Web.Media.Diagnostics](microsoft-web-media-diagnostics-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Function IsFull As Boolean
'Usage

  Dim instance As CircularList
Dim returnValue As Boolean

returnValue = instance.IsFull()
```

```csharp
  public bool IsFull()
```

```cpp
  public:
bool IsFull()
```

```jscript
  public function IsFull() : boolean
```

### Return Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
Returns [Boolean](https://msdn.microsoft.com/library/a28wyd50). True if the list is full.  

## Remarks

Adding a new element will cause the oldest element to be removed.

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
