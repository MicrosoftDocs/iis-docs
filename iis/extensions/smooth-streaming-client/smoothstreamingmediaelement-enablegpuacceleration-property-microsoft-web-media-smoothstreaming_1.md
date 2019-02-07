---
title: SmoothStreamingMediaElement.EnableGPUAcceleration Property  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: EnableGPUAcceleration Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EnableGPUAcceleration
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.enablegpuacceleration(v=VS.95)
ms:contentKeyID: 46307819
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_EnableGPUAcceleration
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_EnableGPUAcceleration
dev_langs:
- CSharp
- JScript
- VB
- FSharp
- c++
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
ROBOTS: INDEX,FOLLOW
---

# SmoothStreamingMediaElement.EnableGPUAcceleration Property

Gets or sets a value that indicates whether Global Processing Unit (GPU) acceleration is enabled

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

``` vb
'Declaration

Public Property EnableGPUAcceleration As Boolean
    Get
    Set
'Usage

Dim instance As SmoothStreamingMediaElement
Dim value As Boolean

value = instance.EnableGPUAcceleration

instance.EnableGPUAcceleration = value
```

``` csharp
public bool EnableGPUAcceleration { get; set; }
```

``` c++
public:
property bool EnableGPUAcceleration {
    bool get ();
    void set (bool value);
}
```

``` fsharp
member EnableGPUAcceleration : bool with get, set
```

``` jscript
function get EnableGPUAcceleration () : boolean
function set EnableGPUAcceleration (value : boolean)
```

#### Property Value

Type: [System.Boolean](https://msdn.microsoft.com/en-us/library/a28wyd50\(v=vs.95\))  
true if Global Processing Unit (GPU) acceleration is enabled; otherwise, false.

## Version Information

#### Silverlight

Supported in: 5  

#### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

#### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

