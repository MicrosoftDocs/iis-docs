---
title: CacheResponse.ContinueProcessing Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ContinueProcessing Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContinueProcessing
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.continueprocessing(v=VS.95)
ms:contentKeyID: 46307743
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContinueProcessing
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContinueProcessing
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContinueProcessing
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.ContinueProcessing
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.get_ContinueProcessing
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.set_ContinueProcessing
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheResponse.ContinueProcessing Property

Gets a Boolean value indicating whether cache response processing continues to the next cache module (including HTTP download) in case of a cache miss.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ContinueProcessing As Boolean
    Get
    Private Set
'Usage

Dim instance As CacheResponse
Dim value As Boolean

value = instance.ContinueProcessing
```

```csharp
public bool ContinueProcessing { get; private set; }
```

```cpp
public:
property bool ContinueProcessing {
    bool get ();
    private: void set (bool value);
}
```

``` fsharp
member ContinueProcessing : bool with get, private set
```

```jscript
function get ContinueProcessing () : boolean
private function set ContinueProcessing (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50\(v=vs.95\))  
true if the cache response processing continues; otherwise, false.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

