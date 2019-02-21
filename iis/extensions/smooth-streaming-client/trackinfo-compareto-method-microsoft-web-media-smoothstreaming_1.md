---
title: TrackInfo.CompareTo Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CompareTo Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.trackinfo.compareto(v=VS.95)
ms:contentKeyID: 46307699
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo
dev_langs:
- csharp
- jscript
- vb
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.TrackInfo.CompareTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# TrackInfo.CompareTo Method

Compares a T:Microsoft.Web.Media.SmoothStreaming.TrackInfo object to an object specified by the obj parameter.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

``` fsharp
abstract CompareTo : 
        obj:Object -> int 
override CompareTo : 
        obj:Object -> int 
```

```jscript
public final function CompareTo(
    obj : Object
) : int
```

### Parameters

  - obj  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    An [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)) to compare.

### Return Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d\(v=vs.95\))  

An integer value that specifies the result of the comparison:

  - Zero (0), if the event is equal to the specified object.

  - Less than zero (\<0), if the event is less than the specified object.

  - Greater than zero (\>0), if the event is greater than the specified object.

### Implements

[IComparable.CompareTo(Object)](https://msdn.microsoft.com/library/4ah99705\(v=vs.95\))  

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[TrackInfo Class](trackinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

