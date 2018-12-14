---
title: ChunkInfo.CompareTo Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CompareTo Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ChunkInfo.CompareTo(System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkinfo.compareto(v=VS.90)
ms:contentKeyID: 31469315
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.CompareTo
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkInfo.CompareTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CompareTo Method

Compares a chunk to another object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration
PublicFunctionCompareTo ( _
    otherAsObject _
) AsInteger
'Usage
DiminstanceAsChunkInfoDimotherAsObjectDimreturnValueAsIntegerreturnValue = instance.CompareTo(other)
```

``` csharp
publicintCompareTo(
    Objectother
)
```

``` c++
public:
virtualintCompareTo(
    Object^ other
) sealed
```

``` jscript
publicfinalfunctionCompareTo(
    other : Object
) : int
```

#### Parameters

  - other  
    Type: [System. . :: . .Object](https://msdn.microsoft.com/en-us/library/e5kfa45b\(v=vs.90\))  
    An \[T:System.Object.\]  

#### Return Value

Type: [System. . :: . .Int32](https://msdn.microsoft.com/en-us/library/td2s409d\(v=vs.90\))  
Integer value that indicates the result of the comparison, zero if equal, less than zero if earlier in time, greater than zero if later in time.  

#### Implements

[IComparable. . :: . .CompareTo(Object)](https://msdn.microsoft.com/en-us/library/4ah99705\(v=vs.90\))  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ChunkInfo Class](chunkinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

