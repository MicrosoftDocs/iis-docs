---
title: ISmoothStreamingCache.BeginRetrieve Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: BeginRetrieve Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.BeginRetrieve(Microsoft.Web.Media.SmoothStreaming.CacheRequest,System.AsyncCallback,System.Object)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.ismoothstreamingcache.beginretrieve(v=VS.95)
ms:contentKeyID: 46307666
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.BeginRetrieve
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ISmoothStreamingCache.BeginRetrieve
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ISmoothStreamingCache.BeginRetrieve Method

Begins an asynchronous cache response retrieval.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Function BeginRetrieve ( _
    request As CacheRequest, _
    callback As AsyncCallback, _
    state As Object _
) As IAsyncResult
'Usage

Dim instance As ISmoothStreamingCache
Dim request As CacheRequest
Dim callback As AsyncCallback
Dim state As Object
Dim returnValue As IAsyncResult

returnValue = instance.BeginRetrieve(request, _
    callback, state)
```

```csharp
IAsyncResult BeginRetrieve(
    CacheRequest request,
    AsyncCallback callback,
    Object state
)
```

```cpp
IAsyncResult^ BeginRetrieve(
    CacheRequest^ request, 
    AsyncCallback^ callback, 
    Object^ state
)
```

``` fsharp
abstract BeginRetrieve : 
        request:CacheRequest * 
        callback:AsyncCallback * 
        state:Object -> IAsyncResult 
```

```jscript
function BeginRetrieve(
    request : CacheRequest, 
    callback : AsyncCallback, 
    state : Object
) : IAsyncResult
```

### Parameters

  - request  
    Type: [Microsoft.Web.Media.SmoothStreaming.CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md)  
    A [CacheRequest](cacherequest-class-microsoft-web-media-smoothstreaming_1.md) object that describes the request being made.

<!-- end list -->

  - callback  
    Type: [System.AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\))  
    A [AsyncCallback](https://msdn.microsoft.com/library/ckbe7yh5\(v=vs.95\)) delegate method to complete the operation.

<!-- end list -->

  - state  
    Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
    A [Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\)) that represents state for the request.

### Return Value

Type: [System.IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\))  
An [IAsyncResult](https://msdn.microsoft.com/library/ft8a6455\(v=vs.95\)) object.

## Examples

The following code shows an implementation of the BeginRetrieve(CacheRequest, AsyncCallback, Object) method.

``` 
    public IAsyncResult BeginRetrieve(CacheRequest request, AsyncCallback callback, object state)
    {
        CacheResponse response = null;
        CacheAsyncResult ar = new CacheAsyncResult();
        ar.strUrl = request.CanonicalUri.ToString();
        ar.Complete(response, true);
        return ar; 
    }        
```

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ISmoothStreamingCache Interface](ismoothstreamingcache-interface-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
