---
title: SmoothStreamingMediaElement.LivePosition Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LivePosition Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePosition
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.liveposition(v=VS.95)
ms:contentKeyID: 46307830
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePosition
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LivePosition
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LivePosition
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.LivePosition Property

Gets the position that is nearest to the live stream that a client can seek to.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public ReadOnly Property LivePosition As Double
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.LivePosition
```

``` csharp
public double LivePosition { get; }
```

``` c++
public:
property double LivePosition {
    double get ();
}
```

``` fsharp
member LivePosition : float
```

``` jscript
function get LivePosition () : double
```

#### Property Value

Type: [System.Double](https://msdn.microsoft.com/en-us/library/643eft0t\(v=vs.95\))  
The position.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

