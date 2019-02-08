---
title: CacheResponse.WriteTo Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: WriteTo Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.CacheResponse.WriteTo(System.IO.Stream)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.cacheresponse.writeto(v=VS.95)
ms:contentKeyID: 46307643
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.WriteTo
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.CacheResponse.WriteTo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CacheResponse.WriteTo Method

Writes the response to a [Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.95\)) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Overridable Sub WriteTo ( _
    stream As Stream _
)
'Usage

Dim instance As CacheResponse
Dim stream As Stream

instance.WriteTo(stream)
```

``` csharp
public virtual void WriteTo(
    Stream stream
)
```

``` c++
public:
virtual void WriteTo(
    Stream^ stream
)
```

``` fsharp
abstract WriteTo : 
        stream:Stream -> unit 
override WriteTo : 
        stream:Stream -> unit 
```

``` jscript
public function WriteTo(
    stream : Stream
)
```

#### Parameters

  - stream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.95\))  
    The [Stream](https://msdn.microsoft.com/en-us/library/8f86tw9e\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[CacheResponse Class](cacheresponse-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

