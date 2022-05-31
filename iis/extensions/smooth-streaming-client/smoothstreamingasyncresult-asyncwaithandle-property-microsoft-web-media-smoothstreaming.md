---
title: SmoothStreamingAsyncResult.AsyncWaitHandle Property (Microsoft.Web.Media.SmoothStreaming)
description: The SmoothStreamingAsyncResult.AsyncWaitHandle Property gets the wait handle used by the application to wait.
TOCTitle: AsyncWaitHandle Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncWaitHandle
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.asyncwaithandle(v=VS.95)
ms:contentKeyID: 46307802
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncWaitHandle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_AsyncWaitHandle
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.AsyncWaitHandle
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_AsyncWaitHandle
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingAsyncResult.AsyncWaitHandle Property

Gets the wait handle used by the application to wait.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property AsyncWaitHandle As WaitHandle
    Get
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim value As WaitHandle

value = instance.AsyncWaitHandle
```

```csharp
public WaitHandle AsyncWaitHandle { get; }
```

```cpp
public:
virtual property WaitHandle^ AsyncWaitHandle {
    WaitHandle^ get () sealed;
}
```

``` fsharp
abstract AsyncWaitHandle : WaitHandle
override AsyncWaitHandle : WaitHandle
```

```jscript
final function get AsyncWaitHandle () : WaitHandle
```

### Property Value

Type: [System.Threading.WaitHandle](https://msdn.microsoft.com/library/9f7e54k1\(v=vs.95\))  
The wait handle.

### Implements

[IAsyncResult.AsyncWaitHandle](https://msdn.microsoft.com/library/tbbhxekx\(v=vs.95\))  

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
