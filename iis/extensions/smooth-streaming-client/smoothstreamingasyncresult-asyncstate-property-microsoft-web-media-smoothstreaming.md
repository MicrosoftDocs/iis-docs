---
title: SmoothStreamingAsyncResult.AsyncState Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: AsyncState Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncState
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.asyncstate(v=VS.95)
ms:contentKeyID: 46307792
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_AsyncState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_AsyncState
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_AsyncState
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_AsyncState
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingAsyncResult.AsyncState Property

Gets the state information passed by the application.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property AsyncState As Object
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim value As Object

value = instance.AsyncState
```

```csharp
public Object AsyncState { get; private set; }
```

```cpp
public:
virtual property Object^ AsyncState {
    Object^ get () sealed;
    private: void set (Object^ value) sealed;
}
```

``` fsharp
abstract AsyncState : Object with get, private set
override AsyncState : Object with get, private set
```

```jscript
final function get AsyncState () : Object
private final function set AsyncState (value : Object)
```

### Property Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
An object that contains the state information.

### Implements

[IAsyncResult.AsyncState](https://msdn.microsoft.com/library/a6zaz1xf\(v=vs.95\))  

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
