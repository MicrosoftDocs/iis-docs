---
title: TrackInfo.CompareTo Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CompareTo Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.trackinfo.compareto(v=VS.90)
ms:contentKeyID: 23961004
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo
dev_langs:
- csharp
- jscript
- vb
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# CompareTo Method

Compares a T:Microsoft.Web.Media.SmoothStreaming.TrackInfo object to an object specified by the obj parameter.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Function CompareTo ( _
    obj As Object _
) As Integer
'Usage

  Dim instance As TrackInfo
Dim obj As Object
Dim returnValue As Integer

returnValue = instance.CompareTo(obj)
```

```csharp
  public int CompareTo(
    Object obj
)
```

```cpp
  public:
virtual int CompareTo(
    Object^ obj
) sealed
```

```jscript
  public final function CompareTo(
    obj : Object
) : int
```

### Parameters

  - obj  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    An [Object](https://msdn.microsoft.com/library/e5kfa45b) to compare.  

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d)  

An integer value that specifies the result of the comparison:  

  - Zero (0), if the event is equal to the specified object.

  - Less than zero (\<0), if the event is less than the specified object.

  - Greater than zero (\>0), if the event is greater than the specified object.

### Implements

[IComparable.CompareTo(Object)](https://msdn.microsoft.com/library/4ah99705)  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
