---
title: ChunkDownloadedEventArgs.RequestType Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: RequestType Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.RequestType
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkdownloadedeventargs.requesttype(v=VS.95)
ms:contentKeyID: 46307752
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_RequestType
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_RequestType
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.RequestType
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.get_RequestType
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.RequestType
- Microsoft.Web.Media.SmoothStreaming.ChunkDownloadedEventArgs.set_RequestType
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ChunkDownloadedEventArgs.RequestType Property

Gets the request type being downloaded.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property RequestType As ChunkRequestType
    Get
    Private Set
'Usage

Dim instance As ChunkDownloadedEventArgs
Dim value As ChunkRequestType

value = instance.RequestType
```

```csharp
public ChunkRequestType RequestType { get; private set; }
```

```cpp
public:
property ChunkRequestType RequestType {
    ChunkRequestType get ();
    private: void set (ChunkRequestType value);
}
```

``` fsharp
member RequestType : ChunkRequestType with get, private set
```

```jscript
function get RequestType () : ChunkRequestType
private function set RequestType (value : ChunkRequestType)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ChunkRequestType](chunkrequesttype-enumeration-microsoft-web-media-smoothstreaming.md)  
A ChunkRequestType object that represents the request type.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ChunkDownloadedEventArgs Class](chunkdownloadedeventargs-class-microsoft-web-media-smoothstreaming.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

