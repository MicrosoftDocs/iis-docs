---
title: SetPlaybackRangeCompletedEventArgs Constructor (TimeSpan, TimeSpan, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeCompletedEventArgs Constructor (TimeSpan, TimeSpan, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.#ctor(System.TimeSpan,System.TimeSpan,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs.setplaybackrangecompletedeventargs(v=VS.95)
ms:contentKeyID: 46307681
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- cpp
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs..ctor
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SetPlaybackRangeCompletedEventArgs Constructor (TimeSpan, TimeSpan, Object)

Initializes a new instance of the [SetPlaybackRangeCompletedEventArgs](setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md) class for a successful completion of a SetPlaybackRangeAysnc operation.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    leftEdge As TimeSpan, _
    rightEdge As TimeSpan, _
    userState As Object _
)
'Usage

Dim leftEdge As TimeSpan
Dim rightEdge As TimeSpan
Dim userState As Object

Dim instance As New SetPlaybackRangeCompletedEventArgs(leftEdge, _
    rightEdge, userState)
```

```csharp
public SetPlaybackRangeCompletedEventArgs(
    TimeSpan leftEdge,
    TimeSpan rightEdge,
    Object userState
)
```

```cpp
public:
SetPlaybackRangeCompletedEventArgs(
    TimeSpan leftEdge, 
    TimeSpan rightEdge, 
    Object^ userState
)
```

``` fsharp
new : 
        leftEdge:TimeSpan * 
        rightEdge:TimeSpan * 
        userState:Object -> SetPlaybackRangeCompletedEventArgs
```

```jscript
public function SetPlaybackRangeCompletedEventArgs(
    leftEdge : TimeSpan, 
    rightEdge : TimeSpan, 
    userState : Object
)
```

### Parameters

  - leftEdge  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
    A TimeSpan value that represents the left-most position for a seek operation.

<!-- end list -->

  - rightEdge  
    Type: [System.TimeSpan](https://msdn.microsoft.com/library/269ew577\(v=vs.95\))  
    A TimeSpan value that represents the player application's expected right-most position or chunk timestamp.

<!-- end list -->

  - userState  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    A state object that represents the state.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SetPlaybackRangeCompletedEventArgs Class](setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md)

[SetPlaybackRangeCompletedEventArgs Overload](setplaybackrangecompletedeventargs-constructor-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

