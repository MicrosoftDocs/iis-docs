---
title: ManifestInfo.ProtectionInfo Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ProtectionInfo Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ProtectionInfo
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.manifestinfo.protectioninfo(v=VS.90)
ms:contentKeyID: 31469269
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_ProtectionInfo
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ProtectionInfo
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_ProtectionInfo
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.get_ProtectionInfo
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.ProtectionInfo
- Microsoft.Web.Media.SmoothStreaming.ManifestInfo.set_ProtectionInfo
api_type:
- Managed
topic_type:
- apiref
- kbSyntax
product_family_name: VS
---

# ProtectionInfo Property

Contains information specified in the protection element inside the manifest.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property ProtectionInfo As ProtectionInfo
'Usage

  Dim instance As ManifestInfo
Dim value As ProtectionInfo

value = instance.ProtectionInfo
```

```csharp
  public ProtectionInfo ProtectionInfo { get; internal set; }
```

```cpp
  public:
property ProtectionInfo^ ProtectionInfo {
    ProtectionInfo^ get ();
    internal: void set (ProtectionInfo^ value);
}
```

```jscript
  function get ProtectionInfo () : ProtectionInfo
internal function set ProtectionInfo (value : ProtectionInfo)
```

### Property Value

Type: [Microsoft.Web.Media.SmoothStreaming.ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md)  
A [ProtectionInfo](protectioninfo-class-microsoft-web-media-smoothstreaming_1.md) object.  

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

