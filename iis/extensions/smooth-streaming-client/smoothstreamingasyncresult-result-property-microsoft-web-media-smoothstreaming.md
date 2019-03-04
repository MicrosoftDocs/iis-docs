---
title: SmoothStreamingAsyncResult.Result Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Result Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Result
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingasyncresult.result(v=VS.95)
ms:contentKeyID: 46307808
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_Result
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Result
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.get_Result
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.Result
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingAsyncResult.set_Result
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingAsyncResult.Result Property

Returns the result of calling [EndGetChunk(IAsyncResult)](trackinfo-endgetchunk-method-microsoft-web-media-smoothstreaming_1.md).

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Result As Object
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingAsyncResult
Dim value As Object

value = instance.Result
```

```csharp
public Object Result { get; private set; }
```

```cpp
public:
property Object^ Result {
    Object^ get ();
    private: void set (Object^ value);
}
```

``` fsharp
member Result : Object with get, private set
```

```jscript
function get Result () : Object
private function set Result (value : Object)
```

### Property Value

Type: [System.Object](https://msdn.microsoft.com/library/e5kfa45b\(v=vs.95\))  
An object that contains the result.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingAsyncResult Class](smoothstreamingasyncresult-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

