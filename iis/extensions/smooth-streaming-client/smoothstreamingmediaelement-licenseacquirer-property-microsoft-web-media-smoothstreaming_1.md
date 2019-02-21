---
title: SmoothStreamingMediaElement.LicenseAcquirer Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: LicenseAcquirer Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LicenseAcquirer
ms:mtpsurl: https://msdn.microsoft.com/en-us/library/microsoft.web.media.smoothstreaming.smoothstreamingmediaelement.licenseacquirer(v=VS.95)
ms:contentKeyID: 46307828
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.get_LicenseAcquirer
- Microsoft.Web.Media.SmoothStreaming.SmoothStreamingMediaElement.set_LicenseAcquirer
dev_langs:
- csharp
- jscript
- vb
- FSharp
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

# SmoothStreamingMediaElement.LicenseAcquirer Property

Gets or sets the license acquirer.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property LicenseAcquirer As LicenseAcquirer
    Get
    Set
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

``` fsharp
member LicenseAcquirer : LicenseAcquirer with get, set
```

```jscript
function get LicenseAcquirer () : LicenseAcquirer
function set LicenseAcquirer (value : LicenseAcquirer)
```

### Property Value

Type: [System.Windows.Media.LicenseAcquirer](https://msdn.microsoft.com/library/cc838300\(v=vs.95\))  
The license acquirer.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[SmoothStreamingMediaElement Class](smoothstreamingmediaelement-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)

