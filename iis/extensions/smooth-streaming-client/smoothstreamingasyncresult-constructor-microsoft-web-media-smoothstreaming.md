---
title: SmoothStreamingAsyncResult Constructor  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: SmoothStreamingAsyncResult Constructor
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.#ctor(System.AsyncCallback,System.Object,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.smoothstreamingasyncresult(v=VS.95)
ms:contentKeyID: 46307680
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.SmoothStreamingAsyncResult
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.#ctor
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult..ctor
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingAsyncResult Constructor

Initializes a new instance of the [SmoothStreamingAsyncResult](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md) class.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub New ( _
    callback As AsyncCallback, _
    state As Object, _
    callbackOnUIThread As Boolean _
)
'Usage

Dim callback As AsyncCallback
Dim state As Object
Dim callbackOnUIThread As Boolean

Dim instance As New SmoothStreamingAsyncResult(callback, _
    state, callbackOnUIThread)
```

```csharp
public SmoothStreamingAsyncResult(
    AsyncCallback callback,
    Object state,
    bool callbackOnUIThread
)
```

```cpp
public:
SmoothStreamingAsyncResult(
    AsyncCallback^ callback, 
    Object^ state, 
    bool callbackOnUIThread
)
```

``` fsharp
new : 
        callback:AsyncCallback * 
        state:Object * 
        callbackOnUIThread:bool -> SmoothStreamingAsyncResult
```

```jscript
public function SmoothStreamingAsyncResult(
    callback : AsyncCallback, 
    state : Object, 
    callbackOnUIThread : boolean
)
```

### Parameters

  - callback  
    Type: [System.AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\))  
    The callback function to invoke when [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) has completed. Used in asynchronous mode only.

<!-- end list -->

  - state  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    Application state information that is supplied by the caller.

<!-- end list -->

  - callbackOnUIThread  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    Indicates whether the callback is called on the UI thread for asynchronous completions. true if the callback is called on the UI thread for asynchronous completions; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
