---
title: ClipInformation.ClipUri Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ClipUri Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.clipuri(v=VS.90)
ms:contentKeyID: 31469298
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClipUri
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_ClipUri
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_ClipUri
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipUri Property

Gets or sets a [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\)) object that contains the clip source.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property ClipUri As Uri
'Usage

  Dim instance As ClipInformation
Dim value As Uri

value = instance.ClipUri
```

``` csharp
  public Uri ClipUri { get; private set; }
```

``` c++
  public:
property Uri^ ClipUri {
    Uri^ get ();
    private: void set (Uri^ value);
}
```

``` jscript
  function get ClipUri () : Uri
private function set ClipUri (value : Uri)
```

#### Property Value

Type: [System. . :: . .Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\))  
A [Uri](https://msdn.microsoft.com/en-us/library/txt7706a\(v=vs.90\)) object that contains the clip source.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

