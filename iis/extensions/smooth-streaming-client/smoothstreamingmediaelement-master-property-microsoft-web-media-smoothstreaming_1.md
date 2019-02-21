---
title: SmoothStreamingMediaElement.Master Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Master Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Master
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.master(v=VS.95)
ms:contentKeyID: 46307837
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Master
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Master
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Master
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_Master
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.Master
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_Master
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# SmoothStreamingMediaElement.Master Property

Gets or sets the master (parent) object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Master As SmoothStreamingMediaElement
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As SmoothStreamingMediaElement

value = instance.Master

instance.Master = value
```

```csharp
public SmoothStreamingMediaElement Master { get; set; }
```

```cpp
public:
property SmoothStreamingMediaElement^ Master {
    SmoothStreamingMediaElement^ get ();
    void set (SmoothStreamingMediaElement^ value);
}
```

``` fsharp
member Master : SmoothStreamingMediaElement with get, set
```

```jscript
function get Master () : SmoothStreamingMediaElement
function set Master (value : SmoothStreamingMediaElement)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)  
The master object.

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

