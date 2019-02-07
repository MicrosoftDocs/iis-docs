---
title: SmoothStreamingErrorEventArgs.ErrorException Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ErrorException Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorException
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingerroreventargs.errorexception(v=VS.90)
ms:contentKeyID: 23961062
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.get_ErrorException
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingErrorEventArgs.set_ErrorException
dev_langs:
- CSharp
- JScript
- VB
- c++
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

# ErrorException Property

Gets or sets the ErrorException property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property ErrorException As Exception
'Usage

  Dim instance As SmoothStreamingErrorEventArgs
Dim value As Exception

value = instance.ErrorException

instance.ErrorException = value
```

``` csharp
  public Exception ErrorException { get; set; }
```

``` c++
  public:
property Exception^ ErrorException {
    Exception^ get ();
    void set (Exception^ value);
}
```

``` jscript
  function get ErrorException () : Exception
function set ErrorException (value : Exception)
```

#### Property Value

Type: [System. . :: . .Exception](https://msdn.microsoft.com/en-us/library/c18k6c59\(v=vs.90\))  
A [SmoothStreamingException](smoothstreamingexception-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingErrorEventArgs Class](smoothstreamingerroreventargs-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

