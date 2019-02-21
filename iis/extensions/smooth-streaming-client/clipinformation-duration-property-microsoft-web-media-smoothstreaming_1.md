---
title: ClipInformation.Duration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: Duration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.clipinformation.duration(v=VS.95)
ms:contentKeyID: 46307771
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
dev_langs:
- "csharp"
- "jscript"
- "vb"
- FSharp
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.get_Duration
- Microsoft.Web.Media.SmoothStreaming.ClipInformation.set_Duration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ClipInformation.Duration Property

Gets or sets the running time of the media clip.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property Duration As Duration
    Get
    Private Set
'Usage

Dim instance As ClipInformation
Dim value As Duration

value = instance.Duration
```

```csharp
public Duration Duration { get; private set; }
```

```cpp
public:
property Duration Duration {
    Duration get ();
    private: void set (Duration value);
}
```

``` fsharp
member Duration : Duration with get, private set
```

```jscript
function get Duration () : Duration
private function set Duration (value : Duration)
```

### Property Value

Type: [System.Windows.Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\))  
A [Duration](https://msdn.microsoft.com/library/ms602372\(v=vs.95\)) object.

## Remarks

For a complete example that uses the Duration property, see [Scheduling Media Clips](scheduling-media-clips.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[ClipInformation Class](clipinformation-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

