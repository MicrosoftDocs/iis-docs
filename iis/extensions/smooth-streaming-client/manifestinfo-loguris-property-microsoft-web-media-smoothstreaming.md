---
title: ManifestInfo.LogUris Property (Microsoft.Web.Media.SmoothStreaming)
description: "This article shows the ManifestInfo.LogUris Property syntax, which gets the list of logging Uri objects for the Microsoft.Web.Media.SmoothStreaming extension."
TOCTitle: LogUris Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.LogUris
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.manifestinfo.loguris(v=VS.90)
ms:contentKeyID: 31469301
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_LogUris
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.LogUris
dev_langs:
- csharp
- jscript
- vb
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

# LogUris Property

Gets the list of logging Uri objects.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public ReadOnly Property LogUris As IList(Of Uri)
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

```jscript
  function get LogUris () : IList<Uri>
```

### Property Value

Type: [System.Collections.Generic.IList](https://msdn.microsoft.com/library/5y536ey6)\< (Of \< ( \<'[Uri](https://msdn.microsoft.com/library/txt7706a)\> ) \> ) \>  
An IList of Uri objects.  

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
