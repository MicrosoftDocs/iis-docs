---
title: SmoothStreamingErrorEventArgs.ErrorMessage Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ErrorMessage Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs.errormessage(v=VS.90)
ms:contentKeyID: 23960970
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorMessage
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorMessage
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorMessage
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ErrorMessage Property

Gets or sets the ErrorMessage property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ErrorMessage As String
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

```jscript
  function get ErrorMessage () : String
function set ErrorMessage (value : String)
```

### Property Value

Type: [System.String](https://msdn.microsoft.com/library/s1wwdcbf)  
A string value that contains the error message.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingErrorEventArgs Class](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

