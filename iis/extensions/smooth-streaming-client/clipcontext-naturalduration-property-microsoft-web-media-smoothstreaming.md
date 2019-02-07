---
title: ClipContext.NaturalDuration Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: NaturalDuration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.naturalduration(v=VS.90)
ms:contentKeyID: 31469229
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
dev_langs:
- CSharp
- JScript
- VB
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_NaturalDuration
- Microsoft.Web.Media.SmoothStreaming.ClipContext.NaturalDuration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# NaturalDuration Property

Gets the natural duration for the clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

  Public Overridable ReadOnly Property NaturalDuration As Duration
'Usage

  Dim instance As ClipContext
Dim value As Duration

value = instance.NaturalDuration
```

``` csharp
  public virtual Duration NaturalDuration { get; }
```

``` c++
  public:
virtual property Duration NaturalDuration {
    Duration get ();
}
```

``` jscript
  function get NaturalDuration () : Duration
```

#### Property Value

Type: [System.Windows. . :: . .Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.90\))  
A [Duration](https://msdn.microsoft.com/en-us/library/ms602372\(v=vs.90\)) object.  

## Version Information

#### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/en-us/library/8skskf63\(v=vs.90\)).

## See Also

#### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

