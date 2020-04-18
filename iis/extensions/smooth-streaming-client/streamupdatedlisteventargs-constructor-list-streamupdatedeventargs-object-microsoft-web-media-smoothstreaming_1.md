---
title: StreamUpdatedListEventArgs Constructor (List(StreamUpdatedEventArgs), Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedListEventArgs Constructor (List(StreamUpdatedEventArgs), Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.#ctor(System.Collections.Generic.List{Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs},System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedlisteventargs(v=VS.95)
ms:contentKeyID: 46307482
ms.date: 05/31/2012
mtps_version: v=VS.95
dev_langs:
- vb
- csharp
- "cpp"
- fsharp
- jscript
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamUpdatedListEventArgs Constructor (List\<StreamUpdatedEventArgs\>, Object)

Initializes a new instance of the [StreamUpdatedListEventArgs](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    streamUpdatedEvents As List(Of StreamUpdatedEventArgs), _
    userState As Object _
)
'Usage

Dim streamUpdatedEvents As List(Of StreamUpdatedEventArgs)
Dim userState As Object

Dim instance As New StreamUpdatedListEventArgs(streamUpdatedEvents, _
    userState)
```

```csharp
public StreamUpdatedListEventArgs(
    List<StreamUpdatedEventArgs> streamUpdatedEvents,
    Object userState
)
```

```cpp
public:
StreamUpdatedListEventArgs(
    List<StreamUpdatedEventArgs^>^ streamUpdatedEvents, 
    Object^ userState
)
```

``` fsharp
new : 
        streamUpdatedEvents:List<StreamUpdatedEventArgs> * 
        userState:Object -> StreamUpdatedListEventArgs
```

```jscript
public function StreamUpdatedListEventArgs(
    streamUpdatedEvents : List<StreamUpdatedEventArgs>, 
    userState : Object
)
```

### Parameters

  - streamUpdatedEvents  
    Type: [System.Collections.Generic.List](https://msdn.microsoft.com/library/6sh2ey19\(v=vs.95\))\<[StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)\>  
    A [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) object.

<!-- end list -->

  - userState  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    Use defined state [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)).

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[StreamUpdatedListEventArgs Class](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)

[StreamUpdatedListEventArgs Overload](streamupdatedlisteventargs-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
