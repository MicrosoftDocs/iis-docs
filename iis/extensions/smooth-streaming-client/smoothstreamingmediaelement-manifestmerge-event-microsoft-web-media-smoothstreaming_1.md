---
title: SmoothStreamingMediaElement.ManifestMerge Event (Microsoft.Web.Media.SmoothStreaming)
description: Describes the SmoothStreamingMediaElement.ManifestMerge event and details its syntax, remarks, and Silverlight information.
TOCTitle: ManifestMerge Event
ms:assetid: E:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.manifestmerge(v=VS.95)
ms:contentKeyID: 46307522
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.add_ManifestMerge
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestMerge
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.remove_ManifestMerge
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# SmoothStreamingMediaElement.ManifestMerge Event

Occurs when the main manifest has been parsed.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Event ManifestMerge As SmoothStreamingMediaElement.ManifestMergeHandler
'Usage

Dim instance As SmoothStreamingMediaElement
Dim handler As SmoothStreamingMediaElement.ManifestMergeHandler

AddHandler instance.ManifestMerge, handler
```

```csharp
public event SmoothStreamingMediaElement.ManifestMergeHandler ManifestMerge
```

```cpp
public:
 event SmoothStreamingMediaElement.ManifestMergeHandler^ ManifestMerge {
    void add (SmoothStreamingMediaElement.ManifestMergeHandler^ value);
    void remove (SmoothStreamingMediaElement.ManifestMergeHandler^ value);
}
```

``` fsharp
member ManifestMerge : <SmoothStreamingMediaElement.ManifestMergeHandler,
    EventArgs>
```

```jscript
JScript supports the use of events, but not the declaration of new ones.
```

## Remarks

This event provides the option to merge external manifests with the main manifest.

If errors occur during this event, it throws an exception that will be caught and reported by the [SmoothStreamingErrorOccurred](smoothstreamingmediaelement-smoothstreamingerroroccurred-event-microsoft-web-media-smoothstreaming_1.md) event, which will stop playback. For more information, see [Manifest Merge](manifest-merge.md).

## Version Information

### Silverlight

Supported in: 5  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
