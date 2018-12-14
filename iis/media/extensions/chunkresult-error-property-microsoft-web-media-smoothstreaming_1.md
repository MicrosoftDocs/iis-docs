---
title: ChunkResult.Error Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Error Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.chunkresult.error(v=VS.95)
ms:contentKeyID: 46307763
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Error
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.get_Error
- Microsoft.Web.Media.SmoothStreaming.ChunkResult.set_Error
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ChunkResult.Error Property

Contains error information if an error occurs.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property Error As Exception
    Get
    Private Set
'Usage

Dim instance As ChunkResult
Dim value As Exception

value = instance.Error
```

``` csharp
public Exception Error { get; private set; }
```

``` c++
public:
property Exception^ Error {
    Exception^ get ();
    private: void set (Exception^ value);
}
```

``` fsharp
member Error : Exception with get, private set
```

``` jscript
function get Error () : Exception
private function set Error (value : Exception)
```

#### Property Value

Type: [System.Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.95\))  
An [Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.95\)) object.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[ChunkResult Class](chunkresult-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

