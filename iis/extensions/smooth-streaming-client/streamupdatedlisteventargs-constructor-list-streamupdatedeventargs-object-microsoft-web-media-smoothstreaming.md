---
title: StreamUpdatedListEventArgs Constructor (List(StreamUpdatedEventArgs), Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedListEventArgs Constructor (List(StreamUpdatedEventArgs), Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.#ctor(System.Collections.Generic.List{Microsoft.Web.Media.SmoothStreaming.StreamUpdatedEventArgs},System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedlisteventargs(v=VS.90)
ms:contentKeyID: 31469304
ms.date: 05/02/2012
mtps_version: v=VS.90
dev_langs:
- vb
- csharp
- cpp
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

# StreamUpdatedListEventArgs Constructor (List(StreamUpdatedEventArgs), Object)

Initializes a new instance of the [StreamUpdatedListEventArgs](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

```jscript
  public function StreamUpdatedListEventArgs(
    streamUpdatedEvents : List<StreamUpdatedEventArgs>,
    userState : Object
)
```

### Parameters

  - streamUpdatedEvents  
    Type: [System.Collections.Generic.List](https://msdn.microsoft.com/library/6sh2ey19)\< (Of \< ( \<'[StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md)\> ) \> ) \>  
    A [StreamUpdatedEventArgs](streamupdatedeventargs-class-microsoft-web-media-smoothstreaming_1.md) object.  

<!-- end list -->

  - userState  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b)  
    Use defined state [Object](https://msdn.microsoft.com/library/e5kfa45b).  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[StreamUpdatedListEventArgs Class](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md)

[StreamUpdatedListEventArgs Overload](streamupdatedlisteventargs-constructor-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
