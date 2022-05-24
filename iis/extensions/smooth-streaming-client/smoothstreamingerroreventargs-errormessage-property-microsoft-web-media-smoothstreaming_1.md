---
title: SmoothStreamingErrorEventArgs.ErrorMessage Property (Microsoft.Web.Media.SmoothStreaming)
description: Describes the SmoothStreamingErrorEventArgs.ErrorMEssage property and provides the property's namespace, assembly, syntax, and version information.
TOCTitle: ErrorMessage Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs.errormessage(v=VS.95)
ms:contentKeyID: 46307800
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorMessage
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorMessage
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingErrorEventArgs.ErrorMessage Property

Gets or sets the ErrorMessage property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ErrorMessage As String
    Get
    Set
'Usage

Dim instance As SmoothStreamingErrorEventArgs
Dim value As String

value = instance.ErrorMessage

instance.ErrorMessage = value
```

```csharp
public string ErrorMessage { get; set; }
```

```cpp
public:
property String^ ErrorMessage {
    String^ get ();
    void set (String^ value);
}
```

``` fsharp
member ErrorMessage : string with get, set
```

```jscript
function get ErrorMessage () : String
function set ErrorMessage (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf\(v=vs.95\))  
A string value that contains the error message.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingErrorEventArgs Class](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
