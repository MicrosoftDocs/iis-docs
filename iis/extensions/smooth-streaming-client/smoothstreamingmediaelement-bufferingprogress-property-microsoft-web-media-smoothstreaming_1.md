---
title: SmoothStreamingMediaElement.BufferingProgress Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: BufferingProgress Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingProgress
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.bufferingprogress(v=VS.95)
ms:contentKeyID: 46307804
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingProgress
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_BufferingProgress
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.BufferingProgress
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_BufferingProgress
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.BufferingProgress Property

Gets or sets the buffering progress. (This property is available only for Windows Phone clients, not for Silverlight.)

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property BufferingProgress As Double
    Get
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Double

value = instance.BufferingProgress
```

```csharp
public double BufferingProgress { get; }
```

```cpp
public:
property double BufferingProgress {
    double get ();
}
```

``` fsharp
member BufferingProgress : float
```

```jscript
function get BufferingProgress () : double
```

### Property Value

Type: [System.Double](https://msdn.microsoft.com/library/643eft0t\(v=vs.95\))  
A value that indicates the buffering progress as a percentage.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

