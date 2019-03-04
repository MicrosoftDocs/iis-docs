---
title: SmoothStreamingErrorEventArgs.ErrorCode Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ErrorCode Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorCode
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs.errorcode(v=VS.95)
ms:contentKeyID: 46307809
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorCode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorCode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorCode
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorCode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorCode
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorCode
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingErrorEventArgs.ErrorCode Property

Gets or sets the ErrorCode property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ErrorCode As Integer
    Get
    Set
'Usage

Dim instance As SmoothStreamingErrorEventArgs
Dim value As Integer

value = instance.ErrorCode

instance.ErrorCode = value
```

```csharp
public int ErrorCode { get; set; }
```

```cpp
public:
property int ErrorCode {
    int get ();
    void set (int value);
}
```

``` fsharp
member ErrorCode : int with get, set
```

```jscript
function get ErrorCode () : int
function set ErrorCode (value : int)
```

### Property Value

Type: [System.Int32](https://msdn.microsoft.com/library/td2s409d\(v=vs.95\))  
An integer value that contains the error code.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingErrorEventArgs Class](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

