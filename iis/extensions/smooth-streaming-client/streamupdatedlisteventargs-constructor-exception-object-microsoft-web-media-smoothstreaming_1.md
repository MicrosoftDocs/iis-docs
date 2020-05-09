---
title: StreamUpdatedListEventArgs Constructor (Exception, Object) (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: StreamUpdatedListEventArgs Constructor (Exception, Object)
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs.#ctor(System.Exception,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.streamupdatedlisteventargs.streamupdatedlisteventargs(v=VS.95)
ms:contentKeyID: 46307698
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
- Microsoft.Web.Media.SmoothStreaming.StreamUpdatedListEventArgs..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# StreamUpdatedListEventArgs Constructor (Exception, Object)

Initializes a new instance of the [StreamUpdatedListEventArgs](streamupdatedlisteventargs-class-microsoft-web-media-smoothstreaming_1.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

Dim instance As New StreamUpdatedListEventArgs(error, userState)
```

```csharp
public StreamUpdatedListEventArgs(
    Exception error,
    Object userState
)
```

```cpp
public:
StreamUpdatedListEventArgs(
    Exception^ error, 
    Object^ userState
)
```

``` fsharp
new : 
        error:Exception * 
        userState:Object -> StreamUpdatedListEventArgs
```

```jscript
public function StreamUpdatedListEventArgs(
    error : Exception, 
    userState : Object
)
```

### Parameters

  - error  
    Type: [System.Exception](https://msdn.microsoft.com/library/c18k6c59\(v=vs.95\))  
    A System.Exception,System.Object object.

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
