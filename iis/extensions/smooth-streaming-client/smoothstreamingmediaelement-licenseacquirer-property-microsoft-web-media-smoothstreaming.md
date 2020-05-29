---
title: SmoothStreamingMediaElement.LicenseAcquirer Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LicenseAcquirer Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LicenseAcquirer
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.licenseacquirer(v=VS.90)
ms:contentKeyID: 23961172
ms.date: 05/02/2012
mtps_version: v=VS.90
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LicenseAcquirer
dev_langs:
- csharp
- jscript
- vb
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LicenseAcquirer
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# LicenseAcquirer Property

Gets or sets the license acquirer.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

  Public Property LicenseAcquirer As LicenseAcquirer
'Usage

  Dim instance As SmoothStreamingMediaElement
Dim value As LicenseAcquirer

value = instance.LicenseAcquirer

instance.LicenseAcquirer = value
```

```csharp
  public LicenseAcquirer LicenseAcquirer { get; set; }
```

```cpp
  public:
property LicenseAcquirer^ LicenseAcquirer {
    LicenseAcquirer^ get ();
    void set (LicenseAcquirer^ value);
}
```

```jscript
  function get LicenseAcquirer () : LicenseAcquirer
function set LicenseAcquirer (value : LicenseAcquirer)
```

### Property Value

Type: [System.Windows.Media.LicenseAcquirer](https://msdn.microsoft.com/library/cc838300)  
The license acquirer.  

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
