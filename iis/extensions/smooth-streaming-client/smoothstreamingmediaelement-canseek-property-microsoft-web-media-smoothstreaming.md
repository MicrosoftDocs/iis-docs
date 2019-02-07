---
title: SmoothStreamingMediaElement.CanSeek Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CanSeek Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.canseek(v=VS.90)
ms:contentKeyID: 23961056
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CanSeek
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CanSeek
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CanSeek
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# CanSeek Property

Gets or sets whether the position in the stream can be reset.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Property CanSeek As Boolean
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.CanSeek

instance.CanSeek = value
```

``` csharp
  public bool CanSeek { get; set; }
```

``` c++
  public:
property bool CanSeek {
    bool get ();
    void set (bool value);
}
```

``` jscript
  function get CanSeek () : boolean
function set CanSeek (value : boolean)
```

#### Property Value

Type: [System. . :: . .Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.90\))  
true if the media element can seek to a new position in the stream; otherwise, false.  

## Version Information

#### Silverlight

Supported in: 4  

#### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

