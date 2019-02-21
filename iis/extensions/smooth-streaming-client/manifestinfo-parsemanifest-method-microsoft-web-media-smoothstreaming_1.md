---
title: ManifestInfo.ParseManifest Method  (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ParseManifest Method
ms:assetid: M:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ParseManifest(System.IO.Stream,System.Uri)
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.parsemanifest(v=VS.95)
ms:contentKeyID: 46307672
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ParseManifest
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# ManifestInfo.ParseManifest Method

Parses the Smooth Streaming manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

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

``` fsharp
static member ParseManifest : 
        manifestStream:Stream * 
        manifestUri:Uri -> ManifestInfo 
```

```jscript
public static function ParseManifest(
    manifestStream : Stream, 
    manifestUri : Uri
) : ManifestInfo
```

### Parameters

  - manifestStream  
    Type: [System.IO.Stream](https://msdn.microsoft.com/library/8f86tw9e\(v=vs.95\))  
    A stream object that contains the manifest.

<!-- end list -->

  - manifestUri  
    Type: [System.Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))  
    The Uri of the manifest.

### Return Value

Type: [Microsoft.Web.Media.SmoothStreaming.ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [ManifestInfo](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md) object.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

