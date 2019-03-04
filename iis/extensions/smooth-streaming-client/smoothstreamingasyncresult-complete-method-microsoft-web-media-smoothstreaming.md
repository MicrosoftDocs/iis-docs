---
title: SmoothStreamingAsyncResult.Complete Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Complete Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Complete(System.Object,System.Boolean)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.complete(v=VS.95)
ms:contentKeyID: 46307683
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Complete
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Complete
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingAsyncResult.Complete Method

Called when the operation has completed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Sub Complete ( _
    result As Object, _
    completedSynchronously As Boolean _
)
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim result As Object
Dim completedSynchronously As Boolean

instance.Complete(result, completedSynchronously)
```

```csharp
public void Complete(
    Object result,
    bool completedSynchronously
)
```

```cpp
public:
void Complete(
    Object^ result, 
    bool completedSynchronously
)
```

``` fsharp
member Complete : 
        result:Object * 
        completedSynchronously:bool -> unit 
```

```jscript
public function Complete(
    result : Object, 
    completedSynchronously : boolean
)
```

### Parameters

  - result  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    The results of calling the [BeginGetChunk(TimeSpan, AsyncCallback, Object)](trackinfo-begingetchunk-method-microsoft-web-media-smoothstreaming_1.md) method.

<!-- end list -->

  - completedSynchronously  
    Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
    true to indicate that the method completed synchronously; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

