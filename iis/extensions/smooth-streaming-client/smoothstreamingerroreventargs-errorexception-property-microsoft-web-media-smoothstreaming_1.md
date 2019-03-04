---
title: SmoothStreamingErrorEventArgs.ErrorException Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ErrorException Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorException
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs.errorexception(v=VS.95)
ms:contentKeyID: 46307798
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorException
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorException
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingErrorEventArgs.ErrorException Property

Gets or sets the ErrorException property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ErrorException As Exception
    Get
    Set
'Usage

Dim instance As SmoothStreamingErrorEventArgs
Dim value As Exception

value = instance.ErrorException

instance.ErrorException = value
```

```csharp
public Exception ErrorException { get; set; }
```

```cpp
public:
property Exception^ ErrorException {
    Exception^ get ();
    void set (Exception^ value);
}
```

``` fsharp
member ErrorException : Exception with get, set
```

```jscript
function get ErrorException () : Exception
function set ErrorException (value : Exception)
```

### Property Value

Type: [System.Exception](https://msdn.microsoft.com/library/c18k6c59\(v=vs.95\))  
A [SmoothStreamingException](smoothstreamingexception-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingErrorEventArgs Class](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

