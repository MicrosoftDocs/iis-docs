---
title: SmoothStreamingMediaElement.EnableGPUAcceleration Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EnableGPUAcceleration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EnableGPUAcceleration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.enablegpuacceleration(v=VS.90)
ms:contentKeyID: 28440987
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EnableGPUAcceleration
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EnableGPUAcceleration
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# EnableGPUAcceleration Property

Gets or sets a value that indicates whether Global Processing Unit (GPU) acceleration is enabled

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property EnableGPUAcceleration As Boolean
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.EnableGPUAcceleration

instance.EnableGPUAcceleration = value
```

```csharp
  public bool EnableGPUAcceleration { get; set; }
```

```cpp
  public:
property bool EnableGPUAcceleration {
    bool get ();
    void set (bool value);
}
```

```jscript
  function get EnableGPUAcceleration () : boolean
function set EnableGPUAcceleration (value : boolean)
```

### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/library/a28wyd50)  
true if Global Processing Unit (GPU) acceleration is enabled; otherwise, false.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

