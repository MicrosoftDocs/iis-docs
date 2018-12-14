---
title: ClipContext.HasQuartileEvents Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: HasQuartileEvents Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipContext.HasQuartileEvents
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipcontext.hasquartileevents(v=VS.95)
ms:contentKeyID: 46307774
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.HasQuartileEvents
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_HasQuartileEvents
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_HasQuartileEvents
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipContext.get_HasQuartileEvents
- Microsoft.Web.Media.SmoothStreaming.ClipContext.HasQuartileEvents
- Microsoft.Web.Media.SmoothStreaming.ClipContext.set_HasQuartileEvents
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ClipContext.HasQuartileEvents Property

Gets or sets the HasQuartileEvents property. This value specifies whether the clip context has inserted quartile event markers into the clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property HasQuartileEvents As Boolean
    Get
    Friend Set
'Usage

Dim instance As ClipContext
Dim value As Boolean

value = instance.HasQuartileEvents
```

``` csharp
public bool HasQuartileEvents { get; internal set; }
```

``` c++
public:
property bool HasQuartileEvents {
    bool get ();
    internal: void set (bool value);
}
```

``` fsharp
member HasQuartileEvents : bool with get, internal set
```

``` jscript
function get HasQuartileEvents () : boolean
internal function set HasQuartileEvents (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.95\))  
A Boolean value, true if the [ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md) has quartile events, otherwise false.

## Remarks

Quartile markers indicate each 25 percent segment of the clip.

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[ClipContext Class](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

