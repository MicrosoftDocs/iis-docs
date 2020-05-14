---
title: ManifestInfo.ParseManifest Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParseManifest Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ParseManifest(System.IO.Stream,System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.manifestinfo.parsemanifest(v=VS.90)
ms:contentKeyID: 31469230
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ParseManifest
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ParseManifest
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ParseManifest Method

Parses the Smooth Streaming manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Shared Function ParseManifest ( _
    manifestStream As Stream, _
    manifestUri As Uri _
) As ManifestInfo
'Usage

  Dim manifestStream As Stream
Dim manifestUri As Uri
Dim returnValue As ManifestInfo

returnValue = ManifestInfo.ParseManifest(manifestStream, _
    manifestUri)
```

```csharp
  public static ManifestInfo ParseManifest(
    Stream manifestStream,
    Uri manifestUri
)
```

```cpp
  public:
static ManifestInfo^ ParseManifest(
    Stream^ manifestStream,
    Uri^ manifestUri
)
```

```jscript
  public static function ParseManifest(
    manifestStream : Stream,
    manifestUri : Uri
) : ManifestInfo
```

### Parameters

  - manifestStream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e)  
    A stream object that contains the manifest.  

<!-- end list -->

  - manifestUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a)  
    The Uri of the manifest.  

### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

## Version Information

### Silverlight

Supported in: 4  

### Silverlight for Windows Phone

Supported in: Windows Phone OS 7.0  

## Permissions

  - Full trust for the immediate caller. This member cannot be used by partially trusted code. For more information, see [Using Libraries from Partially Trusted Code](https://msdn.microsoft.com/library/8skskf63).

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
