---
title: SmoothStreamingMediaElement.ManifestInfo Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ManifestInfo Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.manifestinfo(v=VS.90)
ms:contentKeyID: 31469194
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ManifestInfo
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_ManifestInfo
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.ManifestInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
ROBOTS: INDEX,FOLLOW
---

# ManifestInfo Property

Gets the manifest info object.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property ManifestInfo As ManifestInfo
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As ManifestInfo

value = instance.ManifestInfo
```

```csharp
  public ManifestInfo ManifestInfo { get; }
```

```cpp
  public:
property ManifestInfo^ ManifestInfo {
    ManifestInfo^ get ();
}
```

```jscript
  function get ManifestInfo () : ManifestInfo
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)  
The manifest info object.  

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

