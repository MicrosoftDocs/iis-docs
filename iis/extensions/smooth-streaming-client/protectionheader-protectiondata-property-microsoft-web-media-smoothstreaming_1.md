---
title: ProtectionHeader.ProtectionData Property (Microsoft.Web.Media.SmoothStreaming)
TOCTitle: ProtectionData Property
ms:assetid: P:Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
ms:mtpsurl: https://msdn.microsoft.com/library/microsoft.web.media.smoothstreaming.protectionheader.protectiondata(v=VS.95)
ms:contentKeyID: 46307788
ms.date: 05/31/2012
mtps_version: v=VS.95
f1_keywords:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_ProtectionData
dev_langs:
- csharp
- jscript
- vb
- FSharp
- cpp
api_location:
- Microsoft.Web.Media.SmoothStreaming.dll
api_name:
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.get_ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.ProtectionData
- Microsoft.Web.Media.SmoothStreaming.ProtectionHeader.set_ProtectionData
api_type:
  - Assembly
topic_type:
- apiref
product_family_name: VS
---

# ProtectionHeader.ProtectionData Property

Gets or sets the protection data relevant to the [SystemID](protectionheader-systemid-property-microsoft-web-media-smoothstreaming_1.md) property.

**Namespace:**  [Microsoft.Web.Media.SmoothStreaming](microsoft-web-media-smoothstreaming-namespace_1.md)  
**Assembly:**  Microsoft.Web.Media.SmoothStreaming (in Microsoft.Web.Media.SmoothStreaming.dll)

## Syntax

```vb
'Declaration

Public Property ProtectionData As Byte()
    Get
    Friend Set
'Usage

Dim instance As ProtectionHeader
Dim value As Byte()

value = instance.ProtectionData
```

```csharp
public byte[] ProtectionData { get; internal set; }
```

```cpp
public:
property array<unsigned char>^ ProtectionData {
    array<unsigned char>^ get ();
    internal: void set (array<unsigned char>^ value);
}
```

``` fsharp
member ProtectionData : byte[] with get, internal set
```

```jscript
function get ProtectionData () : byte[]
internal function set ProtectionData (value : byte[])
```

### Property Value

Type: array\<[System.Byte](https://msdn.microsoft.com/library/yyb1w04y\(v=vs.95\))\[\]  
A [Byte](https://msdn.microsoft.com/library/yyb1w04y\(v=vs.95\)) array.

## Version Information

### Silverlight

Supported in: 5  

### Windows Phone

Supported in: Windows Phone OS 7.1, Windows Phone OS 7.0  

## See Also

### Reference

[ProtectionHeader Class](protectionheader-class-microsoft-web-media-smoothstreaming_1.md)

[Microsoft.Web.Media.SmoothStreaming Namespace](microsoft-web-media-smoothstreaming-namespace_1.md)
