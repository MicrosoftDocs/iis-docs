---
title: SmoothStreamingMediaElement.ManifestMerge Event (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestMerge Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.manifestmerge(v=VS.90)
ms:contentKeyID: 28440992
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
dev_langs:
- "csharp"
- "jscript"
- "vb"
- "cpp"
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ManifestMerge
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ManifestMerge
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ManifestMerge Event

Occurs when the main manifest has been parsed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Event ManifestMerge As SmoothStreamingMediaElement..::..ManifestMergeHandler
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim handler As SmoothStreamingMediaElement..::..ManifestMergeHandler

AddHandler instance.ManifestMerge, handler
```

```csharp
  public event SmoothStreamingMediaElement..::..ManifestMergeHandler ManifestMerge
```

```cpp
  public:
 event SmoothStreamingMediaElement..::..ManifestMergeHandler^ ManifestMerge {
    void add (SmoothStreamingMediaElement..::..ManifestMergeHandler^ value);
    void remove (SmoothStreamingMediaElement..::..ManifestMergeHandler^ value);
}
```

```jscript
  JScript does not support events.
```

## Remarks

This event provides the option to merge external manifests with the main manifest.

If errors occur during this event, it throws an exception that will be caught and reported by the [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) event, which will stop playback. For more information, see [Manifest Merge (IIS Smooth Streaming)](manifest-merge.md).

## Version Information

### Silverlight

Supported in: 4  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

