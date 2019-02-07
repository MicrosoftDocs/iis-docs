---
title: SmoothStreamingMediaElement.CurrentLinearClipContext Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: CurrentLinearClipContext Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentLinearClipContext
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.currentlinearclipcontext(v=VS.95)
ms:contentKeyID: 46307816
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentLinearClipContext
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentLinearClipContext
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CurrentLinearClipContext
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.CurrentLinearClipContext
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_CurrentLinearClipContext
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_CurrentLinearClipContext
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.CurrentLinearClipContext Property

Gets the current linear clip context.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property CurrentLinearClipContext As ClipContext
    Get
    Private Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As ClipContext

value = instance.CurrentLinearClipContext
```

``` csharp
public ClipContext CurrentLinearClipContext { get; private set; }
```

``` c++
public:
property ClipContext^ CurrentLinearClipContext {
    ClipContext^ get ();
    private: void set (ClipContext^ value);
}
```

``` fsharp
member CurrentLinearClipContext : ClipContext with get, private set
```

``` jscript
function get CurrentLinearClipContext () : ClipContext
private function set CurrentLinearClipContext (value : ClipContext)
```

#### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ClipContext](clipcontext-class-microsoft-web-media-smoothstreaming_1.md)  
The clip context.

## Remarks

If no linear clip is playing, the context is nulla null reference (Nothing in Visual Basic).

## Version Information

#### Silverlight

Supported in: 5  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

