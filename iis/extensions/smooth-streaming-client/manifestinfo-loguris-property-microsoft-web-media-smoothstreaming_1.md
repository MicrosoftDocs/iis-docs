---
title: ManifestInfo.LogUris Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LogUris Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.LogUris
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.loguris(v=VS.95)
ms:contentKeyID: 46307773
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_LogUris
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.LogUris
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_LogUris
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.LogUris
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ManifestInfo.LogUris Property

Gets the list of logging Uri objects.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public ReadOnly Property LogUris As IList(Of Uri)
    Get
'Usage

Dim instance As ManifestInfo
Dim value As IList(Of Uri)

value = instance.LogUris
```

```csharp
public IList<Uri> LogUris { get; }
```

```cpp
public:
property IList<Uri^>^ LogUris {
    IList<Uri^>^ get ();
}
```

``` fsharp
member LogUris : IList<Uri>
```

```jscript
function get LogUris () : IList<Uri>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6\(v=vs.95\))\<[Uri](https://msdn.microsoft.com/library/txt7706a\(v=vs.95\))\>  
An IList of Uri objects.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ManifestInfo Class](manifestinfo-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

