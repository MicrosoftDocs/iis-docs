---
title: SetPlaybackRangeCompletedEventArgs Constructor (Exception, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SetPlaybackRangeCompletedEventArgs Constructor (Exception, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SetPlaybackRangeCompletedEventArgs.#ctor(System.Exception,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.setplaybackrangecompletedeventargs.setplaybackrangecompletedeventargs(v=VS.95)
ms:contentKeyID: 46307678
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

# SetPlaybackRangeCompletedEventArgs Constructor (Exception, Object)

Initializes a new instance of the [SetPlaybackRangeCompletedEventArgs](setplaybackrangecompletedeventargs-class-microsoft-web-media-smoothstreaming.md) class for a failed completion of a SetPlaybackRangeAysnc operation.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    error As Exception, _
    userState As Object _
)
'Usage

Dim error As Exception
Dim userState As Object

Dim instance As New SetPlaybackRangeCompletedEventArgs(error, userState)
```

```csharp
public SetPlaybackRangeCompletedEventArgs(
    Exception error,
    Object userState
)
```

```cpp
public:
SetPlaybackRangeCompletedEventArgs(
    Exception^ error, 
    Object^ userState
)
```

``` fsharp
new : 
        error:Exception * 
        userState:Object -> SetPlaybackRangeCompletedEventArgs
```

```jscript
public function SetPlaybackRangeCompletedEventArgs(
    error : Exception, 
    userState : Object
)
```

### Parameters

  - error  
    Type: [System.Exception](https://msdn.microsoft.com/library/c18k6c59\(v=vs.95\))  
    The error that occurred.

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

